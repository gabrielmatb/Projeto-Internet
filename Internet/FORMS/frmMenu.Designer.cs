namespace Internet.FORMS
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteRoteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roteadorRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteRoteadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roteadorRedeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.roteadorToolStripMenuItem,
            this.redeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // roteadorToolStripMenuItem
            // 
            this.roteadorToolStripMenuItem.Name = "roteadorToolStripMenuItem";
            this.roteadorToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.roteadorToolStripMenuItem.Text = "Roteador";
            this.roteadorToolStripMenuItem.Click += new System.EventHandler(this.roteadorToolStripMenuItem_Click);
            // 
            // redeToolStripMenuItem
            // 
            this.redeToolStripMenuItem.Name = "redeToolStripMenuItem";
            this.redeToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.redeToolStripMenuItem.Text = "Rede";
            this.redeToolStripMenuItem.Click += new System.EventHandler(this.redeToolStripMenuItem_Click);
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteRoteadorToolStripMenuItem,
            this.roteadorRedeToolStripMenuItem});
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.movimentosToolStripMenuItem.Text = "Movimentos";
            // 
            // clienteRoteadorToolStripMenuItem
            // 
            this.clienteRoteadorToolStripMenuItem.Name = "clienteRoteadorToolStripMenuItem";
            this.clienteRoteadorToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.clienteRoteadorToolStripMenuItem.Text = "Cliente/Roteador";
            this.clienteRoteadorToolStripMenuItem.Click += new System.EventHandler(this.clienteRoteadorToolStripMenuItem_Click);
            // 
            // roteadorRedeToolStripMenuItem
            // 
            this.roteadorRedeToolStripMenuItem.Name = "roteadorRedeToolStripMenuItem";
            this.roteadorRedeToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.roteadorRedeToolStripMenuItem.Text = "Roteador/Rede";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteRoteadorToolStripMenuItem1,
            this.roteadorRedeToolStripMenuItem1});
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // clienteRoteadorToolStripMenuItem1
            // 
            this.clienteRoteadorToolStripMenuItem1.Name = "clienteRoteadorToolStripMenuItem1";
            this.clienteRoteadorToolStripMenuItem1.Size = new System.Drawing.Size(270, 36);
            this.clienteRoteadorToolStripMenuItem1.Text = "Cliente/Roteador";
            this.clienteRoteadorToolStripMenuItem1.Click += new System.EventHandler(this.clienteRoteadorToolStripMenuItem1_Click);
            // 
            // roteadorRedeToolStripMenuItem1
            // 
            this.roteadorRedeToolStripMenuItem1.Name = "roteadorRedeToolStripMenuItem1";
            this.roteadorRedeToolStripMenuItem1.Size = new System.Drawing.Size(270, 36);
            this.roteadorRedeToolStripMenuItem1.Text = "Roteador/Rede";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteRoteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roteadorRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteRoteadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roteadorRedeToolStripMenuItem1;
    }
}