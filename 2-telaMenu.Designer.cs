namespace fitnessfusion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTreino = new System.Windows.Forms.Button();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAvalicao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnPlano = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.dgvMenu);
            this.panel2.Location = new System.Drawing.Point(559, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 416);
            this.panel2.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(3, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(280, 23);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(125, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 32);
            this.panel1.TabIndex = 25;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblData.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(795, 95);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 32);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "00/00/0000";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblHora.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(795, 134);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(141, 32);
            this.lblHora.TabIndex = 29;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTreino
            // 
            this.btnTreino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnTreino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTreino.FlatAppearance.BorderSize = 0;
            this.btnTreino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreino.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnTreino.Image = global::fitnessfusion.Properties.Resources.treino;
            this.btnTreino.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTreino.Location = new System.Drawing.Point(280, 381);
            this.btnTreino.Name = "btnTreino";
            this.btnTreino.Size = new System.Drawing.Size(255, 200);
            this.btnTreino.TabIndex = 27;
            this.btnTreino.Text = "TREINO";
            this.btnTreino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTreino.UseVisualStyleBackColor = false;
            this.btnTreino.Click += new System.EventHandler(this.btnTreino_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnEquipamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEquipamento.FlatAppearance.BorderSize = 0;
            this.btnEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamento.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnEquipamento.Image = global::fitnessfusion.Properties.Resources.fluxoDeCaixa;
            this.btnEquipamento.Location = new System.Drawing.Point(280, 175);
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Size = new System.Drawing.Size(255, 200);
            this.btnEquipamento.TabIndex = 26;
            this.btnEquipamento.Text = "CAIXA";
            this.btnEquipamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquipamento.UseVisualStyleBackColor = false;
            this.btnEquipamento.Click += new System.EventHandler(this.btnEquipamento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::fitnessfusion.Properties.Resources.logoFitnessMenulogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 100);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnAvalicao
            // 
            this.btnAvalicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnAvalicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvalicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAvalicao.FlatAppearance.BorderSize = 2;
            this.btnAvalicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvalicao.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvalicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAvalicao.Image = global::fitnessfusion.Properties.Resources.agenda;
            this.btnAvalicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvalicao.Location = new System.Drawing.Point(956, 84);
            this.btnAvalicao.Name = "btnAvalicao";
            this.btnAvalicao.Size = new System.Drawing.Size(219, 92);
            this.btnAvalicao.TabIndex = 13;
            this.btnAvalicao.Text = "AVALIAÇÃO\r\nFISICA";
            this.btnAvalicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvalicao.UseVisualStyleBackColor = false;
            this.btnAvalicao.Click += new System.EventHandler(this.btnAvalicao_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnSair.BackgroundImage = global::fitnessfusion.Properties.Resources.voltar;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(1160, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnFuncionarios.Image = global::fitnessfusion.Properties.Resources.funcionario;
            this.btnFuncionarios.Location = new System.Drawing.Point(20, 381);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(255, 200);
            this.btnFuncionarios.TabIndex = 6;
            this.btnFuncionarios.Text = "FUNCIONARIOS";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.BtnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.BtnCliente.Image = global::fitnessfusion.Properties.Resources.cliente;
            this.BtnCliente.Location = new System.Drawing.Point(20, 175);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(255, 200);
            this.BtnCliente.TabIndex = 3;
            this.BtnCliente.Text = "CLIENTE";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnPlano
            // 
            this.btnPlano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnPlano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlano.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnPlano.FlatAppearance.BorderSize = 2;
            this.btnPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlano.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnPlano.Image = global::fitnessfusion.Properties.Resources.modalidadeMenu;
            this.btnPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlano.Location = new System.Drawing.Point(559, 84);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(218, 92);
            this.btnPlano.TabIndex = 30;
            this.btnPlano.Text = "PLANOS E ASSINATURA";
            this.btnPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlano.UseVisualStyleBackColor = false;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.Location = new System.Drawing.Point(3, 3);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.Size = new System.Drawing.Size(610, 410);
            this.dgvMenu.TabIndex = 31;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnTreino);
            this.Controls.Add(this.btnEquipamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAvalicao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.BtnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAvalicao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.Button btnTreino;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.DataGridView dgvMenu;
    }
}