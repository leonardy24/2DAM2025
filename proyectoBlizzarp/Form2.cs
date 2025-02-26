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

    
    public partial class Form2 : Form
    {

        MySqlConnection conexionEmpleado;


        public Form2()
        {
            InitializeComponent();

            //AL INICIAR HAGO LA CONEXION
            string connString = "Server=localhost;Database=control_empleados;User ID=root;Password=31416;Pooling=true;";

            conexionEmpleado = new MySqlConnection(connString);
            try
            {
                conexionEmpleado.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL INTENTAR CONECTAR A LA BASE DE DATOS");
            }

            

        }


        private void contrasenaUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreUsu_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String usuario = nombreUsu.Text;

            String contra = contrasenaUsu.Text;

            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra))
                {
                    MessageBox.Show("Los campos no pueden estar vacios!");

                    return;
                }

                MySqlCommand cmd = new MySqlCommand("SELECT * from empleados", conexionEmpleado);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    String usuBBDD = reader["usuario"].ToString();
                    String contraBBDD = reader["contrasena"].ToString();
                    int isAdmin = (int)reader["isAdmin"];


                    if (usuario.Equals(usuBBDD) && contra.Equals(contraBBDD)&&isAdmin==0)
                    {

                        //FORMULARIO USUARIO
                        Form1 inicioUsuario = new Form1(usuario);

                        inicioUsuario.Show();

                        reader.Close();

                        conexionEmpleado.Close();


                        return;
                    }else if (usuario.Equals(usuBBDD) && contra.Equals(contraBBDD) && isAdmin==1)
                    {
                        //FORMULARIO ADMIN

                        FormAdmi ventaAdministrador = new FormAdmi(conexionEmpleado);
                        ventaAdministrador.Show();
                        reader.Close();

                        return;
                    }


                }

                reader.Close ();
                DialogResult resultado = MessageBox.Show("No existe el usuario. Usuario o contraseña incorrecta");


                
            }
            catch (MySqlException ex) {

                MessageBox.Show("ERROR "+ex);
            }

          

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AL HACER CLICK LLAMO AL OTRO FORMULARIO

            Form3 crearUsu = new Form3(conexionEmpleado);
            crearUsu.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
