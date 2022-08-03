namespace View
{
    partial class FrmFechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFechamento));
            this.DgvItensPedido = new System.Windows.Forms.DataGridView();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechamento = new System.Windows.Forms.DateTimePicker();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.PrintFechamento = new System.Drawing.Printing.PrintDocument();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.LblTextoValorTotal = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.BtnAvancar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnRegistrarFechamento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDentista = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxVTotal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNumeroPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvItensPedido
            // 
            this.DgvItensPedido.AllowUserToAddRows = false;
            this.DgvItensPedido.AllowUserToDeleteRows = false;
            this.DgvItensPedido.AllowUserToOrderColumns = true;
            this.DgvItensPedido.AllowUserToResizeColumns = false;
            this.DgvItensPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvItensPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvItensPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvItensPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QUANTIDADE,
            this.PRODUTO,
            this.PACIENTE,
            this.ENTREGA,
            this.UNIDADE,
            this.VALORTOTAL});
            this.DgvItensPedido.Enabled = false;
            this.DgvItensPedido.Location = new System.Drawing.Point(12, 210);
            this.DgvItensPedido.MultiSelect = false;
            this.DgvItensPedido.Name = "DgvItensPedido";
            this.DgvItensPedido.ReadOnly = true;
            this.DgvItensPedido.RowHeadersVisible = false;
            this.DgvItensPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItensPedido.Size = new System.Drawing.Size(730, 469);
            this.DgvItensPedido.TabIndex = 29;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "Qtde";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 40;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "Produto";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 250;
            // 
            // PACIENTE
            // 
            this.PACIENTE.HeaderText = "Paciente";
            this.PACIENTE.Name = "PACIENTE";
            this.PACIENTE.ReadOnly = true;
            this.PACIENTE.Width = 200;
            // 
            // ENTREGA
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ENTREGA.DefaultCellStyle = dataGridViewCellStyle2;
            this.ENTREGA.HeaderText = "Entrega";
            this.ENTREGA.Name = "ENTREGA";
            this.ENTREGA.ReadOnly = true;
            this.ENTREGA.Width = 72;
            // 
            // UNIDADE
            // 
            dataGridViewCellStyle3.Format = "C";
            this.UNIDADE.DefaultCellStyle = dataGridViewCellStyle3;
            this.UNIDADE.HeaderText = "V. Unid.";
            this.UNIDADE.Name = "UNIDADE";
            this.UNIDADE.ReadOnly = true;
            this.UNIDADE.Width = 82;
            // 
            // VALORTOTAL
            // 
            dataGridViewCellStyle4.Format = "C";
            this.VALORTOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.VALORTOTAL.HeaderText = "Total";
            this.VALORTOTAL.Name = "VALORTOTAL";
            this.VALORTOTAL.ReadOnly = true;
            this.VALORTOTAL.Width = 83;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Soluções em prótese dentária";
            // 
            // DtpFechamento
            // 
            this.DtpFechamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.DtpFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechamento.Location = new System.Drawing.Point(615, 175);
            this.DtpFechamento.Name = "DtpFechamento";
            this.DtpFechamento.Size = new System.Drawing.Size(127, 29);
            this.DtpFechamento.TabIndex = 47;
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Enabled = false;
            this.TxtCodigoPedido.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.TxtCodigoPedido.Location = new System.Drawing.Point(444, 116);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.ReadOnly = true;
            this.TxtCodigoPedido.Size = new System.Drawing.Size(155, 35);
            this.TxtCodigoPedido.TabIndex = 46;
            this.TxtCodigoPedido.Text = "07662";
            this.TxtCodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(364, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "E-mail: criativeitu@hotmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(339, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tel.: 11 2715-2071 - Cel.: 11 97101-3921";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(774, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(74, 23);
            this.BtnFechar.TabIndex = 45;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // PrintFechamento
            // 
            this.PrintFechamento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintFechamento_PrintPage);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(774, 210);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(74, 23);
            this.BtnImprimir.TabIndex = 46;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // LblTextoValorTotal
            // 
            this.LblTextoValorTotal.AutoSize = true;
            this.LblTextoValorTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTextoValorTotal.Location = new System.Drawing.Point(370, 682);
            this.LblTextoValorTotal.Name = "LblTextoValorTotal";
            this.LblTextoValorTotal.Size = new System.Drawing.Size(154, 24);
            this.LblTextoValorTotal.TabIndex = 48;
            this.LblTextoValorTotal.Text = "VALOR TOTAL";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblValorTotal.Location = new System.Drawing.Point(530, 682);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(85, 24);
            this.LblValorTotal.TabIndex = 49;
            this.LblValorTotal.Text = "R$ 0,00";
            // 
            // BtnAvancar
            // 
            this.BtnAvancar.Location = new System.Drawing.Point(774, 465);
            this.BtnAvancar.Name = "BtnAvancar";
            this.BtnAvancar.Size = new System.Drawing.Size(74, 23);
            this.BtnAvancar.TabIndex = 50;
            this.BtnAvancar.Text = ">>>";
            this.BtnAvancar.UseVisualStyleBackColor = true;
            this.BtnAvancar.Visible = false;
            this.BtnAvancar.Click += new System.EventHandler(this.BtnAvancar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(774, 494);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(74, 23);
            this.BtnVoltar.TabIndex = 51;
            this.BtnVoltar.Text = "<<<";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Visible = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnRegistrarFechamento
            // 
            this.BtnRegistrarFechamento.Location = new System.Drawing.Point(774, 158);
            this.BtnRegistrarFechamento.Name = "BtnRegistrarFechamento";
            this.BtnRegistrarFechamento.Size = new System.Drawing.Size(74, 46);
            this.BtnRegistrarFechamento.TabIndex = 52;
            this.BtnRegistrarFechamento.Text = "Registrar Fechamento";
            this.BtnRegistrarFechamento.UseVisualStyleBackColor = true;
            this.BtnRegistrarFechamento.Click += new System.EventHandler(this.BtnRegistrarFechamento_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Dr. (a):";
            // 
            // LblDentista
            // 
            this.LblDentista.AutoSize = true;
            this.LblDentista.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDentista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDentista.Location = new System.Drawing.Point(8, 185);
            this.LblDentista.Name = "LblDentista";
            this.LblDentista.Size = new System.Drawing.Size(108, 22);
            this.LblDentista.TabIndex = 55;
            this.LblDentista.Text = "10/07/2019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(358, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Pedido";
            // 
            // CbxVTotal
            // 
            this.CbxVTotal.AutoSize = true;
            this.CbxVTotal.Location = new System.Drawing.Point(774, 622);
            this.CbxVTotal.Name = "CbxVTotal";
            this.CbxVTotal.Size = new System.Drawing.Size(77, 17);
            this.CbxVTotal.TabIndex = 56;
            this.CbxVTotal.Text = "Valor Total";
            this.CbxVTotal.UseVisualStyleBackColor = true;
            this.CbxVTotal.CheckedChanged += new System.EventHandler(this.CbxVTotal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nº Página";
            // 
            // LblNumeroPagina
            // 
            this.LblNumeroPagina.AutoSize = true;
            this.LblNumeroPagina.Location = new System.Drawing.Point(804, 293);
            this.LblNumeroPagina.Name = "LblNumeroPagina";
            this.LblNumeroPagina.Size = new System.Drawing.Size(13, 13);
            this.LblNumeroPagina.TabIndex = 58;
            this.LblNumeroPagina.Text = "1";
            // 
            // FrmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(860, 715);
            this.Controls.Add(this.LblNumeroPagina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxVTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblDentista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRegistrarFechamento);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAvancar);
            this.Controls.Add(this.LblValorTotal);
            this.Controls.Add(this.LblTextoValorTotal);
            this.Controls.Add(this.DtpFechamento);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtCodigoPedido);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvItensPedido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Fechamento";
            this.Load += new System.EventHandler(this.FrmFechamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvItensPedido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechamento;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFechar;
        private System.Drawing.Printing.PrintDocument PrintFechamento;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Label LblTextoValorTotal;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Button BtnAvancar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnRegistrarFechamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDentista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORTOTAL;
        private System.Windows.Forms.CheckBox CbxVTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNumeroPagina;
    }
}