using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Mysqlx.Notice.Warning.Types;
using MySql.Data.MySqlClient;

namespace proyectoBlizzarp
{
    public class Juego:Panel
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Descripcion { get; set; }
        private double Precio {  get; set; }
        private string URL { get; set; }

       
        private string usuario;
       

        public Juego(int id, String titulo, String descripcion, double precio, string url,string usuario)
        {

            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.URL = url;
           
            this.usuario = usuario;

            this.Size = new Size(195, 450); // Tamaño del panel
            this.BackColor = Color.Transparent; // Color de fondo
            this.Margin = new Padding(10);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Click += Panel_Click;

            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(url),  
                SizeMode = PictureBoxSizeMode.StretchImage,       
                Dock = DockStyle.Top,
                Height = this.Height - 160,
                Width = this.Width
                
            };

            //PARA QUE ME RECONOZCA LA IAMGEN EN EL EVENTO CLICK, PORQUE SOLO RECONOCE SOLO EL PANEL
            pictureBox.Click += Panel_Click;

            // Crear un Label para el texto
            Label labelTitulo = new Label
            {
                Text = Titulo,
                Font = new Font("Agency FB", 20, FontStyle.Bold),  // Fuente personalizada
                ForeColor = Color.White,
                AutoSize = true,                    // Ajustar el tamaño del label al contenido
                TextAlign = ContentAlignment.MiddleCenter, // Centrar el texto en el Label
           

            };

            //creo el label para el precio
            Label precioLabel = new Label
            {
                Text = "€"+Precio.ToString(),
                Font = new Font("Agency FB", 20, FontStyle.Bold),  // Fuente personalizada
                ForeColor = Color.White,
                AutoSize = true,                    // Ajustar el tamaño del label al contenido
                TextAlign = ContentAlignment.MiddleCenter, // Centrar el texto en el Label
            };

            //creo label para la descpccion
            Label descripLabel = new Label
            {
                Text = Descripcion,
                Font = new Font("Agency FB", 14, FontStyle.Bold),  // Fuente personalizada
                ForeColor = Color.White,
                AutoSize = true,                    // Ajustar el tamaño del label al contenido
                TextAlign = ContentAlignment.MiddleCenter, // Centrar el texto en el Label
            };

            // Primero, calculamos la posición X y Y
            int xPos = (this.Width - labelTitulo.Width-20);  // Centrar horizontalmente
            int yPos = (this.Height - labelTitulo.Height)-5;     // Colocar en la parte inferior

            // Ahora asignamos la posición calculada
            labelTitulo.Location = new Point(xPos, yPos - 110);
            precioLabel.Location = new Point(xPos, yPos-80);
            descripLabel.Location = new Point(xPos, yPos-50);


            //CREO EL BOTON
            
            Button buttonComprar = new Button
            {
                Text = "Compra",
                Font = new Font("Agency FB", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, yPos - 40),
                Size = new Size(150, 50)
            };



            this.Controls.Add(pictureBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(descripLabel);
            this.Controls.Add(labelTitulo);
           


            // Configurar el panel
            this.DoubleBuffered = true; // Evita parpadeos al redibujar el panel



        }
        private void Panel_Click(object sender, EventArgs e)
        {
           

            FormDescripcionCompra compra = new FormDescripcionCompra(this.Id,this.Titulo, this.Descripcion,this.Precio,this.URL,this.usuario);
            compra.Show();
        }


    }

    internal class flowLayoutPanel
    {
    }


}
