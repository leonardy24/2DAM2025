using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBlizzarp
{

    public partial class Form1 : Form
    {
        MySqlConnection conn;
        List<Juego> panelListJuegos = new List<Juego>();
        String usuario;

        public Form1(String usuario)
        {
            InitializeComponent();
            TextUsuario.Text = usuario;
            this.usuario = usuario;
            


            //AL INICIAR HAGO LA CONEXION
            string connString = "Server=localhost;Database=control_catalogo;User ID=root;Password=31416;Pooling=true;";

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * from juegosdestacados", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                  Juego juego = new Juego(Convert.ToInt32(reader["Id_JuegoDestacados"].ToString()), reader["titulo"].ToString(), reader["descripcion"].ToString(),Convert.ToDouble(reader["precio"].ToString()) , reader["url_img"].ToString(), usuario);

                    flowLayoutPanelCatalago.Controls.Add(juego);

                }

                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL INTENTAR CONECTAR A LA BASE DE DATOS");
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            TodosLosJuego tdJuegos = new TodosLosJuego(conn, usuario);
            tdJuegos.Show();

        }

        private void flowLayoutPanelCatalago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TituloJuego_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //DEBO PASAR EL USUARIO
            //PARA LUEGO HACER EL SELECT

            FormMisJuegos misJuegos = new FormMisJuegos(usuario);

            misJuegos.Show();

        }
    }
}
