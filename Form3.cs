using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace trabajofinal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //aqui se añadira 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //alter
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Los campos de Primer Nombre, Primer Apellido y Email son obligatorios y no pueden quedar vacíos.");
                return; // Salir de la función sin realizar la inserción
            }

            // Verificar si el campo de correo electrónico contiene un '@'
            if (!textBox3.Text.Contains("@"))
            {
                MessageBox.Show("El campo de correo electrónico debe contener un '@'.");
                return; // Salir de la función sin realizar la inserción
            }

            string connectionString = "Data Source=localhost;Initial Catalog=Matricula;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para la inserción de datos en la tabla MatriculaInicial
                    string insertQuery = "INSERT INTO MatriculaInicial (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Celular, Direccion, Email, FechaNacimiento, Observaciones) VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Celular, @Direccion, @Email, @FechaNacimiento, @Observaciones)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Completar automáticamente los campos que estén vacíos
                        if (string.IsNullOrWhiteSpace(textBox8.Text))
                            textBox8.Text = "";
                        if (string.IsNullOrWhiteSpace(textBox10.Text))
                            textBox10.Text = "";
                        if (string.IsNullOrWhiteSpace(textBox1.Text))
                            textBox1.Text = "";
                        if (string.IsNullOrWhiteSpace(textBox2.Text))
                            textBox2.Text = "";
                        if (string.IsNullOrWhiteSpace(textBox4.Text))
                            textBox4.Text = "";
                        if (string.IsNullOrWhiteSpace(textBox5.Text))
                            textBox5.Text = "";

                        cmd.Parameters.AddWithValue("@PrimerNombre", textBox7.Text);
                        cmd.Parameters.AddWithValue("@SegundoNombre", textBox8.Text);
                        cmd.Parameters.AddWithValue("@PrimerApellido", textBox9.Text);
                        cmd.Parameters.AddWithValue("@SegundoApellido", textBox10.Text);
                        cmd.Parameters.AddWithValue("@Celular", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Direccion", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Observaciones", textBox5.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Construir un mensaje con los datos registrados
                            string mensaje = "Registro exitoso.\n\n";
                            mensaje += "Primer Nombre: " + textBox7.Text + "\n";
                            mensaje += "Segundo Nombre: " + textBox8.Text + "\n";
                            mensaje += "Primer Apellido: " + textBox9.Text + "\n";
                            mensaje += "Segundo Apellido: " + textBox10.Text + "\n";
                            mensaje += "Celular: " + textBox1.Text + "\n";
                            mensaje += "Dirección: " + textBox2.Text + "\n";
                            mensaje += "Email: " + textBox3.Text + "\n";
                            mensaje += "Fecha de Nacimiento: " + textBox4.Text + "\n";
                            mensaje += "Observaciones: " + textBox5.Text + "\n";

                            MessageBox.Show(mensaje, "Datos Registrados");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar el registro.");
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
}