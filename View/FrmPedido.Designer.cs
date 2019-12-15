namespace View
{
    partial class FrmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.DgvEmpresa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovoPedido = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DENTISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAFECHAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExcluirFechamento = new System.Windows.Forms.Button();
            this.BtnFechamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmpresa
            // 
            this.DgvEmpresa.AllowUserToAddRows = false;
            this.DgvEmpresa.AllowUserToDeleteRows = false;
            this.DgvEmpresa.AllowUserToResizeColumns = false;
            this.DgvEmpresa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DONO,
            this.dataGridViewTextBoxColumn1});
            this.DgvEmpresa.Location = new System.Drawing.Point(6, 63);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.RowHeadersVisible = false;
            this.DgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresa.Size = new System.Drawing.Size(544, 515);
            this.DgvEmpresa.TabIndex = 6;
            this.DgvEmpresa.SelectionChanged += new System.EventHandler(this.DgvEmpresa_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // DONO
            // 
            this.DONO.DataPropertyName = "dentistadono";
            this.DONO.HeaderText = "Dono / Médico";
            this.DONO.Name = "DONO";
            this.DONO.ReadOnly = true;
            this.DONO.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empresanome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Empresas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSize = true;
            this.BtnEditar.Location = new System.Drawing.Point(95, 34);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(93, 23);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar Pedido";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovoPedido
            // 
            this.BtnNovoPedido.AutoSize = true;
            this.BtnNovoPedido.Location = new System.Drawing.Point(2, 34);
            this.BtnNovoPedido.Name = "BtnNovoPedido";
            this.BtnNovoPedido.Size = new System.Drawing.Size(93, 23);
            this.BtnNovoPedido.TabIndex = 4;
            this.BtnNovoPedido.Text = "Novo Pedido";
            this.BtnNovoPedido.UseVisualStyleBackColor = true;
            this.BtnNovoPedido.Click += new System.EventHandler(this.BtnNovoPedido_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(66, 37);
            this.TxtPesquisa.MaxLength = 60;
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(483, 20);
            this.TxtPesquisa.TabIndex = 7;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisar";
            // 
            // DgvPedido
            // 
            this.DgvPedido.AllowUserToAddRows = false;
            this.DgvPedido.AllowUserToDeleteRows = false;
            this.DgvPedido.AllowUserToResizeColumns = false;
            this.DgvPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.CODIGOEMPRESA,
            this.DENTISTA,
            this.DATAFECHAMENTO});
            this.DgvPedido.Location = new System.Drawing.Point(2, 63);
            this.DgvPedido.MultiSelect = false;
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.RowHeadersVisible = false;
            this.DgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedido.Size = new System.Drawing.Size(434, 514);
            this.DgvPedido.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // CODIGOEMPRESA
            // 
            this.CODIGOEMPRESA.DataPropertyName = "codigoempresa";
            this.CODIGOEMPRESA.HeaderText = "CodigoEmpresa";
            this.CODIGOEMPRESA.Name = "CODIGOEMPRESA";
            this.CODIGOEMPRESA.ReadOnly = true;
            this.CODIGOEMPRESA.Visible = false;
            // 
            // DENTISTA
            // 
            this.DENTISTA.DataPropertyName = "dentista";
            this.DENTISTA.HeaderText = "Dentista";
            this.DENTISTA.Name = "DENTISTA";
            this.DENTISTA.ReadOnly = true;
            this.DENTISTA.Width = 250;
            // 
            // DATAFECHAMENTO
            // 
            this.DATAFECHAMENTO.DataPropertyName = "datafechamento";
            this.DATAFECHAMENTO.HeaderText = "DataFechamento";
            this.DATAFECHAMENTO.Name = "DATAFECHAMENTO";
            this.DATAFECHAMENTO.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgvEmpresa);
            this.panel1.Controls.Add(this.TxtPesquisa);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 585);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de Médicos / Empresas";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnExcluirFechamento);
            this.panel2.Controls.Add(this.BtnFechamento);
            this.panel2.Controls.Add(this.DgvPedido);
            this.panel2.Controls.Add(this.BtnNovoPedido);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnEditar);
            this.panel2.Location = new System.Drawing.Point(563, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 584);
            this.panel2.TabIndex = 12;
            // 
            // BtnExcluirFechamento
            // 
            this.BtnExcluirFechamento.AutoSize = true;
            this.BtnExcluirFechamento.BackColor = System.Drawing.Color.Red;
            this.BtnExcluirFechamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExcluirFechamento.Location = new System.Drawing.Point(188, 34);
            this.BtnExcluirFechamento.Name = "BtnExcluirFechamento";
            this.BtnExcluirFechamento.Size = new System.Drawing.Size(124, 23);
            this.BtnExcluirFechamento.TabIndex = 12;
            this.BtnExcluirFechamento.Text = "Excluir Fechamento";
            this.BtnExcluirFechamento.UseVisualStyleBackColor = false;
            this.BtnExcluirFechamento.Click += new System.EventHandler(this.BtnExcluirFechamento_Click);
            // 
            // BtnFechamento
            // 
            this.BtnFechamento.AutoSize = true;
            this.BtnFechamento.Location = new System.Drawing.Point(312, 34);
            this.BtnFechamento.Name = "BtnFechamento";
            this.BtnFechamento.Size = new System.Drawing.Size(124, 23);
            this.BtnFechamento.TabIndex = 11;
            this.BtnFechamento.Text = "Cadastrar Fechamento";
            this.BtnFechamento.UseVisualStyleBackColor = true;
            this.BtnFechamento.Click += new System.EventHandler(this.BtnFechamento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Pedidos";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvEmpresa;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovoPedido;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DENTISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAFECHAMENTO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFechamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExcluirFechamento;
    }
}