using System;
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
    public partial class Form2 : Form
    {// se oculto y se agrego para el movimiento con el mouse
        private bool isDragging = false;
        private Point lastCursorPosition;

        public Form2()
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
        //INICIAL FORM3
        // En Form2

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir Form3
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Opcionalmente, puedes ocultar Form2 si deseas cerrarlo al abrir Form3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Abrir Form4
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide(); // Opcionalmente, puedes ocultar Form2 si deseas cerrarlo al abrir Form4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir Form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide(); // Opcionalmente, puedes ocultar Form2 si deseas cerrarlo al abrir Form5
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
