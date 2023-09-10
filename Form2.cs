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
    {
        public Form2()
        {
            InitializeComponent();
        }
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

    }
}
