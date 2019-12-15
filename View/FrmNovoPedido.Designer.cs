namespace View
{
    partial class FrmNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFinalizarPedido = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.TxtQtde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodigoProduto = new System.Windows.Forms.TextBox();
            this.DgvItensProduto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelarVoltar = new System.Windows.Forms.Button();
            this.LblCodigoItemPedido = new System.Windows.Forms.Label();
            this.CbxEntrega = new System.Windows.Forms.CheckBox();
            this.DtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnEntrega = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtPaciente = new System.Windows.Forms.TextBox();
            this.LblEmpresaDentista = new System.Windows.Forms.Label();
            this.LblCodigoEmpresa = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(161, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Empresa / Dentista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(163, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dr. (a)";
            // 
            // BtnFinalizarPedido
            // 
            this.BtnFinalizarPedido.AutoSize = true;
            this.BtnFinalizarPedido.Location = new System.Drawing.Point(510, 488);
            this.BtnFinalizarPedido.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnFinalizarPedido.Name = "BtnFinalizarPedido";
            this.BtnFinalizarPedido.Size = new System.Drawing.Size(142, 32);
            this.BtnFinalizarPedido.TabIndex = 6;
            this.BtnFinalizarPedido.Text = "Finalizar Pedido";
            this.BtnFinalizarPedido.UseVisualStyleBackColor = true;
            this.BtnFinalizarPedido.Visible = false;
            this.BtnFinalizarPedido.Click += new System.EventHandler(this.BtnFinalizarPedido_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(9, 61);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 32);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar Pedido";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Código do Pedido";
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPedido.Location = new System.Drawing.Point(10, 105);
            this.TxtCodigoPedido.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCodigoPedido.MaxLength = 6;
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(147, 29);
            this.TxtCodigoPedido.TabIndex = 0;
            this.TxtCodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoPedido_KeyPress);
            this.TxtCodigoPedido.Leave += new System.EventHandler(this.TxtCodigoPedido_Leave);
            // 
            // TxtQtde
            // 
            this.TxtQtde.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQtde.Location = new System.Drawing.Point(454, 29);
            this.TxtQtde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtQtde.MaxLength = 60;
            this.TxtQtde.Name = "TxtQtde";
            this.TxtQtde.Size = new System.Drawing.Size(35, 22);
            this.TxtQtde.TabIndex = 2;
            this.TxtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtde_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(451, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Qtde";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeProduto.Location = new System.Drawing.Point(106, 29);
            this.TxtNomeProduto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNomeProduto.MaxLength = 60;
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(340, 22);
            this.TxtNomeProduto.TabIndex = 1;
            this.TxtNomeProduto.TextChanged += new System.EventHandler(this.TxtNomeProduto_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nome do Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cód. Produto";
            // 
            // TxtCodigoProduto
            // 
            this.TxtCodigoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProduto.Location = new System.Drawing.Point(10, 29);
            this.TxtCodigoProduto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCodigoProduto.MaxLength = 6;
            this.TxtCodigoProduto.Name = "TxtCodigoProduto";
            this.TxtCodigoProduto.Size = new System.Drawing.Size(88, 22);
            this.TxtCodigoProduto.TabIndex = 0;
            this.TxtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoProduto.TextChanged += new System.EventHandler(this.TxtCodigoProduto_TextChanged);
            this.TxtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoProduto_KeyPress);
            // 
            // DgvItensProduto
            // 
            this.DgvItensProduto.AllowUserToAddRows = false;
            this.DgvItensProduto.AllowUserToDeleteRows = false;
            this.DgvItensProduto.AllowUserToOrderColumns = true;
            this.DgvItensProduto.AllowUserToResizeColumns = false;
            this.DgvItensProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvItensProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvItensProduto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvItensProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvItensProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItensProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIP,
            this.CODIGO,
            this.PRODUTO,
            this.PACIENTE,
            this.VALUNID,
            this.QTDE,
            this.TOTAL,
            this.ENTREGA});
            this.DgvItensProduto.Location = new System.Drawing.Point(10, 101);
            this.DgvItensProduto.MultiSelect = false;
            this.DgvItensProduto.Name = "DgvItensProduto";
            this.DgvItensProduto.RowHeadersVisible = false;
            this.DgvItensProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItensProduto.Size = new System.Drawing.Size(1031, 379);
            this.DgvItensProduto.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnCancelarVoltar);
            this.panel1.Controls.Add(this.LblCodigoItemPedido);
            this.panel1.Controls.Add(this.CbxEntrega);
            this.panel1.Controls.Add(this.DtpEntrega);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnEntrega);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnRemover);
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.BtnAdicionarProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.DgvItensProduto);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnFinalizarPedido);
            this.panel1.Controls.Add(this.TxtQtde);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtNomeProduto);
            this.panel1.Controls.Add(this.TxtPaciente);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtCodigoProduto);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 578);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // BtnCancelarVoltar
            // 
            this.BtnCancelarVoltar.AutoSize = true;
            this.BtnCancelarVoltar.Location = new System.Drawing.Point(729, 61);
            this.BtnCancelarVoltar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCancelarVoltar.Name = "BtnCancelarVoltar";
            this.BtnCancelarVoltar.Size = new System.Drawing.Size(144, 32);
            this.BtnCancelarVoltar.TabIndex = 43;
            this.BtnCancelarVoltar.Text = "Cancelar/Voltar";
            this.BtnCancelarVoltar.UseVisualStyleBackColor = true;
            this.BtnCancelarVoltar.Visible = false;
            this.BtnCancelarVoltar.Click += new System.EventHandler(this.BtnCancelarVoltar_Click);
            // 
            // LblCodigoItemPedido
            // 
            this.LblCodigoItemPedido.AutoSize = true;
            this.LblCodigoItemPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoItemPedido.Location = new System.Drawing.Point(720, 8);
            this.LblCodigoItemPedido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodigoItemPedido.Name = "LblCodigoItemPedido";
            this.LblCodigoItemPedido.Size = new System.Drawing.Size(126, 16);
            this.LblCodigoItemPedido.TabIndex = 42;
            this.LblCodigoItemPedido.Text = "CodigoItemPedido";
            this.LblCodigoItemPedido.Visible = false;
            // 
            // CbxEntrega
            // 
            this.CbxEntrega.AutoSize = true;
            this.CbxEntrega.Location = new System.Drawing.Point(1023, 10);
            this.CbxEntrega.Name = "CbxEntrega";
            this.CbxEntrega.Size = new System.Drawing.Size(15, 14);
            this.CbxEntrega.TabIndex = 41;
            this.CbxEntrega.UseVisualStyleBackColor = true;
            this.CbxEntrega.CheckedChanged += new System.EventHandler(this.CbxEntrega_CheckedChanged);
            // 
            // DtpEntrega
            // 
            this.DtpEntrega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntrega.Location = new System.Drawing.Point(937, 29);
            this.DtpEntrega.Name = "DtpEntrega";
            this.DtpEntrega.Size = new System.Drawing.Size(103, 22);
            this.DtpEntrega.TabIndex = 4;
            this.DtpEntrega.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(935, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Entrega";
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.BackColor = System.Drawing.Color.Red;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFechar.Location = new System.Drawing.Point(9, 488);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(144, 32);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnEntrega
            // 
            this.BtnEntrega.AutoSize = true;
            this.BtnEntrega.Location = new System.Drawing.Point(585, 61);
            this.BtnEntrega.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnEntrega.Name = "BtnEntrega";
            this.BtnEntrega.Size = new System.Drawing.Size(144, 32);
            this.BtnEntrega.TabIndex = 10;
            this.BtnEntrega.Text = "Registrar Entrega";
            this.BtnEntrega.UseVisualStyleBackColor = true;
            this.BtnEntrega.Visible = false;
            this.BtnEntrega.Click += new System.EventHandler(this.BtnEntrega_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSize = true;
            this.BtnEditar.Location = new System.Drawing.Point(297, 61);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(144, 32);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar Produto";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "VALOR TOTAL:";
            // 
            // BtnRemover
            // 
            this.BtnRemover.AutoSize = true;
            this.BtnRemover.BackColor = System.Drawing.Color.Red;
            this.BtnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemover.Location = new System.Drawing.Point(153, 61);
            this.BtnRemover.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(144, 32);
            this.BtnRemover.TabIndex = 11;
            this.BtnRemover.Text = "Remover Produto";
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Visible = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.AutoSize = true;
            this.BtnLimpar.Location = new System.Drawing.Point(441, 61);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(144, 32);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar Campos";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.AutoSize = true;
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(873, 61);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(144, 32);
            this.BtnAdicionarProduto.TabIndex = 5;
            this.BtnAdicionarProduto.Text = "Adicionar Produto";
            this.BtnAdicionarProduto.UseVisualStyleBackColor = true;
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtnAdicionarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Paciente";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(793, 495);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(61, 19);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "R$0,00";
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaciente.Location = new System.Drawing.Point(497, 29);
            this.TxtPaciente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtPaciente.MaxLength = 60;
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(432, 22);
            this.TxtPaciente.TabIndex = 3;
            // 
            // LblEmpresaDentista
            // 
            this.LblEmpresaDentista.AutoSize = true;
            this.LblEmpresaDentista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresaDentista.Location = new System.Drawing.Point(160, 33);
            this.LblEmpresaDentista.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmpresaDentista.Name = "LblEmpresaDentista";
            this.LblEmpresaDentista.Size = new System.Drawing.Size(394, 24);
            this.LblEmpresaDentista.TabIndex = 23;
            this.LblEmpresaDentista.Text = "NOME DA EMPRESA OU DO DENTISTA";
            // 
            // LblCodigoEmpresa
            // 
            this.LblCodigoEmpresa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoEmpresa.ForeColor = System.Drawing.Color.Red;
            this.LblCodigoEmpresa.Location = new System.Drawing.Point(29, 25);
            this.LblCodigoEmpresa.Name = "LblCodigoEmpresa";
            this.LblCodigoEmpresa.Size = new System.Drawing.Size(90, 24);
            this.LblCodigoEmpresa.TabIndex = 22;
            this.LblCodigoEmpresa.Text = "123456";
            this.LblCodigoEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCliente
            // 
            this.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtCliente.Location = new System.Drawing.Point(164, 105);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCliente.MaxLength = 60;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(682, 29);
            this.TxtCliente.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.LblCodigoPedido);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtCodigoPedido);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TxtCliente);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 147);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(859, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoPedido.Location = new System.Drawing.Point(172, 6);
            this.LblCodigoPedido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(0, 19);
            this.LblCodigoPedido.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LblCodigoEmpresa);
            this.panel4.Controls.Add(this.LblEmpresaDentista);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 76);
            this.panel4.TabIndex = 25;
            // 
            // CIP
            // 
            this.CIP.HeaderText = "Cip";
            this.CIP.Name = "CIP";
            this.CIP.ReadOnly = true;
            this.CIP.Visible = false;
            this.CIP.Width = 40;
            // 
            // CODIGO
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 70;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "Produto";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 300;
            // 
            // PACIENTE
            // 
            this.PACIENTE.HeaderText = "Paciente";
            this.PACIENTE.Name = "PACIENTE";
            this.PACIENTE.ReadOnly = true;
            this.PACIENTE.Width = 270;
            // 
            // VALUNID
            // 
            dataGridViewCellStyle3.Format = "C";
            this.VALUNID.DefaultCellStyle = dataGridViewCellStyle3;
            this.VALUNID.HeaderText = "V. Unid.";
            this.VALUNID.Name = "VALUNID";
            this.VALUNID.ReadOnly = true;
            // 
            // QTDE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QTDE.DefaultCellStyle = dataGridViewCellStyle4;
            this.QTDE.HeaderText = "Qt";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 40;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle5.Format = "C";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // ENTREGA
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.ENTREGA.DefaultCellStyle = dataGridViewCellStyle6;
            this.ENTREGA.HeaderText = "Entrega";
            this.ENTREGA.Name = "ENTREGA";
            this.ENTREGA.ReadOnly = true;
            this.ENTREGA.Width = 120;
            // 
            // FrmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 682);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário para Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFinalizarPedido;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.TextBox TxtQtde;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigoProduto;
        private System.Windows.Forms.DataGridView DgvItensProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblEmpresaDentista;
        private System.Windows.Forms.Label LblCodigoEmpresa;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtPaciente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DateTimePicker DtpEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbxEntrega;
        private System.Windows.Forms.Label LblCodigoItemPedido;
        private System.Windows.Forms.Button BtnCancelarVoltar;
        private System.Windows.Forms.Button BtnEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGA;
    }
}