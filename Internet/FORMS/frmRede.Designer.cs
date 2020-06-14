namespace Internet.FORMS
{
    partial class frmRede
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
            this.dtgRede = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtMascara = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblRede = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMascara = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRede)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRede
            // 
            this.dtgRede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ip,
            this.gateway,
            this.mascara,
            this.valor,
            this.situacao});
            this.dtgRede.Location = new System.Drawing.Point(471, 87);
            this.dtgRede.Name = "dtgRede";
            this.dtgRede.Size = new System.Drawing.Size(526, 354);
            this.dtgRede.TabIndex = 49;
            this.dtgRede.DoubleClick += new System.EventHandler(this.dtgRede_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            // 
            // gateway
            // 
            this.gateway.DataPropertyName = "gateway";
            this.gateway.HeaderText = "GATEWAY";
            this.gateway.Name = "gateway";
            this.gateway.Width = 110;
            // 
            // mascara
            // 
            this.mascara.DataPropertyName = "mascara";
            this.mascara.HeaderText = "MASCARA";
            this.mascara.Name = "mascara";
            this.mascara.Width = 120;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Width = 90;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "SITUACAO";
            this.situacao.Name = "situacao";
            this.situacao.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(111, 335);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 29);
            this.txtValor.TabIndex = 48;
            // 
            // txtMascara
            // 
            this.txtMascara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascara.Location = new System.Drawing.Point(111, 283);
            this.txtMascara.Name = "txtMascara";
            this.txtMascara.Size = new System.Drawing.Size(281, 29);
            this.txtMascara.TabIndex = 47;
            // 
            // txtGateway
            // 
            this.txtGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGateway.Location = new System.Drawing.Point(111, 231);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(281, 29);
            this.txtGateway.TabIndex = 46;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(111, 179);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(199, 29);
            this.txtIP.TabIndex = 45;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(111, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 29);
            this.txtID.TabIndex = 44;
            // 
            // lblRede
            // 
            this.lblRede.AutoSize = true;
            this.lblRede.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRede.ForeColor = System.Drawing.Color.White;
            this.lblRede.Location = new System.Drawing.Point(416, 11);
            this.lblRede.Name = "lblRede";
            this.lblRede.Size = new System.Drawing.Size(121, 57);
            this.lblRede.TabIndex = 43;
            this.lblRede.Text = "Rede";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(33, 338);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 24);
            this.lblValor.TabIndex = 42;
            this.lblValor.Text = "Valor:";
            // 
            // lblMascara
            // 
            this.lblMascara.AutoSize = true;
            this.lblMascara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascara.ForeColor = System.Drawing.Color.White;
            this.lblMascara.Location = new System.Drawing.Point(6, 286);
            this.lblMascara.Name = "lblMascara";
            this.lblMascara.Size = new System.Drawing.Size(86, 24);
            this.lblMascara.TabIndex = 41;
            this.lblMascara.Text = "Mascara:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.ForeColor = System.Drawing.Color.White;
            this.lblGateway.Location = new System.Drawing.Point(5, 234);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(87, 24);
            this.lblGateway.TabIndex = 40;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(61, 182);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(31, 24);
            this.lblIP.TabIndex = 39;
            this.lblIP.Text = "IP:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(60, 130);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(814, 481);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(178, 44);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(555, 481);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(178, 44);
            this.btnRemover.TabIndex = 36;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(296, 481);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(178, 44);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(37, 481);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(178, 44);
            this.btnInserir.TabIndex = 34;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.ControlBox = false;
            this.Controls.Add(this.dtgRede);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtMascara);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblRede);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMascara);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRede";
            this.Load += new System.EventHandler(this.frmRede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRede;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtMascara;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblRede;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMascara;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}