namespace Sistema_Braz
{
    partial class frm_usuario_painel
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
            this.menuStrip_usuario = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_ola = new System.Windows.Forms.Label();
            this.menuStrip_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_usuario
            // 
            this.menuStrip_usuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip_usuario.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip_usuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.formularioDeVendasToolStripMenuItem,
            this.inventárioToolStripMenuItem});
            this.menuStrip_usuario.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_usuario.Name = "menuStrip_usuario";
            this.menuStrip_usuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_usuario.Size = new System.Drawing.Size(1442, 24);
            this.menuStrip_usuario.TabIndex = 0;
            this.menuStrip_usuario.Text = "menuStrip1";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.comprarToolStripMenuItem.Text = "Venda";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // formularioDeVendasToolStripMenuItem
            // 
            this.formularioDeVendasToolStripMenuItem.Name = "formularioDeVendasToolStripMenuItem";
            this.formularioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.formularioDeVendasToolStripMenuItem.Text = "Formulario de vendas";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.inventárioToolStripMenuItem.Text = "inventário";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.Red;
            this.label_usuario.Location = new System.Drawing.Point(61, 39);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(0, 28);
            this.label_usuario.TabIndex = 5;
            // 
            // label_ola
            // 
            this.label_ola.AutoSize = true;
            this.label_ola.BackColor = System.Drawing.Color.Transparent;
            this.label_ola.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ola.Location = new System.Drawing.Point(12, 39);
            this.label_ola.Name = "label_ola";
            this.label_ola.Size = new System.Drawing.Size(45, 30);
            this.label_ola.TabIndex = 4;
            this.label_ola.Text = "Olá";
            // 
            // frm_usuario_painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 754);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_ola);
            this.Controls.Add(this.menuStrip_usuario);
            this.MainMenuStrip = this.menuStrip_usuario;
            this.Name = "frm_usuario_painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_usuario_painel_FormClosed);
            this.Load += new System.EventHandler(this.frm_usuario_painel_Load);
            this.menuStrip_usuario.ResumeLayout(false);
            this.menuStrip_usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_usuario;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_ola;
    }
}