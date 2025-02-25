using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBlizzarp
{
    public partial class FormCompra : Form
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Descripcion { get; set; }
        private double Precio { get; set; }
        private string URL { get; set; }

        private Timer timer;

        public FormCompra(int id, String titulo, String descripcion, double precio, string url)
        {
            InitializeComponent();
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.URL = url;

            Juego juegos = new Juego(this.Id,this.Titulo,this.Descripcion,this.Precio,this.URL);

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

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            //COLOCO A FUNCIONAR EL PROGRES
            progressBar.Value = 0; // Reiniciar el progreso 
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                this.labelCompra.Text = "Conectando con su banco";
                progressBar.Value += 5; // Incrementa el progreso
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Proceso completado");
            }
        }
    }
}
