namespace View
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvEmpresa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTATOU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTATOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelu = new System.Windows.Forms.TextBox();
            this.TxtTeld = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbxUf = new System.Windows.Forms.ComboBox();
            this.MtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.BtnExcluir);
            this.groupBox6.Controls.Add(this.DgvEmpresa);
            this.groupBox6.Controls.Add(this.BtnEditar);
            this.groupBox6.Location = new System.Drawing.Point(422, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(515, 364);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Lista de Empresas ou/e Médicos do Sistema";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExcluir.Location = new System.Drawing.Point(434, 14);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvEmpresa
            // 
            this.DgvEmpresa.AllowUserToAddRows = false;
            this.DgvEmpresa.AllowUserToDeleteRows = false;
            this.DgvEmpresa.AllowUserToResizeColumns = false;
            this.DgvEmpresa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.dataGridViewTextBoxColumn1,
            this.DONO,
            this.RUA,
            this.NUMERO,
            this.BAIRRO,
            this.CIDADE,
            this.UF,
            this.CEP,
            this.CONTATOU,
            this.CONTATOD});
            this.DgvEmpresa.Location = new System.Drawing.Point(6, 43);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.RowHeadersVisible = false;
            this.DgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresa.Size = new System.Drawing.Size(503, 312);
            this.DgvEmpresa.TabIndex = 2;
            this.DgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresa_CellContentClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empresanome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Empresas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // DONO
            // 
            this.DONO.DataPropertyName = "dentistadono";
            this.DONO.HeaderText = "Dono / Médico";
            this.DONO.Name = "DONO";
            this.DONO.ReadOnly = true;
            this.DONO.Width = 210;
            // 
            // RUA
            // 
            this.RUA.DataPropertyName = "rua";
            this.RUA.HeaderText = "Rua";
            this.RUA.Name = "RUA";
            this.RUA.ReadOnly = true;
            this.RUA.Visible = false;
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "numero";
            this.NUMERO.HeaderText = "Numero";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            this.NUMERO.Visible = false;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "bairro";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Visible = false;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "cidade";
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Visible = false;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "uf";
            this.UF.HeaderText = "Uf";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "cep";
            this.CEP.HeaderText = "Cep";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Visible = false;
            // 
            // CONTATOU
            // 
            this.CONTATOU.DataPropertyName = "contatoU";
            this.CONTATOU.HeaderText = "Contato1";
            this.CONTATOU.Name = "CONTATOU";
            this.CONTATOU.ReadOnly = true;
            this.CONTATOU.Visible = false;
            // 
            // CONTATOD
            // 
            this.CONTATOD.DataPropertyName = "contatoD";
            this.CONTATOD.HeaderText = "Contato2";
            this.CONTATOD.Name = "CONTATOD";
            this.CONTATOD.ReadOnly = true;
            this.CONTATOD.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(6, 14);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 0;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnAdicionar);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 46);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(11, 14);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionarEmpresa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefone 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefone 1";
            // 
            // TxtTelu
            // 
            this.TxtTelu.Enabled = false;
            this.TxtTelu.Location = new System.Drawing.Point(210, 118);
            this.TxtTelu.MaxLength = 14;
            this.TxtTelu.Name = "TxtTelu";
            this.TxtTelu.Size = new System.Drawing.Size(87, 20);
            this.TxtTelu.TabIndex = 6;
            this.TxtTelu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTelu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelu_KeyPress);
            this.TxtTelu.Leave += new System.EventHandler(this.TxtTelu_Leave);
            // 
            // TxtTeld
            // 
            this.TxtTeld.Enabled = false;
            this.TxtTeld.Location = new System.Drawing.Point(303, 118);
            this.TxtTeld.MaxLength = 14;
            this.TxtTeld.Name = "TxtTeld";
            this.TxtTeld.Size = new System.Drawing.Size(87, 20);
            this.TxtTeld.TabIndex = 7;
            this.TxtTeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTeld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTeld_KeyPress);
            this.TxtTeld.Leave += new System.EventHandler(this.TxtTeld_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.CbxUf);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtTelu);
            this.groupBox3.Controls.Add(this.MtbCep);
            this.groupBox3.Controls.Add(this.TxtTeld);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtRua);
            this.groupBox3.Controls.Add(this.TxtNumero);
            this.groupBox3.Controls.Add(this.TxtBairro);
            this.groupBox3.Controls.Add(this.TxtCidade);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // CbxUf
            // 
            this.CbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUf.Enabled = false;
            this.CbxUf.FormattingEnabled = true;
            this.CbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.CbxUf.Location = new System.Drawing.Point(163, 118);
            this.CbxUf.Name = "CbxUf";
            this.CbxUf.Size = new System.Drawing.Size(41, 21);
            this.CbxUf.TabIndex = 5;
            // 
            // MtbCep
            // 
            this.MtbCep.Enabled = false;
            this.MtbCep.Location = new System.Drawing.Point(11, 40);
            this.MtbCep.Mask = "00000-999";
            this.MtbCep.Name = "MtbCep";
            this.MtbCep.Size = new System.Drawing.Size(66, 20);
            this.MtbCep.TabIndex = 0;
            this.MtbCep.Leave += new System.EventHandler(this.MtbCep_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cep";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Uf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rua / Avenida";
            // 
            // TxtRua
            // 
            this.TxtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRua.Enabled = false;
            this.TxtRua.Location = new System.Drawing.Point(83, 40);
            this.TxtRua.MaxLength = 60;
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(307, 20);
            this.TxtRua.TabIndex = 1;
            // 
            // TxtNumero
            // 
            this.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(11, 80);
            this.TxtNumero.MaxLength = 10;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(88, 20);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.Leave += new System.EventHandler(this.TxtNumero_Leave);
            // 
            // TxtBairro
            // 
            this.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairro.Enabled = false;
            this.TxtBairro.Location = new System.Drawing.Point(105, 79);
            this.TxtBairro.MaxLength = 60;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(285, 20);
            this.TxtBairro.TabIndex = 3;
            // 
            // TxtCidade
            // 
            this.TxtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCidade.Enabled = false;
            this.TxtCidade.Location = new System.Drawing.Point(11, 118);
            this.TxtCidade.MaxLength = 60;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(146, 20);
            this.TxtCidade.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDono);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // TxtDono
            // 
            this.TxtDono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDono.Enabled = false;
            this.TxtDono.Location = new System.Drawing.Point(92, 34);
            this.TxtDono.MaxLength = 60;
            this.TxtDono.Name = "TxtDono";
            this.TxtDono.Size = new System.Drawing.Size(298, 20);
            this.TxtDono.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dono/Médico (Obrigatório)";
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(11, 73);
            this.TxtNome.MaxLength = 60;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(379, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Empresa (Opcional)";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(11, 34);
            this.TxtCodigo.MaxLength = 6;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(75, 20);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.AutoSize = true;
            this.BtnConfirmar.Location = new System.Drawing.Point(341, 344);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 344);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 387);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro de Empresas";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView DgvEmpresa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTelu;
        private System.Windows.Forms.TextBox TxtTeld;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CbxUf;
        private System.Windows.Forms.MaskedTextBox MtbCep;
        private System.Windows.Forms.TextBox TxtDono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTATOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTATOD;
        private System.Windows.Forms.Label label12;
    }
}