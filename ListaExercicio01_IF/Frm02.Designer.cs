﻿namespace ListaExercicio01_IF
{
    partial class Frm02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm02));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm01 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm02 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm03 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm04 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrm01,
            this.exibirFrm02,
            this.exibirFrm03,
            this.exibirFrm04});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibirFrm01
            // 
            this.exibirFrm01.Image = ((System.Drawing.Image)(resources.GetObject("exibirFrm01.Image")));
            this.exibirFrm01.Name = "exibirFrm01";
            this.exibirFrm01.Size = new System.Drawing.Size(133, 22);
            this.exibirFrm01.Text = "Questão 01";
            this.exibirFrm01.Click += new System.EventHandler(this.exibirFrm01_Click);
            // 
            // exibirFrm02
            // 
            this.exibirFrm02.Image = ((System.Drawing.Image)(resources.GetObject("exibirFrm02.Image")));
            this.exibirFrm02.Name = "exibirFrm02";
            this.exibirFrm02.Size = new System.Drawing.Size(133, 22);
            this.exibirFrm02.Text = "Questão 02";
            this.exibirFrm02.Click += new System.EventHandler(this.exibirFrm02_Click);
            // 
            // exibirFrm03
            // 
            this.exibirFrm03.Image = ((System.Drawing.Image)(resources.GetObject("exibirFrm03.Image")));
            this.exibirFrm03.Name = "exibirFrm03";
            this.exibirFrm03.Size = new System.Drawing.Size(133, 22);
            this.exibirFrm03.Text = "Questão 03";
            this.exibirFrm03.Click += new System.EventHandler(this.exibirFrm03_Click);
            // 
            // exibirFrm04
            // 
            this.exibirFrm04.Image = ((System.Drawing.Image)(resources.GetObject("exibirFrm04.Image")));
            this.exibirFrm04.Name = "exibirFrm04";
            this.exibirFrm04.Size = new System.Drawing.Size(133, 22);
            this.exibirFrm04.Text = "Questão 04";
            this.exibirFrm04.Click += new System.EventHandler(this.exibirFrm04_Click);
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.Location = new System.Drawing.Point(296, 70);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(165, 37);
            this.lblQuestao.TabIndex = 8;
            this.lblQuestao.Text = "Questão 2";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(142, 157);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(169, 25);
            this.lblNasc.TabIndex = 9;
            this.lblNasc.Text = "Ano Nascimento";
            // 
            // txtNasc
            // 
            this.txtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.Location = new System.Drawing.Point(332, 154);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(129, 31);
            this.txtNasc.TabIndex = 10;
            // 
            // btnTestar
            // 
            this.btnTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(356, 232);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(86, 34);
            this.btnTestar.TabIndex = 11;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // Frm02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm02";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm01;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm02;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm03;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm04;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.Button btnTestar;
    }
}