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
    public partial class Frm09 : Form
    {
        public Frm09()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
           

         
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            float Numero = float.Parse(txtNum.Text);

            if (Numero > 0)
            {
                MessageBox.Show("O numero é positivo");
            }

            else if(Numero == 0)
            {
                MessageBox.Show("O é neutro ou positivo");
            }
            else
            {
                MessageBox.Show("O é negativo");
            }
        }
    }
}
