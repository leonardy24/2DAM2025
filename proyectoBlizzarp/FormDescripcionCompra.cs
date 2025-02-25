using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBlizzarp
{
    public partial class FormDescripcionCompra : Form
    {

        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Descripcion { get; set; }
        private double Precio { get; set; }
        private string URL { get; set; }



        public FormDescripcionCompra(int id, String titulo, String descripcion, double precio, string url)
        {

            InitializeComponent();
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.URL = url;




           
            labelTitulo.Text = Titulo;
            labelPrecio.Text = Precio.ToString();
            labelDecrip.Text = Descripcion;
            pictureBoxJuego.Load(URL);
            pictureBoxJuego.SizeMode = PictureBoxSizeMode.StretchImage;




        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {

            FormCompra compra = new FormCompra(this.Id, this.Titulo, this.Descripcion, this.Precio, this.URL);

            compra.Show();

            

        }
    }
}
