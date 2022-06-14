using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicio01_IF
{
    public partial class Frm10 : Form
    {
        public Frm10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Altura = double.Parse(txtPeso.Text);
            double Peso = double.Parse(txtAltura.Text);
            double resultado = Peso / (Altura * Altura);

            if (resultado < 18)
            {
                MessageBox.Show("Abaixo do peso");
            }

             if else (resultado > 30)
            {
                MessageBox.Show("Acima do peso  ");
            }
            
        }
    }
}


