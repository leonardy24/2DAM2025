using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoBlizzarp
{
    public partial class FormCompra : Form
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Descripcion { get; set; }
        private double Precio { get; set; }
        private string URL { get; set; }

        private MySqlConnection conexionEmpleados { get; set; }

        private Timer timer;

        private string usuario { get; set; }

        public FormCompra(int id, String titulo, String descripcion, double precio, string url,string usuario)
        {
            InitializeComponent();
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.URL = url;
            this.usuario = usuario;
           
            //CREO LA CONEXCION A LA BASE DE DATOS
           this.conexionEmpleados = new MySqlConnection("Server=localhost;Database=control_empleados;User ID=root;Password=31416;Pooling=true;");

            //CREO EL PANEL JUEGO Y LO VUELVO A MOSTRAR
            Juego juegos = new Juego(this.Id, this.Titulo, this.Descripcion, this.Precio, this.URL, this.usuario);

            flowLayoutPanelJuego.Controls.Add(juegos);
            flowLayoutPanelJuego.Margin = new Padding(0); // Sin margen
            flowLayoutPanelJuego.Padding = new Padding(0); // Sin relleno interno
            flowLayoutPanelJuego.AutoSize = true; // Se ajusta automáticamente al contenido (opcional)

            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 100;
            this.progressBar.Value = 1;

            timer = new Timer { Interval = 1000 }; // 100ms
            timer.Tick += Timer_Tick;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCompra_Load(object sender, EventArgs e)
        {

        }

        //AGREGA UNA NUEVA COMPRA
        private void buttonPagar_Click(object sender, EventArgs e)
        {

            //SI ALGUNO DE LOS CAMPOS ESTAN VACIOS ME LANZA UN MENSAJE
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) && string.IsNullOrWhiteSpace(textBoxNumTarjeta.Text) && string.IsNullOrWhiteSpace(textBoxNumTarjeta.Text) && string.IsNullOrWhiteSpace(textBoxCVV.Text))
            {

                 MessageBox.Show("los campos no pueden estar vacios");
                return;
            }


            try
            {
                //CREO LA CONEXCION A LA BASDE DE DATOS, Y REALIZO LA INSERCION 
                conexionEmpleados.Open();

                string queryAgg = "INSERT INTO misjuegos (Titulo,descripcion,precio,url_img,id_Juego,usuario) VALUES (@titulo,@descripcion,@precio,@url_img,@id_Juego,@usuario)";
                MySqlCommand mysComando = new MySqlCommand(queryAgg, conexionEmpleados);

                mysComando.Parameters.AddWithValue("@titulo", Titulo);
                mysComando.Parameters.AddWithValue("@descripcion", Descripcion);
                mysComando.Parameters.AddWithValue("@precio", Precio);
                mysComando.Parameters.AddWithValue("@url_img", URL);
                mysComando.Parameters.AddWithValue("@id_Juego", Id);
                mysComando.Parameters.AddWithValue("@usuario", usuario);

                mysComando.ExecuteNonQuery();

                //COLOCO A FUNCIONAR EL PROGRES
                progressBar.Value = 0; // Reiniciar el progreso 
                timer.Start();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(""+ex);
            }



            

        }

        // PROGRESO DEL PROGRESBAR
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                this.labelCompra.Text = "Conectando con su banco";
                progressBar.Value += 10; // Incrementa el progreso
            }
            else
            {
                
                timer.Stop();
                this.labelCompra.Text = "Pago completado";
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
