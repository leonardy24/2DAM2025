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
    public partial class FormMisJuegos : Form
    {

        private string usuario;
        private MySqlConnection conn;
        public FormMisJuegos(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.conn = conn;

            this.flowLayoutPanelMisJuegos.AutoScroll = true;

            try
            {

                string connString = "Server=localhost;Database=control_empleados;User ID=root;Password=31416;Pooling=true;";

                conn = new MySqlConnection(connString);

                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * from misjuegos WHERE usuario = @usuario", conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);

               MySqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {

                    Juego juego = new Juego(Convert.ToInt32(reader["id_Juego"].ToString()), reader["titulo"].ToString(), reader["descripcion"].ToString(), reader.GetDouble(reader.GetOrdinal("precio")), reader["url_img"].ToString(), usuario);

                    this.flowLayoutPanelMisJuegos.Controls.Add(juego);

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL INTENTAR CONECTAR A LA BASE DE DATOS");
            }

        }

        private void FormMisJuegos_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelMisJuegos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
