namespace View
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.PedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.FecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbtnDesenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPedido = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpresa.Image")));
            this.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEmpresa.Location = new System.Drawing.Point(93, 27);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(75, 83);
            this.BtnEmpresa.TabIndex = 5;
            this.BtnEmpresa.Text = "Empresa";
            this.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BtnProduto
            // 
            this.BtnProduto.Image = ((System.Drawing.Image)(resources.GetObject("BtnProduto.Image")));
            this.BtnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProduto.Location = new System.Drawing.Point(12, 27);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(75, 83);
            this.BtnProduto.TabIndex = 4;
            this.BtnProduto.Text = "Produto";
            this.BtnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutoToolStripMenuItem,
            this.EmpresaToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.PedidoToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.FecharToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // ProdutoToolStripMenuItem
            // 
            this.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem";
            this.ProdutoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ProdutoToolStripMenuItem.Text = "Produto";
            this.ProdutoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // EmpresaToolStripMenuItem
            // 
            this.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem";
            this.EmpresaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.EmpresaToolStripMenuItem.Text = "Empresa";
            this.EmpresaToolStripMenuItem.Click += new System.EventHandler(this.EmpresaToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(116, 6);
            // 
            // PedidoToolStripMenuItem1
            // 
            this.PedidoToolStripMenuItem1.Name = "PedidoToolStripMenuItem1";
            this.PedidoToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.PedidoToolStripMenuItem1.Text = "Pedido";
            this.PedidoToolStripMenuItem1.Click += new System.EventHandler(this.PedidoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // FecharToolStripMenuItem
            // 
            this.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            this.FecharToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FecharToolStripMenuItem.Text = "Fechar";
            this.FecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SistemaToolStripMenuItem,
            this.AbtnDesenvolvedor});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // SistemaToolStripMenuItem
            // 
            this.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem";
            this.SistemaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SistemaToolStripMenuItem.Text = "Sistema";
            this.SistemaToolStripMenuItem.Click += new System.EventHandler(this.SistemaToolStripMenuItem_Click);
            // 
            // AbtnDesenvolvedor
            // 
            this.AbtnDesenvolvedor.Name = "AbtnDesenvolvedor";
            this.AbtnDesenvolvedor.Size = new System.Drawing.Size(152, 22);
            this.AbtnDesenvolvedor.Text = "Desenvolvedor";
            this.AbtnDesenvolvedor.Click += new System.EventHandler(this.AbtnDesenvolvedor_Click);
            // 
            // BtnPedido
            // 
            this.BtnPedido.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedido.Image")));
            this.BtnPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPedido.Location = new System.Drawing.Point(174, 27);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(75, 83);
            this.BtnPedido.TabIndex = 9;
            this.BtnPedido.Text = "Pedidos";
            this.BtnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPedido.UseVisualStyleBackColor = true;
            this.BtnPedido.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 351);
            this.Controls.Add(this.BtnPedido);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.BtnProduto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criative - Soluções em Prótese Dentária - Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SistemaToolStripMenuItem;
        private System.Windows.Forms.Button BtnPedido;
        private System.Windows.Forms.ToolStripMenuItem AbtnDesenvolvedor;
    }
}