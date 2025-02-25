using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class GestionCatalogo : Form
    {

        private List<int> filasModificadas = new List<int>();
        MySqlConnection conn;
        String URL_Img;
        public GestionCatalogo()
        {
            InitializeComponent();

            dataGridViewCatalogo.CellValueChanged += dataGridViewCatalogo_CellValueChanged;

            String conexion= "Server=localhost;Database=control_catalogo;User ID=root;Password=31416;Pooling=true;";

            conn = new MySqlConnection(conexion);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL INTENTAR CONECTAR A LA BASE DE DATOS");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM todoslosjuegos";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);


            DataTable dataTableCatalogo = new DataTable();
            adaptador.Fill(dataTableCatalogo);


            dataGridViewCatalogo.DataSource = dataTableCatalogo;

            dataGridViewCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCatalogo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCatalogo.ScrollBars = ScrollBars.Both;
            dataGridViewCatalogo.ReadOnly = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelecImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog selecImage= new OpenFileDialog
            {
                Title = "Seleccionar Imagen",
                Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false
            };

            if (selecImage.ShowDialog() == DialogResult.OK)
            {
                URL_Img = selecImage.FileName;
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand agregar = new MySqlCommand("INSERT INTO todoslosjuegos(titulo, descripcion, precio, url_img) values(@titulo, @descripcion,@precio,@url_img);", conn);

                String titulo = textBoxTitulo.Text;
                String descrip = textBoxDescripcion.Text;
                String url = URL_Img;
                String precio= textBoxPrecio.Text;


                if (string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(descrip) && string.IsNullOrEmpty(url) && string.IsNullOrEmpty(precio))
                {
                    MessageBox.Show("Los campos no pueden estar vacios!");


                    return;
                }

                
               


                agregar.Parameters.AddWithValue("@titulo", textBoxTitulo.Text);
                agregar.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
                agregar.Parameters.AddWithValue("@precio", Convert.ToDouble(textBoxPrecio.Text));
                agregar.Parameters.AddWithValue("@url_img", URL_Img );

                int rowsAffected = agregar.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Juego agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el Juego.");
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR " + ex);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dataGridViewCatalogo.SelectedRows.Count > 0)
                {
                    // Obtener el ID del registro seleccionado (suponiendo que el primer valor de la fila es el ID)
                    int idJuego = Convert.ToInt16(dataGridViewCatalogo.SelectedRows[0].Cells[0].Value); // Ajusta el índice según tu estructura de tabla

                    // Crear la consulta SQL para eliminar el registro
                    string query = "DELETE FROM todoslosjuegos WHERE id_Juegos = @idJuego"; // Cambia 'id' por el nombre de la columna que es la clave primaria



                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idJuego", idJuego); // Añadir el parámetro para la consulta SQL


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


                string query = "SELECT * FROM todoslosjuegos";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridViewCatalogo.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dataGridViewCatalogo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewCatalogo.EndEdit();

                // Verificar si la fila modificada ya ha sido registrada
                int id = Convert.ToInt32(dataGridViewCatalogo.Rows[e.RowIndex].Cells[0].Value); // Asumimos que la columna 0 es el ID

                MessageBox.Show(id+"");

                if (!filasModificadas.Contains(id))
                {
                    filasModificadas.Add(id); // Registrar la fila modificada por su ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cambio: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {



                // Recorrer las filas modificadas y guardar los cambios en la base de datos
                foreach (int idUsu in filasModificadas)
                {
                    // Buscar la fila por su ID en el DataGridView
                    var fila = dataGridViewCatalogo.Rows.Cast<DataGridViewRow>()
                                    .FirstOrDefault(r => Convert.ToInt16(r.Cells[0].Value) == idUsu); // Filtrar por ID

                    if (fila != null)
                    {
                        // Obtener los valores modificados
                        int id_Juegos = Convert.ToInt16(fila.Cells[0].Value) ;
                        string titulo = fila.Cells[1].Value.ToString();
                        string descripcion = fila.Cells[2].Value.ToString();
                        double precio = Convert.ToDouble(fila.Cells[3].Value);
                        string url_img = fila.Cells[4].Value.ToString();



                        // Crear la consulta SQL para actualizar el registro
                        string query = "UPDATE todoslosjuegos SET titulo = @titulo, descripcion = @descripcion, precio = @precio, url_img= @url_img WHERE id_Juegos = @id_Juegos";

                        // Ejecutar la consulta SQL
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_Juegos", id_Juegos);
                            cmd.Parameters.AddWithValue("@titulo", titulo);
                            cmd.Parameters.AddWithValue("@descripcion", descripcion);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@url_img", url_img);
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
    }
}
