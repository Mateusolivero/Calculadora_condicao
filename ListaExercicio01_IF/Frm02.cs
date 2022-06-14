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
    public partial class Frm02 : Form
    {
        public Frm02()
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
            int Nasc = int.Parse(txtNasc.Text);
            int idade = 2022 - Nasc;

            if (idade >= 16)
            {
                MessageBox.Show("Com " + idade + " anos, você pode votar.");
            }
            else
            {
                MessageBox.Show("Com " + idade + " anos, você não pode votar.");
            }
        }
    }
}
