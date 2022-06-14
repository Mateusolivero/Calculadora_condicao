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
    public partial class Frm08 : Form
    {
        public Frm08()
        {
            InitializeComponent();
        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string Sexo = txtSexo.Text;
            switch (Sexo)
            {

                case "F":
                    MessageBox.Show("Sexo feminino");
                    break;

                case "f":
                    MessageBox.Show("Sexo feminino");
                    break;

                default:
                    MessageBox.Show("Sexo  inválido pois é um projeto de mulheres");
                    break;
            }
        }
    }
}
