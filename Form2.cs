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
    }
}
