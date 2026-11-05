using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_recu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textusuario.Text == "admin" && textcontra.Text == "123")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
