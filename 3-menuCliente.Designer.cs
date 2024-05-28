namespace fitnessfusion
{
    partial class frmMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCliente));
            this.lblMenuCliente = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cbmCliente = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pctPesquisa = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCliente
            // 
            this.lblMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenuCliente.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCliente.Location = new System.Drawing.Point(317, 2);
            this.lblMenuCliente.Name = "lblMenuCliente";
            this.lblMenuCliente.Size = new System.Drawing.Size(590, 30);
            this.lblMenuCliente.TabIndex = 0;
            this.lblMenuCliente.Text = "MENU CLIENTE";
            this.lblMenuCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(584, 26);
            this.txtPesquisa.TabIndex = 2;
            // 
            // cbmCliente
            // 
            this.cbmCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmCliente.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmCliente.FormattingEnabled = true;
            this.cbmCliente.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cbmCliente.Location = new System.Drawing.Point(4, 5);
            this.cbmCliente.Name = "cbmCliente";
            this.cbmCliente.Size = new System.Drawing.Size(170, 31);
            this.cbmCliente.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Location = new System.Drawing.Point(54, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 35);
            this.panel2.TabIndex = 4;
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(5, 3);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(1161, 449);
            this.dgvCliente.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.dgvCliente);
            this.panel4.Location = new System.Drawing.Point(15, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1170, 455);
            this.panel4.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(15, 551);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(170, 37);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1015, 551);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(170, 37);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.cbmCliente);
            this.panel3.Location = new System.Drawing.Point(995, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 40);
            this.panel3.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnSair.BackgroundImage = global::fitnessfusion.Properties.Resources.voltar;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1160, 1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 13;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(527, 551);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(170, 37);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pctPesquisa
            // 
            this.pctPesquisa.Image = global::fitnessfusion.Properties.Resources.lupa_pesquisa;
            this.pctPesquisa.Location = new System.Drawing.Point(12, 52);
            this.pctPesquisa.Name = "pctPesquisa";
            this.pctPesquisa.Size = new System.Drawing.Size(39, 35);
            this.pctPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPesquisa.TabIndex = 11;
            this.pctPesquisa.TabStop = false;
            // 
            // frmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.lblMenuCliente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pctPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmMenuCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuCliente;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cbmCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pctPesquisa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
    }
}