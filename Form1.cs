﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajofinal
{
    public partial class Form1 : Form
    {// se oculto y se agrego para el movimiento con el mouse
        private bool isDragging = false;
        private Point lastCursorPosition;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Oculta la barra de título
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        //aqui termina el oculto
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            // Lógica a ser executada quando o texto do textBox1 é alterado.
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Lógica a ser executada quando o texto do textBox1 é alterado.
        }

        //Aquí se agregaran usuarios
        private Dictionary<string, string> usuarios = new Dictionary<string, string>()
{
    { "admin", "admin" },
    { "admin1", "admin1" },
    // Agrega más usuarios aquí si es necesario
};

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Verificar si el usuario y la contraseña existen en el diccionario
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                // Si es correcto, abrir Form2 y cerrar este formulario
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // seagreo un check box ver y ocultar contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Verificar si el CheckBox está marcado o desmarcado
            if (checkBox1.Checked)
            {
                // Si está marcado, mostrar la contraseña
                textBox2.PasswordChar = '\0'; // Mostrar caracteres normales (sin ocultar)
            }
            else
            {
                // Si está desmarcado, ocultar la contraseña
                textBox2.PasswordChar = '*'; // Ocultar caracteres con un asterisco (puedes usar otro carácter si lo prefieres)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BOTON SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra completamente el formulario Form1
            this.Close();
        }
    }
}