namespace Internet.FORMS
{
    partial class frmClientes
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(23, 479);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(178, 44);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(282, 479);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(178, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(541, 479);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(178, 44);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(800, 479);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(178, 44);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(61, 128);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(26, 180);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(41, 232);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 24);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(3, 284);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(31, 336);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(62, 24);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(402, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(178, 57);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "Clientes";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(90, 125);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 29);
            this.txtID.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(90, 177);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 29);
            this.txtNome.TabIndex = 11;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(90, 229);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(199, 29);
            this.txtCPF.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(90, 281);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(199, 29);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(90, 333);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(62, 29);
            this.txtIdade.TabIndex = 14;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cpf,
            this.telefone,
            this.idade});
            this.dtgClientes.Location = new System.Drawing.Point(471, 90);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(526, 354);
            this.dtgClientes.TabIndex = 15;
            this.dtgClientes.DoubleClick += new System.EventHandler(this.dtgClientes_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.Width = 170;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "TELEFONE";
            this.telefone.Name = "telefone";
            // 
            // idade
            // 
            this.idade.DataPropertyName = "idade";
            this.idade.HeaderText = "IDADE";
            this.idade.Name = "idade";
            this.idade.Width = 50;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1016, 535);
            this.ControlBox = false;
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
    }
}