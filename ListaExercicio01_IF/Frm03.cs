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
    public partial class Frm03 : Form
    {
        public Frm03()
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

        private void lblEnter_Click(object sender, EventArgs e) // btn e não lbl
        {
            string User = txtUser.Text;
            int Senha = int.Parse(txtSenha.Text);




            if (Senha == 1234)
            {
                MessageBox.Show("Acesso permitido");

            }
            else if (User == "admin")
            {
                MessageBox.Show("Acesso permitido");
            }
            else
            {
                MessageBox.Show("Acesso negado");
            }



        }
    }
}
