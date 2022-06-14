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
    public partial class Frm01 : Form
    {
        public Frm01()
        {
            InitializeComponent();
        }

        private void exibirFrm01_Click(object sender, EventArgs e)
        {
            Frm01 frm01 = new Frm01();
            this.Hide();
            frm01.ShowDialog();

        }

        private void exibirFrm02_Click(object sender, EventArgs e)
        {
            Frm02 frm02 = new Frm02();
            this.Hide();
            frm02.ShowDialog();

        }

        private void exibirFrm03_Click(object sender, EventArgs e)
        {
            Frm03 frm03 = new Frm03();
            this.Hide();
            frm03.ShowDialog();
        }

        private void exibirFrm04_Click(object sender, EventArgs e)
        {
            Frm04 frm04 = new Frm04();
            this.Hide();
            frm04.ShowDialog();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);

            if (valor1 > valor2)
            {
                MessageBox.Show("O valor 1 é maior que o valor 2");
            }
            else
            {
                MessageBox.Show("O valor 2 é maior que o valor 1");
            }
            
        }

        private void Frm01_Load(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
