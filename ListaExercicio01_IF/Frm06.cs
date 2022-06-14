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
    public partial class Frm06 : Form
    {
        public Frm06()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            int opcao = int.Parse(txtNum.Text);
            switch (opcao)
            {
                case 3: MessageBox.Show("Triangulo"); 

                   break;

                case 4: MessageBox.Show("Quadrado");
                    break;

                default: MessageBox.Show("Opcao invalida");
                    break;

            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestao_Click(object sender, EventArgs e)
        {

        }
    }
}
