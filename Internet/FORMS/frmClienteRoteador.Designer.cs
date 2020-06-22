namespace Internet.FORMS
{
    partial class frmClienteRoteador
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
            this.lblOp = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRoteador = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRoteador = new System.Windows.Forms.DataGridView();
            this.id_roteador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.cmbRoteador = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblOperacaoID = new System.Windows.Forms.Label();
            this.txtRoteadorID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.gpbFiltrar = new System.Windows.Forms.GroupBox();
            this.cmbSelecao = new System.Windows.Forms.ComboBox();
            this.btnPesquisarImagem = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgClienteRoteador = new System.Windows.Forms.DataGridView();
            this.id_ClienteRoteador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roteador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roteadorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteador)).BeginInit();
            this.gpbFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClienteRoteador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(19, 121);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(99, 24);
            this.lblOp.TabIndex = 1;
            this.lblOp.Text = "Operação:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(45, 166);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblRoteador
            // 
            this.lblRoteador.AutoSize = true;
            this.lblRoteador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoteador.Location = new System.Drawing.Point(26, 211);
            this.lblRoteador.Name = "lblRoteador";
            this.lblRoteador.Size = new System.Drawing.Size(92, 24);
            this.lblRoteador.TabIndex = 3;
            this.lblRoteador.Text = "Roteador:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(66, 256);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 24);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(20, 301);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(98, 24);
            this.lblDataFinal.TabIndex = 5;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(611, 374);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 36);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(867, 374);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(112, 36);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(867, 425);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 36);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(739, 374);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 36);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(611, 425);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(112, 36);
            this.btnDevolver.TabIndex = 10;
            this.btnDevolver.Text = "&Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(739, 476);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 36);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(739, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_Cliente,
            this.cpf,
            this.telefone,
            this.idade});
            this.dtgCliente.Location = new System.Drawing.Point(8, 349);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.Size = new System.Drawing.Size(247, 175);
            this.dtgCliente.TabIndex = 14;
            this.dtgCliente.DoubleClick += new System.EventHandler(this.dtgCliente_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nome_Cliente
            // 
            this.nome_Cliente.DataPropertyName = "nome";
            this.nome_Cliente.HeaderText = "NOME";
            this.nome_Cliente.Name = "nome_Cliente";
            this.nome_Cliente.ReadOnly = true;
            this.nome_Cliente.Width = 140;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "TELEFONE";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Visible = false;
            // 
            // idade
            // 
            this.idade.DataPropertyName = "idade";
            this.idade.HeaderText = "IDADE";
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            this.idade.Visible = false;
            // 
            // dtgRoteador
            // 
            this.dtgRoteador.AllowUserToAddRows = false;
            this.dtgRoteador.AllowUserToDeleteRows = false;
            this.dtgRoteador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoteador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_roteador,
            this.nome,
            this.marca,
            this.usuario,
            this.senha,
            this.mac,
            this.situacao});
            this.dtgRoteador.Location = new System.Drawing.Point(499, 107);
            this.dtgRoteador.Name = "dtgRoteador";
            this.dtgRoteador.ReadOnly = true;
            this.dtgRoteador.Size = new System.Drawing.Size(297, 231);
            this.dtgRoteador.TabIndex = 15;
            this.dtgRoteador.DoubleClick += new System.EventHandler(this.dtgRoteador_DoubleClick);
            // 
            // id_roteador
            // 
            this.id_roteador.DataPropertyName = "id";
            this.id_roteador.HeaderText = "ID";
            this.id_roteador.Name = "id_roteador";
            this.id_roteador.ReadOnly = true;
            this.id_roteador.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "ROTEADOR";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "SENHA";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // mac
            // 
            this.mac.DataPropertyName = "mac";
            this.mac.HeaderText = "MAC";
            this.mac.Name = "mac";
            this.mac.ReadOnly = true;
            this.mac.Visible = false;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "SITUACAO";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Visible = false;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(121, 257);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(134, 29);
            this.dtpData.TabIndex = 16;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(121, 302);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(134, 29);
            this.dtpDataFinal.TabIndex = 17;
            // 
            // cmbRoteador
            // 
            this.cmbRoteador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoteador.FormattingEnabled = true;
            this.cmbRoteador.Location = new System.Drawing.Point(121, 209);
            this.cmbRoteador.Name = "cmbRoteador";
            this.cmbRoteador.Size = new System.Drawing.Size(266, 32);
            this.cmbRoteador.TabIndex = 18;
            this.cmbRoteador.SelectedIndexChanged += new System.EventHandler(this.cmbRoteador_SelectedIndexChanged);
            this.cmbRoteador.Leave += new System.EventHandler(this.cmbRoteador_Leave);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 161);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(266, 32);
            this.cmbCliente.TabIndex = 19;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // lblOperacaoID
            // 
            this.lblOperacaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacaoID.Location = new System.Drawing.Point(121, 121);
            this.lblOperacaoID.Name = "lblOperacaoID";
            this.lblOperacaoID.Size = new System.Drawing.Size(100, 23);
            this.lblOperacaoID.TabIndex = 20;
            // 
            // txtRoteadorID
            // 
            this.txtRoteadorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoteadorID.Location = new System.Drawing.Point(393, 211);
            this.txtRoteadorID.Name = "txtRoteadorID";
            this.txtRoteadorID.Size = new System.Drawing.Size(100, 29);
            this.txtRoteadorID.TabIndex = 21;
            this.txtRoteadorID.Leave += new System.EventHandler(this.txtRoteadorID_Leave);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(393, 163);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 29);
            this.txtClienteID.TabIndex = 22;
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);
            // 
            // gpbFiltrar
            // 
            this.gpbFiltrar.Controls.Add(this.cmbSelecao);
            this.gpbFiltrar.Controls.Add(this.btnPesquisarImagem);
            this.gpbFiltrar.Controls.Add(this.txtPesquisar);
            this.gpbFiltrar.Controls.Add(this.rdbNome);
            this.gpbFiltrar.Controls.Add(this.rdbID);
            this.gpbFiltrar.Controls.Add(this.rdbTodos);
            this.gpbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltrar.Location = new System.Drawing.Point(797, 111);
            this.gpbFiltrar.Name = "gpbFiltrar";
            this.gpbFiltrar.Size = new System.Drawing.Size(205, 231);
            this.gpbFiltrar.TabIndex = 23;
            this.gpbFiltrar.TabStop = false;
            this.gpbFiltrar.Text = "Filtrar:";
            // 
            // cmbSelecao
            // 
            this.cmbSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecao.FormattingEnabled = true;
            this.cmbSelecao.Items.AddRange(new object[] {
            "Geral",
            "Clientes",
            "Roteador"});
            this.cmbSelecao.Location = new System.Drawing.Point(5, 26);
            this.cmbSelecao.Name = "cmbSelecao";
            this.cmbSelecao.Size = new System.Drawing.Size(194, 32);
            this.cmbSelecao.TabIndex = 5;
            this.cmbSelecao.SelectedIndexChanged += new System.EventHandler(this.cmbSelecao_SelectedIndexChanged);
            // 
            // btnPesquisarImagem
            // 
            this.btnPesquisarImagem.Image = global::Internet.Properties.Resources.search;
            this.btnPesquisarImagem.Location = new System.Drawing.Point(153, 181);
            this.btnPesquisarImagem.Name = "btnPesquisarImagem";
            this.btnPesquisarImagem.Size = new System.Drawing.Size(43, 41);
            this.btnPesquisarImagem.TabIndex = 4;
            this.btnPesquisarImagem.UseVisualStyleBackColor = true;
            this.btnPesquisarImagem.Click += new System.EventHandler(this.btnPesquisarImagem_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(5, 145);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(194, 29);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(18, 114);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(80, 28);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(18, 90);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(45, 28);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(18, 64);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(82, 28);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Internet.Properties.Resources.cabeçalhoLink;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtgClienteRoteador
            // 
            this.dtgClienteRoteador.AllowUserToAddRows = false;
            this.dtgClienteRoteador.AllowUserToDeleteRows = false;
            this.dtgClienteRoteador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClienteRoteador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ClienteRoteador,
            this.clienteID,
            this.cliente,
            this.roteador,
            this.roteadorID,
            this.dataInicio,
            this.dataFim});
            this.dtgClienteRoteador.Location = new System.Drawing.Point(261, 348);
            this.dtgClienteRoteador.Name = "dtgClienteRoteador";
            this.dtgClienteRoteador.ReadOnly = true;
            this.dtgClienteRoteador.Size = new System.Drawing.Size(341, 176);
            this.dtgClienteRoteador.TabIndex = 24;
            this.dtgClienteRoteador.DoubleClick += new System.EventHandler(this.dtgClienteRoteador_DoubleClick);
            // 
            // id_ClienteRoteador
            // 
            this.id_ClienteRoteador.DataPropertyName = "id";
            this.id_ClienteRoteador.HeaderText = "ID";
            this.id_ClienteRoteador.Name = "id_ClienteRoteador";
            this.id_ClienteRoteador.ReadOnly = true;
            this.id_ClienteRoteador.Visible = false;
            this.id_ClienteRoteador.Width = 60;
            // 
            // clienteID
            // 
            this.clienteID.DataPropertyName = "clienteID";
            this.clienteID.HeaderText = "clienteID";
            this.clienteID.Name = "clienteID";
            this.clienteID.ReadOnly = true;
            this.clienteID.Visible = false;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // roteador
            // 
            this.roteador.DataPropertyName = "roteador";
            this.roteador.HeaderText = "roteador";
            this.roteador.Name = "roteador";
            this.roteador.ReadOnly = true;
            this.roteador.Width = 95;
            // 
            // roteadorID
            // 
            this.roteadorID.DataPropertyName = "roteadorID";
            this.roteadorID.HeaderText = "roteadorID";
            this.roteadorID.Name = "roteadorID";
            this.roteadorID.ReadOnly = true;
            this.roteadorID.Visible = false;
            this.roteadorID.Width = 95;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "dataInicio";
            this.dataInicio.HeaderText = "dataInicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.Visible = false;
            // 
            // dataFim
            // 
            this.dataFim.DataPropertyName = "dataFim";
            this.dataFim.HeaderText = "dataFim";
            this.dataFim.Name = "dataFim";
            this.dataFim.ReadOnly = true;
            // 
            // frmClienteRoteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.Controls.Add(this.dtgClienteRoteador);
            this.Controls.Add(this.gpbFiltrar);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtRoteadorID);
            this.Controls.Add(this.lblOperacaoID);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbRoteador);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dtgRoteador);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblRoteador);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmClienteRoteador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteRoteador";
            this.Load += new System.EventHandler(this.frmClienteRoteador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteador)).EndInit();
            this.gpbFiltrar.ResumeLayout(false);
            this.gpbFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClienteRoteador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRoteador;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.DataGridView dtgRoteador;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.ComboBox cmbRoteador;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblOperacaoID;
        private System.Windows.Forms.TextBox txtRoteadorID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.GroupBox gpbFiltrar;
        private System.Windows.Forms.ComboBox cmbSelecao;
        private System.Windows.Forms.Button btnPesquisarImagem;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_roteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridView dtgClienteRoteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ClienteRoteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn roteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn roteadorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFim;
    }
}