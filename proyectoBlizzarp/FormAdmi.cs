using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBlizzarp
{
    public partial class FormAdmi : Form
    {

        private MySqlConnection conn;

        private List<String> filasModificadas = new List<String>();

        public FormAdmi(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuario = Usuario.Text;

            String contrasena = Contrasena.Text;

            int isAdmin;

            if (radioButtonEsAdmin.Checked)
            {
                //es administrador
                isAdmin = 1;
            }
            else
            {
                //es usuario
                isAdmin = 0;
            }

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Los campos no pueden estar vacios!");

                return;
            }

            try
            {

                MySqlCommand agregar = new MySqlCommand("INSERT INTO empleados (usuario,contrasena,isAdmin) VALUES (@usuario, @contrasena,@isAdmin)", conn);

                agregar.Parameters.AddWithValue("@usuario", usuario);
                agregar.Parameters.AddWithValue("@contrasena", contrasena);
                agregar.Parameters.AddWithValue("@isAdmin", isAdmin);

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
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR " + ex);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);


            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ReadOnly = false;
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si hay una fila seleccionada
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener el ID del registro seleccionado (suponiendo que el primer valor de la fila es el ID)
                    String nomSeleccionado = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value); // Ajusta el índice según tu estructura de tabla

                    // Crear la consulta SQL para eliminar el registro
                    string query = "DELETE FROM empleados WHERE usuario = @usuario"; // Cambia 'id' por el nombre de la columna que es la clave primaria

                   
                    
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@usuario", nomSeleccionado); // Añadir el parámetro para la consulta SQL

                        
                        cmd.ExecuteNonQuery();  // Ejecutar la eliminación
                        MessageBox.Show("Registro eliminado exitosamente");

                        // Recargar los datos del DataGridView
                        CargarDatos();
                    
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                
                
                    string query = "SELECT * FROM empleados";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar si la fila modificada ya ha sido registrada
                String filaID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); // Asumimos que la columna 0 es el ID

                MessageBox.Show(filaID);

                if (!filasModificadas.Contains(filaID))
                {
                    filasModificadas.Add(filaID); // Registrar la fila modificada por su ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cambio: " + ex.Message);
            }
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {


            try
            {
                
                    

                    // Recorrer las filas modificadas y guardar los cambios en la base de datos
                    foreach (String idUsu in filasModificadas)
                    {
                        // Buscar la fila por su ID en el DataGridView
                        var fila = dataGridView1.Rows.Cast<DataGridViewRow>()
                                        .FirstOrDefault(r => Convert.ToString(r.Cells[0].Value) == idUsu); // Filtrar por ID

                        if (fila != null)
                        {
                            // Obtener los valores modificados
                           string usuarioID = fila.Cells[0].Value.ToString();  
                            string nuevaContraseña = fila.Cells[1].Value.ToString();  
                             int isAdmin = Convert.ToInt32(fila.Cells[2].Value);

                            // Crear la consulta SQL para actualizar el registro
                            string query = "UPDATE empleados SET contrasena = @contrasena, isAdmin = @isAdmin WHERE usuario = @usuario";

                            // Ejecutar la consulta SQL
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@usuario", usuarioID);
                                cmd.Parameters.AddWithValue("@contrasena", nuevaContraseña);
                                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                                cmd.ExecuteNonQuery();  // Ejecutar la actualización
                            }

                        MessageBox.Show("Los cambios se han guardado exitosamente.");
                    }
                    }

                    

                    // Limpiar la lista de filas modificadas
                    filasModificadas.Clear();

                    // Recargar los datos en el DataGridView para reflejar los cambios
                    CargarDatos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void FormAdmi_Load(object sender, EventArgs e)
        {

        }

        private void buttonCatalogoJuegos_Click(object sender, EventArgs e)
        {

            GestionCatalogo gestionCatalogo = new GestionCatalogo();
            gestionCatalogo.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
