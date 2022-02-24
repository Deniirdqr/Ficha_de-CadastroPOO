namespace Discurssiva
{
    partial class Form1
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.busca = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Ocupação = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbOcupacao = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.btpreencher = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(312, 157);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(99, 34);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(282, 84);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(116, 20);
            this.busca.TabIndex = 1;
            this.busca.Text = "Buscar";
            this.busca.UseVisualStyleBackColor = true;
            this.busca.Click += new System.EventHandler(this.busca_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(25, 55);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(25, 113);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(34, 13);
            this.Idade.TabIndex = 3;
            this.Idade.Text = "Idade";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(25, 141);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(31, 13);
            this.Sexo.TabIndex = 4;
            this.Sexo.Text = "Sexo";
            // 
            // Ocupação
            // 
            this.Ocupação.AutoSize = true;
            this.Ocupação.Location = new System.Drawing.Point(25, 170);
            this.Ocupação.Name = "Ocupação";
            this.Ocupação.Size = new System.Drawing.Size(57, 13);
            this.Ocupação.TabIndex = 5;
            this.Ocupação.Text = "Ocupação";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(104, 55);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(172, 20);
            this.textNome.TabIndex = 6;
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(104, 113);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(82, 20);
            this.textIdade.TabIndex = 7;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(104, 141);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(172, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // cmbOcupacao
            // 
            this.cmbOcupacao.FormattingEnabled = true;
            this.cmbOcupacao.Location = new System.Drawing.Point(104, 170);
            this.cmbOcupacao.Name = "cmbOcupacao";
            this.cmbOcupacao.Size = new System.Drawing.Size(172, 21);
            this.cmbOcupacao.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(25, 26);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 10;
            this.Id.Text = "Id";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(104, 26);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(82, 20);
            this.textId.TabIndex = 11;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(104, 84);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(172, 20);
            this.textCPF.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "cpf";
            // 
            // dataGridList
            // 
            this.dataGridList.AllowUserToAddRows = false;
            this.dataGridList.AllowUserToDeleteRows = false;
            this.dataGridList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Location = new System.Drawing.Point(28, 209);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.ReadOnly = true;
            this.dataGridList.Size = new System.Drawing.Size(651, 205);
            this.dataGridList.TabIndex = 14;
            this.dataGridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridList_CellDoubleClick);
            // 
            // btpreencher
            // 
            this.btpreencher.Location = new System.Drawing.Point(580, 157);
            this.btpreencher.Name = "btpreencher";
            this.btpreencher.Size = new System.Drawing.Size(99, 34);
            this.btpreencher.TabIndex = 15;
            this.btpreencher.Text = "Preencher";
            this.btpreencher.UseVisualStyleBackColor = true;
            this.btpreencher.Click += new System.EventHandler(this.btpreencher_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(426, 157);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(99, 34);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 426);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btpreencher);
            this.Controls.Add(this.dataGridList);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.cmbOcupacao);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Ocupação);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.btSalvar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cadastro de Jovens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button busca;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Ocupação;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbOcupacao;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.Button btpreencher;
        private System.Windows.Forms.Button btExcluir;
    }
}

