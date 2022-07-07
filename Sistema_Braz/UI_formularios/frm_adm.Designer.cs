namespace Sistema_Braz
{
    partial class frm_adm
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
            this.pnl_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_ola = new System.Windows.Forms.Label();
            this.pnl_rodape.SuspendLayout();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_rodape
            // 
            this.pnl_rodape.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_rodape.Controls.Add(this.label1);
            this.pnl_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_rodape.Location = new System.Drawing.Point(0, 788);
            this.pnl_rodape.Name = "pnl_rodape";
            this.pnl_rodape.Size = new System.Drawing.Size(1905, 50);
            this.pnl_rodape.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 14);
            this.label1.MinimumSize = new System.Drawing.Size(30, 400);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(839, 400);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bn Morais Ferro Velho Oeste LTDA         plplplpl@hotmail.com         (62) 3225-2" +
    "011\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu_principal
            // 
            this.menu_principal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu_principal.Font = new System.Drawing.Font("Roboto Lt", 11F, System.Drawing.FontStyle.Bold);
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.inventárioToolStripMenuItem,
            this.transaçõesToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.menu_principal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(1905, 26);
            this.menu_principal.TabIndex = 1;
            this.menu_principal.Text = "menuStrip1";
            this.menu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_principal_ItemClicked);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            this.inventárioToolStripMenuItem.Click += new System.EventHandler(this.inventárioToolStripMenuItem_Click);
            // 
            // transaçõesToolStripMenuItem
            // 
            this.transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            this.transaçõesToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.transaçõesToolStripMenuItem.Text = "Transações";
            this.transaçõesToolStripMenuItem.Click += new System.EventHandler(this.transaçõesToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.compraToolStripMenuItem.Text = "Venda";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.Red;
            this.label_usuario.Location = new System.Drawing.Point(78, 44);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(0, 28);
            this.label_usuario.TabIndex = 7;
            // 
            // label_ola
            // 
            this.label_ola.AutoSize = true;
            this.label_ola.BackColor = System.Drawing.Color.Transparent;
            this.label_ola.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ola.Location = new System.Drawing.Point(12, 42);
            this.label_ola.Name = "label_ola";
            this.label_ola.Size = new System.Drawing.Size(45, 30);
            this.label_ola.TabIndex = 6;
            this.label_ola.Text = "Olá";
            // 
            // frm_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1905, 838);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.pnl_rodape);
            this.Controls.Add(this.label_ola);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Name = "frm_adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "painel administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_adm_FormClosed);
            this.Load += new System.EventHandler(this.frm_adm_Load);
            this.pnl_rodape.ResumeLayout(false);
            this.pnl_rodape.PerformLayout();
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_ola;
    }
}

