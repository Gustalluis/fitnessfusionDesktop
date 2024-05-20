namespace fitnessfusion
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblCadastroTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbStatusCad = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltele = new System.Windows.Forms.Panel();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.pnlCad = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbagenda = new System.Windows.Forms.MaskedTextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.pnlNome.SuspendLayout();
            this.pnltele.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroTitulo
            // 
            this.lblCadastroTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblCadastroTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroTitulo.Location = new System.Drawing.Point(362, 9);
            this.lblCadastroTitulo.Name = "lblCadastroTitulo";
            this.lblCadastroTitulo.Size = new System.Drawing.Size(500, 38);
            this.lblCadastroTitulo.TabIndex = 0;
            this.lblCadastroTitulo.Text = "CADASTRO CLIENTE";
            this.lblCadastroTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnSair.BackgroundImage = global::fitnessfusion.Properties.Resources.voltar;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1142, 1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 14;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.cmbStatusCad);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(538, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 33);
            this.panel4.TabIndex = 10;
            // 
            // cmbStatusCad
            // 
            this.cmbStatusCad.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusCad.FormattingEnabled = true;
            this.cmbStatusCad.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVO"});
            this.cmbStatusCad.Location = new System.Drawing.Point(2, 3);
            this.cmbStatusCad.Name = "cmbStatusCad";
            this.cmbStatusCad.Size = new System.Drawing.Size(232, 27);
            this.cmbStatusCad.TabIndex = 0;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(471, 189);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(86, 25);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "SENHA:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Location = new System.Drawing.Point(25, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 30);
            this.panel3.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.txtSenha);
            this.panel5.Location = new System.Drawing.Point(474, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 30);
            this.panel5.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(292, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(22, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 25);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.pctFoto);
            this.panel6.Location = new System.Drawing.Point(815, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 255);
            this.panel6.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BackgroundImage = global::fitnessfusion.Properties.Resources.adicionar_botao_2;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(168, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 49);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pctFoto
            // 
            this.pctFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pctFoto.Location = new System.Drawing.Point(6, 8);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(214, 240);
            this.pctFoto.TabIndex = 11;
            this.pctFoto.TabStop = false;
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnlNome.Controls.Add(this.txtNome);
            this.pnlNome.Location = new System.Drawing.Point(23, 68);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(750, 30);
            this.pnlNome.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(2, 1);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(744, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(535, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "STATUS";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(22, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "TELEFONE:";
            // 
            // pnltele
            // 
            this.pnltele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnltele.Controls.Add(this.mtbTelefone);
            this.pnltele.Location = new System.Drawing.Point(23, 139);
            this.pnltele.Name = "pnltele";
            this.pnltele.Size = new System.Drawing.Size(322, 32);
            this.pnltele.TabIndex = 9;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTelefone.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(2, 4);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(317, 23);
            this.mtbTelefone.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(815, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 33);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "SIM";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "PCD";
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.checkBox2.Location = new System.Drawing.Point(967, 358);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 33);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "NÃO";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblPlano.Location = new System.Drawing.Point(535, 262);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(80, 25);
            this.lblPlano.TabIndex = 21;
            this.lblPlano.Text = "PLANO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cbmPlano);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(537, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 33);
            this.panel1.TabIndex = 11;
            // 
            // cbmPlano
            // 
            this.cbmPlano.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmPlano.FormattingEnabled = true;
            this.cbmPlano.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVO"});
            this.cbmPlano.Location = new System.Drawing.Point(2, 3);
            this.cbmPlano.Name = "cbmPlano";
            this.cbmPlano.Size = new System.Drawing.Size(232, 27);
            this.cbmPlano.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(256, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "PAGAMENTO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.cmbPagamento);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(259, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 33);
            this.panel2.TabIndex = 12;
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVO"});
            this.cmbPagamento.Location = new System.Drawing.Point(2, 3);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(232, 27);
            this.cmbPagamento.TabIndex = 0;
            // 
            // pnlCad
            // 
            this.pnlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.pnlCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCad.Controls.Add(this.mtbagenda);
            this.pnlCad.Controls.Add(this.checkBox3);
            this.pnlCad.Controls.Add(this.checkBox4);
            this.pnlCad.Controls.Add(this.lblFoto);
            this.pnlCad.Controls.Add(this.btnLimpar);
            this.pnlCad.Controls.Add(this.btnSalvar);
            this.pnlCad.Controls.Add(this.label5);
            this.pnlCad.Controls.Add(this.panel2);
            this.pnlCad.Controls.Add(this.label4);
            this.pnlCad.Controls.Add(this.panel1);
            this.pnlCad.Controls.Add(this.lblPlano);
            this.pnlCad.Controls.Add(this.checkBox2);
            this.pnlCad.Controls.Add(this.label2);
            this.pnlCad.Controls.Add(this.checkBox1);
            this.pnlCad.Controls.Add(this.pnltele);
            this.pnlCad.Controls.Add(this.label1);
            this.pnlCad.Controls.Add(this.lblNome);
            this.pnlCad.Controls.Add(this.lblStatus);
            this.pnlCad.Controls.Add(this.pnlNome);
            this.pnlCad.Controls.Add(this.panel6);
            this.pnlCad.Controls.Add(this.lblEmail);
            this.pnlCad.Controls.Add(this.panel5);
            this.pnlCad.Controls.Add(this.panel3);
            this.pnlCad.Controls.Add(this.lblSenha);
            this.pnlCad.Controls.Add(this.panel4);
            this.pnlCad.Location = new System.Drawing.Point(39, 50);
            this.pnlCad.Name = "pnlCad";
            this.pnlCad.Size = new System.Drawing.Size(1101, 483);
            this.pnlCad.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.checkBox3.Location = new System.Drawing.Point(98, 293);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 33);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "NÃO";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.checkBox4.Location = new System.Drawing.Point(23, 293);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 33);
            this.checkBox4.TabIndex = 28;
            this.checkBox4.Text = "SIM";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblFoto.Location = new System.Drawing.Point(900, 40);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(62, 25);
            this.lblFoto.TabIndex = 27;
            this.lblFoto.Text = "FOTO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(493, 393);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 37);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(154, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 37);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(827, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "AVALIAÇÃO FISICA";
            // 
            // mtbagenda
            // 
            this.mtbagenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbagenda.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbagenda.Location = new System.Drawing.Point(815, 397);
            this.mtbagenda.Mask = "00/00/0000 90:00";
            this.mtbagenda.Name = "mtbagenda";
            this.mtbagenda.Size = new System.Drawing.Size(228, 26);
            this.mtbagenda.TabIndex = 30;
            this.mtbagenda.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlCad);
            this.Controls.Add(this.lblCadastroTitulo);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.pnltele.ResumeLayout(false);
            this.pnltele.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCad.ResumeLayout(false);
            this.pnlCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbStatusCad;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltele;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbmPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Panel pnlCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.MaskedTextBox mtbagenda;
    }
}