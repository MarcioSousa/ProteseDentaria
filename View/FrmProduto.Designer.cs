namespace View
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BrnFechar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.GbxCUD = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnCancelarRetornar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvProduto = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbxDados = new System.Windows.Forms.GroupBox();
            this.BtnItem = new System.Windows.Forms.Button();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblQtde = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.GbxCUD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).BeginInit();
            this.GbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BrnFechar);
            this.groupBox4.Controls.Add(this.TxtPesquisa);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 49);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar";
            // 
            // BrnFechar
            // 
            this.BrnFechar.AutoSize = true;
            this.BrnFechar.BackColor = System.Drawing.Color.Red;
            this.BrnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrnFechar.Location = new System.Drawing.Point(399, 17);
            this.BrnFechar.Name = "BrnFechar";
            this.BrnFechar.Size = new System.Drawing.Size(75, 23);
            this.BrnFechar.TabIndex = 5;
            this.BrnFechar.Text = "Fechar";
            this.BrnFechar.UseVisualStyleBackColor = false;
            this.BrnFechar.Click += new System.EventHandler(this.BrnFechar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 19);
            this.TxtPesquisa.MaxLength = 100;
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(384, 20);
            this.TxtPesquisa.TabIndex = 0;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // GbxCUD
            // 
            this.GbxCUD.Controls.Add(this.BtnExcluir);
            this.GbxCUD.Controls.Add(this.BtnEditar);
            this.GbxCUD.Controls.Add(this.BtnAdicionar);
            this.GbxCUD.Location = new System.Drawing.Point(12, 67);
            this.GbxCUD.Name = "GbxCUD";
            this.GbxCUD.Size = new System.Drawing.Size(311, 47);
            this.GbxCUD.TabIndex = 1;
            this.GbxCUD.TabStop = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExcluir.Location = new System.Drawing.Point(207, 16);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Visible = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSize = true;
            this.BtnEditar.Location = new System.Drawing.Point(108, 16);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(93, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.Location = new System.Drawing.Point(9, 16);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(93, 23);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnCancelarRetornar
            // 
            this.BtnCancelarRetornar.AutoSize = true;
            this.BtnCancelarRetornar.Location = new System.Drawing.Point(381, 91);
            this.BtnCancelarRetornar.Name = "BtnCancelarRetornar";
            this.BtnCancelarRetornar.Size = new System.Drawing.Size(105, 23);
            this.BtnCancelarRetornar.TabIndex = 4;
            this.BtnCancelarRetornar.Text = "Cancelar/Retornar";
            this.BtnCancelarRetornar.UseVisualStyleBackColor = true;
            this.BtnCancelarRetornar.Visible = false;
            this.BtnCancelarRetornar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.AutoSize = true;
            this.BtnCadastrar.Location = new System.Drawing.Point(403, 41);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(71, 23);
            this.BtnCadastrar.TabIndex = 10;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvProduto);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 399);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // DgvProduto
            // 
            this.DgvProduto.AllowUserToAddRows = false;
            this.DgvProduto.AllowUserToDeleteRows = false;
            this.DgvProduto.AllowUserToResizeColumns = false;
            this.DgvProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.VALOR,
            this.CODIGOTIPO,
            this.TITPO});
            this.DgvProduto.Location = new System.Drawing.Point(6, 19);
            this.DgvProduto.MultiSelect = false;
            this.DgvProduto.Name = "DgvProduto";
            this.DgvProduto.RowHeadersVisible = false;
            this.DgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProduto.Size = new System.Drawing.Size(475, 374);
            this.DgvProduto.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 60;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "nome";
            this.NOME.HeaderText = "Nome do Serviço";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 255;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "valor";
            dataGridViewCellStyle3.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle3;
            this.VALOR.HeaderText = "Preço";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 60;
            // 
            // CODIGOTIPO
            // 
            this.CODIGOTIPO.DataPropertyName = "codigotipo";
            this.CODIGOTIPO.HeaderText = "CodTipo";
            this.CODIGOTIPO.Name = "CODIGOTIPO";
            this.CODIGOTIPO.ReadOnly = true;
            this.CODIGOTIPO.Visible = false;
            // 
            // TITPO
            // 
            this.TITPO.DataPropertyName = "nometipo";
            this.TITPO.HeaderText = "Tipo";
            this.TITPO.Name = "TITPO";
            this.TITPO.ReadOnly = true;
            this.TITPO.Width = 200;
            // 
            // GbxDados
            // 
            this.GbxDados.Controls.Add(this.BtnItem);
            this.GbxDados.Controls.Add(this.CbxTipo);
            this.GbxDados.Controls.Add(this.label5);
            this.GbxDados.Controls.Add(this.BtnCadastrar);
            this.GbxDados.Controls.Add(this.label4);
            this.GbxDados.Controls.Add(this.TxtValor);
            this.GbxDados.Controls.Add(this.label1);
            this.GbxDados.Controls.Add(this.TxtCodigo);
            this.GbxDados.Controls.Add(this.label2);
            this.GbxDados.Controls.Add(this.TxtNome);
            this.GbxDados.Controls.Add(this.label3);
            this.GbxDados.Location = new System.Drawing.Point(12, 120);
            this.GbxDados.Name = "GbxDados";
            this.GbxDados.Size = new System.Drawing.Size(487, 73);
            this.GbxDados.TabIndex = 2;
            this.GbxDados.TabStop = false;
            this.GbxDados.Visible = false;
            // 
            // BtnItem
            // 
            this.BtnItem.AutoSize = true;
            this.BtnItem.Location = new System.Drawing.Point(374, 42);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(23, 23);
            this.BtnItem.TabIndex = 5;
            this.BtnItem.Text = "+";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Location = new System.Drawing.Point(181, 43);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(187, 21);
            this.CbxTipo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "R$";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(66, 43);
            this.TxtValor.MaxLength = 8;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(75, 20);
            this.TxtValor.TabIndex = 2;
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(52, 13);
            this.TxtCodigo.MaxLength = 6;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(58, 20);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Location = new System.Drawing.Point(157, 13);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(317, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // LblQtde
            // 
            this.LblQtde.AutoSize = true;
            this.LblQtde.Location = new System.Drawing.Point(354, 64);
            this.LblQtde.Name = "LblQtde";
            this.LblQtde.Size = new System.Drawing.Size(102, 13);
            this.LblQtde.TabIndex = 5;
            this.LblQtde.Text = "Qtde de Produtos: 0";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 610);
            this.Controls.Add(this.LblQtde);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnCancelarRetornar);
            this.Controls.Add(this.GbxCUD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GbxCUD.ResumeLayout(false);
            this.GbxCUD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).EndInit();
            this.GbxDados.ResumeLayout(false);
            this.GbxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.GroupBox GbxCUD;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvProduto;
        private System.Windows.Forms.GroupBox GbxDados;
        private System.Windows.Forms.Button BtnCancelarRetornar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BrnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITPO;
        private System.Windows.Forms.Label LblQtde;
    }
}