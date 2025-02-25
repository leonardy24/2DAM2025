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
    public partial class Form3 : Form
    {

        MySqlConnection conn;

        public Form3(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioNuevo_TextChanged(object sender, EventArgs e)
        {

        }



        private void ContraseñaNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuarioNueva = usuarioNuevo.Text;

            String contraNueva = contrasenaNuevo.Text;

            if (string.IsNullOrEmpty(usuarioNueva) || string.IsNullOrEmpty(contraNueva))
            {
                MessageBox.Show("Los campos no pueden estar vacios!");

                return;
            }

            try
            {

                MySqlCommand agregar = new MySqlCommand("INSERT INTO empleados (usuario,contrasena) VALUES (@usuario, @contrasena)", conn);

                agregar.Parameters.AddWithValue("@usuario", usuarioNueva);
                agregar.Parameters.AddWithValue("@contrasena", contraNueva);

                int rowsAffected = agregar.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Empleado agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el empleado.");
                }

            }
            catch (MySqlException ex) {

                MessageBox.Show("ERROR "+ex);
            }



           


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
