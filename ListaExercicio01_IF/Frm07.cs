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
    public partial class Frm07 : Form
    {
        public Frm07()
        {
            InitializeComponent();
        }

        private void btnTestarF_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPesoM.Text);
            double altura = double.Parse(txtAlturaM.Text);
            double resultadoM;

            resultadoM = (peso * altura) - 58;

            MessageBox.Show("Seu peso ideal é " + resultadoM);


        }

        private void btnCalcularF_Click(object sender, EventArgs e)
        {

            double peso = double.Parse(txtPesoF.Text);
            double altura = double.Parse(txtAlturaF.Text);
            double resultadoF;

            resultadoF = (peso * altura) - 44.7;

            MessageBox.Show("Seu peso ideal é " + resultadoF);
        }
    }
}
