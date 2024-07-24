namespace fitnessfusion
{
    partial class _3
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
            this.pnlCad = new System.Windows.Forms.Panel();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbCartao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbnome = new System.Windows.Forms.ComboBox();
            this.pnlCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCad
            // 
            this.pnlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.pnlCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCad.Controls.Add(this.cmbnome);
            this.pnlCad.Controls.Add(this.cmbCartao);
            this.pnlCad.Controls.Add(this.label1);
            this.pnlCad.Controls.Add(this.cmbPlano);
            this.pnlCad.Controls.Add(this.cmbPagamento);
            this.pnlCad.Controls.Add(this.cmbStatus);
            this.pnlCad.Controls.Add(this.btnLimpar);
            this.pnlCad.Controls.Add(this.btnSalvar);
            this.pnlCad.Controls.Add(this.lblPagamento);
            this.pnlCad.Controls.Add(this.lblPlano);
            this.pnlCad.Controls.Add(this.lblNome);
            this.pnlCad.Controls.Add(this.lblStatus);
            this.pnlCad.Location = new System.Drawing.Point(54, 63);
            this.pnlCad.Name = "pnlCad";
            this.pnlCad.Size = new System.Drawing.Size(1101, 483);
            this.pnlCad.TabIndex = 19;
            // 
            // cmbPlano
            // 
            this.cmbPlano.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(665, 113);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(249, 31);
            this.cmbPlano.TabIndex = 0;
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "PAGO",
            "PENDENTE"});
            this.cmbPagamento.Location = new System.Drawing.Point(190, 189);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(233, 31);
            this.cmbPagamento.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(191, 112);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(232, 31);
            this.cmbStatus.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(599, 411);
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
            this.btnSalvar.Location = new System.Drawing.Point(258, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 37);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblPagamento.Location = new System.Drawing.Point(187, 161);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(133, 25);
            this.lblPagamento.TabIndex = 22;
            this.lblPagamento.Text = "PAGAMENTO";
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblPlano.Location = new System.Drawing.Point(664, 85);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(80, 25);
            this.lblPlano.TabIndex = 21;
            this.lblPlano.Text = "PLANO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(187, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(186, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "STATUS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(337, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 38);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "CADASTRO PAGAMENTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnSair.BackgroundImage = global::fitnessfusion.Properties.Resources.voltar;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1160, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 18;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // cmbCartao
            // 
            this.cmbCartao.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartao.FormattingEnabled = true;
            this.cmbCartao.Items.AddRange(new object[] {
            "DINHEIRO",
            "PIX",
            "BOLETO",
            "CARTAO DE CREDITO",
            "CARTAO DE DEBITO"});
            this.cmbCartao.Location = new System.Drawing.Point(663, 189);
            this.cmbCartao.Name = "cmbCartao";
            this.cmbCartao.Size = new System.Drawing.Size(251, 31);
            this.cmbCartao.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(660, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "METODO DO PAGAMENTO";
            // 
            // cmbnome
            // 
            this.cmbnome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnome.FormattingEnabled = true;
            this.cmbnome.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbnome.Location = new System.Drawing.Point(192, 42);
            this.cmbnome.Name = "cmbnome";
            this.cmbnome.Size = new System.Drawing.Size(722, 31);
            this.cmbnome.TabIndex = 29;
            // 
            // _3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlCad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_3";
            this.Text = "_3";
            this.Load += new System.EventHandler(this._3_Load);
            this.pnlCad.ResumeLayout(false);
            this.pnlCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCad;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbnome;
    }
}