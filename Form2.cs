using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace trabajofinal
{
    public partial class Form2 : Form
    {
        // Variables para el movimiento del formulario con el mouse
        private bool isDragging = false;
        private Point lastCursorPosition;

        // Cadena de conexión a la base de datos (ajústala según tu configuración)
        private string connectionString = "Data Source=localhost;Initial Catalog=Matricula;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();

            // Ocultar la barra de título del formulario
            this.FormBorderStyle = FormBorderStyle.None;

            // Suscribir los eventos del mouse para el movimiento del formulario
            this.MouseDown += Form2_MouseDown;
            this.MouseMove += Form2_MouseMove;
            this.MouseUp += Form2_MouseUp;

            // Agregar elementos al ComboBox
            comboBox1.Items.Add("MatriculaInicial");
            comboBox1.Items.Add("MatriculaSecundaria");
            comboBox1.Items.Add("MatriculaPrimaria");

            // Suscribir el evento SelectedIndexChanged del ComboBox
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier código que deseas ejecutar cuando el formulario se carga.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();

            // Puedes implementar aquí la lógica para cargar datos según la tabla seleccionada
            switch (selectedTable)
            {
                case "MatriculaInicial":
                    CargarDatos(selectedTable);
                    break;

                case "MatriculaSecundaria":
                    CargarDatos(selectedTable);
                    break;

                case "MatriculaPrimaria":
                    CargarDatos(selectedTable);
                    break;

                default:
                    break;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tu código para manejar el evento aquí
        }

        private void CargarDatos(string tableName)
        {
            // Consulta SQL para seleccionar todos los registros de la tabla
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear un adaptador de datos para ejecutar la consulta
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos del adaptador
                    adapter.Fill(dataTable);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pregunta al usuario para confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Obtén el valor de la columna "ID" de la fila seleccionada
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    // Obtén la tabla seleccionada del ComboBox
                    string selectedTable = comboBox1.SelectedItem.ToString();

                    // Construye la consulta DELETE SQL
                    string deleteQuery = $"DELETE FROM {selectedTable} WHERE ID = @ID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Crea un comando SQL con la consulta DELETE
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                            {
                                // Agrega el parámetro @ID y establece su valor
                                cmd.Parameters.AddWithValue("@ID", id);

                                // Ejecuta la consulta DELETE
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Verifica si se eliminó con éxito
                                if (rowsAffected > 0)
                                {
                                    // Elimina la fila del DataGridView
                                    dataGridView1.Rows.Remove(selectedRow);
                                    MessageBox.Show("Registro eliminado con éxito.");
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el registro.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtén los valores actuales de la fila seleccionada
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nuevoPrimerNombre = selectedRow.Cells["PrimerNombre"].Value.ToString();
                string nuevoGrado = selectedRow.Cells["Grado"].Value.ToString();
                string nuevaSeccion = selectedRow.Cells["Seccion"].Value.ToString();
                string nuevoPrimerApellido = selectedRow.Cells["PrimerApellido"].Value.ToString();
                string nuevoSegundoApellido = selectedRow.Cells["SegundoApellido"].Value.ToString();
                string nuevoCelular = selectedRow.Cells["Celular"].Value.ToString();
                string nuevaDireccion = selectedRow.Cells["Direccion"].Value.ToString();
                string nuevoEmail = selectedRow.Cells["Email"].Value.ToString();
                DateTime nuevaFechaNacimiento = Convert.ToDateTime(selectedRow.Cells["FechaNacimiento"].Value);
                string nuevasObservaciones = selectedRow.Cells["Observaciones"].Value.ToString();
                string nuevoNivelAcademico = selectedRow.Cells["NivelAcademico"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string tableName = comboBox1.SelectedItem.ToString(); // Nombre de la tabla seleccionada en el ComboBox

                        string updateQuery = $"UPDATE {tableName} SET " +
                            "PrimerNombre = @PrimerNombre, " +
                            "Grado = @Grado, " +
                            "Seccion = @Seccion, " +
                            "PrimerApellido = @PrimerApellido, " +
                            "SegundoApellido = @SegundoApellido, " +
                            "Celular = @Celular, " +
                            "Direccion = @Direccion, " +
                            "Email = @Email, " +
                            "FechaNacimiento = @FechaNacimiento, " +
                            "Observaciones = @Observaciones " +
                            "WHERE Id = @ID";

                        SqlCommand cmd = new SqlCommand(updateQuery, connection);
                        cmd.Parameters.AddWithValue("@PrimerNombre", nuevoPrimerNombre);
                        cmd.Parameters.AddWithValue("@Grado", nuevoGrado);
                        cmd.Parameters.AddWithValue("@Seccion", nuevaSeccion);
                        cmd.Parameters.AddWithValue("@PrimerApellido", nuevoPrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", nuevoSegundoApellido);
                        cmd.Parameters.AddWithValue("@Celular", nuevoCelular);
                        cmd.Parameters.AddWithValue("@Direccion", nuevaDireccion);
                        cmd.Parameters.AddWithValue("@Email", nuevoEmail);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", nuevaFechaNacimiento);
                        cmd.Parameters.AddWithValue("@Observaciones", nuevasObservaciones);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("La fila seleccionada ha sido actualizada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para actualizar.");
            }
        }

    }
}
