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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte nota1 = byte.Parse(textnota1.Text);// aqui estamos guardando una variable utilizando nuestro TextBox
            byte nota2 = byte.Parse(textnota2.Text);// aqui estamos guardando una variable utilizando nuestro TextBox
            byte nota3 = byte.Parse(textnota3.Text);// aqui estamos guardando una variable utilizando nuestro TextBox
            float promedio = ((nota1 + nota2 + nota3) / 3);// esta es la formula de nuestro promedio 
            MessageBox.Show("El resultado es " + promedio);// mostramos el resultado en pantalla 
        }

        private void textnota1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
