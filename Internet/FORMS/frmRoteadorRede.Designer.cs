namespace Internet.FORMS
{
    partial class frmRoteadorRede
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
            this.dtgRoteadorRede = new System.Windows.Forms.DataGridView();
            this.gpbFiltrar = new System.Windows.Forms.GroupBox();
            this.rdbIP = new System.Windows.Forms.RadioButton();
            this.cmbSelecao = new System.Windows.Forms.ComboBox();
            this.btnPesquisarImagem = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.txtRedeID = new System.Windows.Forms.TextBox();
            this.txtRoteadorID = new System.Windows.Forms.TextBox();
            this.lblOperacaoID = new System.Windows.Forms.Label();
            this.cmbRede = new System.Windows.Forms.ComboBox();
            this.cmbRoteador = new System.Windows.Forms.ComboBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtgRoteador = new System.Windows.Forms.DataGridView();
            this.id_roteador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRede = new System.Windows.Forms.DataGridView();
            this.id_rede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao_rede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRoteador = new System.Windows.Forms.Label();
            this.lblRede = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_RoteadorRede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roteador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roteadorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteadorRede)).BeginInit();
            this.gpbFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRoteadorRede
            // 
            this.dtgRoteadorRede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoteadorRede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_RoteadorRede,
            this.roteador,
            this.rede,
            this.roteadorID,
            this.redeID,
            this.dataInicio,
            this.dataFim});
            this.dtgRoteadorRede.Location = new System.Drawing.Point(266, 364);
            this.dtgRoteadorRede.Name = "dtgRoteadorRede";
            this.dtgRoteadorRede.Size = new System.Drawing.Size(341, 169);
            this.dtgRoteadorRede.TabIndex = 48;
            this.dtgRoteadorRede.DoubleClick += new System.EventHandler(this.dtgRoteadorRede_DoubleClick);
            // 
            // gpbFiltrar
            // 
            this.gpbFiltrar.Controls.Add(this.rdbIP);
            this.gpbFiltrar.Controls.Add(this.cmbSelecao);
            this.gpbFiltrar.Controls.Add(this.btnPesquisarImagem);
            this.gpbFiltrar.Controls.Add(this.txtPesquisar);
            this.gpbFiltrar.Controls.Add(this.rdbNome);
            this.gpbFiltrar.Controls.Add(this.rdbID);
            this.gpbFiltrar.Controls.Add(this.rdbTodos);
            this.gpbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltrar.Location = new System.Drawing.Point(799, 132);
            this.gpbFiltrar.Name = "gpbFiltrar";
            this.gpbFiltrar.Size = new System.Drawing.Size(205, 257);
            this.gpbFiltrar.TabIndex = 47;
            this.gpbFiltrar.TabStop = false;
            this.gpbFiltrar.Text = "Filtrar:";
            // 
            // rdbIP
            // 
            this.rdbIP.AutoSize = true;
            this.rdbIP.Location = new System.Drawing.Point(18, 143);
            this.rdbIP.Name = "rdbIP";
            this.rdbIP.Size = new System.Drawing.Size(44, 28);
            this.rdbIP.TabIndex = 6;
            this.rdbIP.TabStop = true;
            this.rdbIP.Text = "IP";
            this.rdbIP.UseVisualStyleBackColor = true;
            this.rdbIP.CheckedChanged += new System.EventHandler(this.rdbIP_CheckedChanged);
            // 
            // cmbSelecao
            // 
            this.cmbSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecao.FormattingEnabled = true;
            this.cmbSelecao.Items.AddRange(new object[] {
            "Geral",
            "Rede",
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
            this.btnPesquisarImagem.Location = new System.Drawing.Point(156, 210);
            this.btnPesquisarImagem.Name = "btnPesquisarImagem";
            this.btnPesquisarImagem.Size = new System.Drawing.Size(43, 41);
            this.btnPesquisarImagem.TabIndex = 4;
            this.btnPesquisarImagem.UseVisualStyleBackColor = true;
            this.btnPesquisarImagem.Click += new System.EventHandler(this.btnPesquisarImagem_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(5, 175);
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
            // txtRedeID
            // 
            this.txtRedeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedeID.Location = new System.Drawing.Point(395, 184);
            this.txtRedeID.Name = "txtRedeID";
            this.txtRedeID.Size = new System.Drawing.Size(100, 29);
            this.txtRedeID.TabIndex = 46;
            this.txtRedeID.Leave += new System.EventHandler(this.txtRedeID_Leave);
            // 
            // txtRoteadorID
            // 
            this.txtRoteadorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoteadorID.Location = new System.Drawing.Point(395, 232);
            this.txtRoteadorID.Name = "txtRoteadorID";
            this.txtRoteadorID.Size = new System.Drawing.Size(100, 29);
            this.txtRoteadorID.TabIndex = 45;
            this.txtRoteadorID.Leave += new System.EventHandler(this.txtRoteadorID_Leave);
            // 
            // lblOperacaoID
            // 
            this.lblOperacaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacaoID.Location = new System.Drawing.Point(123, 142);
            this.lblOperacaoID.Name = "lblOperacaoID";
            this.lblOperacaoID.Size = new System.Drawing.Size(100, 23);
            this.lblOperacaoID.TabIndex = 44;
            // 
            // cmbRede
            // 
            this.cmbRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRede.FormattingEnabled = true;
            this.cmbRede.Location = new System.Drawing.Point(123, 182);
            this.cmbRede.Name = "cmbRede";
            this.cmbRede.Size = new System.Drawing.Size(266, 32);
            this.cmbRede.TabIndex = 43;
            this.cmbRede.SelectedIndexChanged += new System.EventHandler(this.cmbRede_SelectedIndexChanged);
            this.cmbRede.Leave += new System.EventHandler(this.cmbRede_Leave);
            // 
            // cmbRoteador
            // 
            this.cmbRoteador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoteador.FormattingEnabled = true;
            this.cmbRoteador.Location = new System.Drawing.Point(123, 230);
            this.cmbRoteador.Name = "cmbRoteador";
            this.cmbRoteador.Size = new System.Drawing.Size(266, 32);
            this.cmbRoteador.TabIndex = 42;
            this.cmbRoteador.SelectedIndexChanged += new System.EventHandler(this.cmbRoteador_SelectedIndexChanged);
            this.cmbRoteador.Leave += new System.EventHandler(this.cmbRoteador_Leave);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(123, 323);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(134, 29);
            this.dtpDataFinal.TabIndex = 41;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(123, 278);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(134, 29);
            this.dtpData.TabIndex = 40;
            // 
            // dtgRoteador
            // 
            this.dtgRoteador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoteador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_roteador,
            this.nome,
            this.marca,
            this.usuario,
            this.senha,
            this.mac,
            this.situacao});
            this.dtgRoteador.Location = new System.Drawing.Point(501, 127);
            this.dtgRoteador.Name = "dtgRoteador";
            this.dtgRoteador.Size = new System.Drawing.Size(297, 231);
            this.dtgRoteador.TabIndex = 39;
            this.dtgRoteador.DoubleClick += new System.EventHandler(this.dtgRoteador_DoubleClick);
            // 
            // id_roteador
            // 
            this.id_roteador.DataPropertyName = "id";
            this.id_roteador.HeaderText = "ID";
            this.id_roteador.Name = "id_roteador";
            this.id_roteador.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "ROTEADOR";
            this.nome.Name = "nome";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "SENHA";
            this.senha.Name = "senha";
            this.senha.Visible = false;
            // 
            // mac
            // 
            this.mac.DataPropertyName = "mac";
            this.mac.HeaderText = "MAC";
            this.mac.Name = "mac";
            this.mac.Visible = false;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "SITUACAO";
            this.situacao.Name = "situacao";
            this.situacao.Visible = false;
            // 
            // dtgRede
            // 
            this.dtgRede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rede,
            this.ip,
            this.gateway,
            this.mascara,
            this.valor,
            this.situacao_rede});
            this.dtgRede.Location = new System.Drawing.Point(9, 358);
            this.dtgRede.Name = "dtgRede";
            this.dtgRede.Size = new System.Drawing.Size(247, 175);
            this.dtgRede.TabIndex = 38;
            this.dtgRede.DoubleClick += new System.EventHandler(this.dtgRede_DoubleClick);
            // 
            // id_rede
            // 
            this.id_rede.DataPropertyName = "id";
            this.id_rede.HeaderText = "ID";
            this.id_rede.Name = "id_rede";
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
            this.gateway.Visible = false;
            // 
            // mascara
            // 
            this.mascara.DataPropertyName = "mascara";
            this.mascara.HeaderText = "MASCARA";
            this.mascara.Name = "mascara";
            this.mascara.Visible = false;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Visible = false;
            // 
            // situacao_rede
            // 
            this.situacao_rede.DataPropertyName = "situacao";
            this.situacao_rede.HeaderText = "SITUACAO";
            this.situacao_rede.Name = "situacao_rede";
            this.situacao_rede.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(741, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(741, 495);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 36);
            this.btnSair.TabIndex = 36;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(613, 444);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(112, 36);
            this.btnDevolver.TabIndex = 35;
            this.btnDevolver.Text = "&Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(741, 393);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 36);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(869, 444);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 36);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(869, 393);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(112, 36);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(613, 393);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 36);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(22, 322);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(98, 24);
            this.lblDataFinal.TabIndex = 30;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(68, 277);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 24);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data:";
            // 
            // lblRoteador
            // 
            this.lblRoteador.AutoSize = true;
            this.lblRoteador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoteador.Location = new System.Drawing.Point(28, 232);
            this.lblRoteador.Name = "lblRoteador";
            this.lblRoteador.Size = new System.Drawing.Size(92, 24);
            this.lblRoteador.TabIndex = 28;
            this.lblRoteador.Text = "Roteador:";
            // 
            // lblRede
            // 
            this.lblRede.AutoSize = true;
            this.lblRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRede.Location = new System.Drawing.Point(47, 187);
            this.lblRede.Name = "lblRede";
            this.lblRede.Size = new System.Drawing.Size(61, 24);
            this.lblRede.TabIndex = 27;
            this.lblRede.Text = "Rede:";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(21, 142);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(99, 24);
            this.lblOp.TabIndex = 26;
            this.lblOp.Text = "Operação:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Internet.Properties.Resources.cabeçalhoLink;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 135);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // id_RoteadorRede
            // 
            this.id_RoteadorRede.DataPropertyName = "id";
            this.id_RoteadorRede.HeaderText = "ID";
            this.id_RoteadorRede.Name = "id_RoteadorRede";
            this.id_RoteadorRede.Visible = false;
            this.id_RoteadorRede.Width = 60;
            // 
            // roteador
            // 
            this.roteador.DataPropertyName = "roteador";
            this.roteador.HeaderText = "roteador";
            this.roteador.Name = "roteador";
            this.roteador.Width = 95;
            // 
            // rede
            // 
            this.rede.DataPropertyName = "rede";
            this.rede.HeaderText = "rede";
            this.rede.Name = "rede";
            // 
            // roteadorID
            // 
            this.roteadorID.DataPropertyName = "roteadorID";
            this.roteadorID.HeaderText = "roteadorID";
            this.roteadorID.Name = "roteadorID";
            this.roteadorID.Visible = false;
            this.roteadorID.Width = 95;
            // 
            // redeID
            // 
            this.redeID.DataPropertyName = "redeID";
            this.redeID.HeaderText = "redeID";
            this.redeID.Name = "redeID";
            this.redeID.Visible = false;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "dataInicio";
            this.dataInicio.HeaderText = "dataInicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Visible = false;
            // 
            // dataFim
            // 
            this.dataFim.DataPropertyName = "dataFim";
            this.dataFim.HeaderText = "dataFim";
            this.dataFim.Name = "dataFim";
            // 
            // frmRoteadorRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.Controls.Add(this.dtgRoteadorRede);
            this.Controls.Add(this.gpbFiltrar);
            this.Controls.Add(this.txtRedeID);
            this.Controls.Add(this.txtRoteadorID);
            this.Controls.Add(this.lblOperacaoID);
            this.Controls.Add(this.cmbRede);
            this.Controls.Add(this.cmbRoteador);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dtgRoteador);
            this.Controls.Add(this.dtgRede);
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
            this.Controls.Add(this.lblRede);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRoteadorRede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoteadorRede";
            this.Load += new System.EventHandler(this.frmRoteadorRede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteadorRede)).EndInit();
            this.gpbFiltrar.ResumeLayout(false);
            this.gpbFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoteador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRoteadorRede;
        private System.Windows.Forms.GroupBox gpbFiltrar;
        private System.Windows.Forms.ComboBox cmbSelecao;
        private System.Windows.Forms.Button btnPesquisarImagem;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.TextBox txtRedeID;
        private System.Windows.Forms.TextBox txtRoteadorID;
        private System.Windows.Forms.Label lblOperacaoID;
        private System.Windows.Forms.ComboBox cmbRede;
        private System.Windows.Forms.ComboBox cmbRoteador;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView dtgRoteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_roteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridView dtgRede;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblRoteador;
        private System.Windows.Forms.Label lblRede;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rede;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao_rede;
        private System.Windows.Forms.RadioButton rdbIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_RoteadorRede;
        private System.Windows.Forms.DataGridViewTextBoxColumn roteador;
        private System.Windows.Forms.DataGridViewTextBoxColumn rede;
        private System.Windows.Forms.DataGridViewTextBoxColumn roteadorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn redeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFim;
    }
}