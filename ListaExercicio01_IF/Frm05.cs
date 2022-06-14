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
    public partial class Frm05 : Form
    {
        public Frm05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(txtValorLan.Text);
            double Pago = double.Parse(txtValorPago.Text);
            double resultado = Pago - Total;

            if (resultado == 0)
            {
                MessageBox.Show("Não tem troco");
                   
            }
            else
            {
                MessageBox.Show("O troco é de R$ " + resultado);
            }
        }
    }
}
