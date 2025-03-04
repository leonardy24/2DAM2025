using MySql.Data.MySqlClient;
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
    public partial class TodosLosJuego : Form
    {

       // MySqlConnection conexionEmpleados;

        string usuario;
        public TodosLosJuego(MySqlConnection conn, string usuario )
        {
            InitializeComponent();
           
            this.usuario = usuario;
            this.flowLayoutPanelTodosLosJuegos.AutoScroll = true;

            try
            {
               

                MySqlCommand cmd = new MySqlCommand("SELECT * from todoslosjuegos", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Juego juego = new Juego(Convert.ToInt32(reader["id_Juegos"].ToString()), reader["titulo"].ToString(), reader["descripcion"].ToString(), reader.GetDouble(reader.GetOrdinal("precio")), reader["url_img"].ToString(),usuario);

                    flowLayoutPanelTodosLosJuegos.Controls.Add(juego);

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL INTENTAR CONECTAR A LA BASE DE DATOS");
            }

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTodosLosJuegos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPresentacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
