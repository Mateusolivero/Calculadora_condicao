namespace ListaExercicio01_IF
{
    partial class Frm01
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm01));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm01 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm02 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm03 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm04 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblQuestao = new System.Windows.Forms.Label();
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
            this.menuStrip1.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTestar
            // 
            this.btnTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(525, 169);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(130, 44);
            this.btnTestar.TabIndex = 11;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(282, 199);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 31);
            this.txtValor2.TabIndex = 10;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(282, 145);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 31);
            this.txtValor1.TabIndex = 9;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(134, 205);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(77, 25);
            this.lblValor2.TabIndex = 8;
            this.lblValor2.Text = "valor 2";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(134, 145);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(80, 25);
            this.lblValor1.TabIndex = 7;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.Location = new System.Drawing.Point(277, 56);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(111, 25);
            this.lblQuestao.TabIndex = 12;
            this.lblQuestao.Text = "Questão 1";
            // 
            // Frm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm01";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm01_Load);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblQuestao;
    }
}

