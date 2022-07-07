namespace Sistema_Braz.UI_formularios
{
    partial class frm_inventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_produto = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_pesquisar = new System.Windows.Forms.Label();
            this.button_busca = new System.Windows.Forms.Button();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 40);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventário";
            // 
            // dataGridView_produto
            // 
            this.dataGridView_produto.AllowUserToDeleteRows = false;
            this.dataGridView_produto.AllowUserToResizeColumns = false;
            this.dataGridView_produto.AllowUserToResizeRows = false;
            this.dataGridView_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_produto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_produto.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView_produto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_produto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produto.Location = new System.Drawing.Point(12, 102);
            this.dataGridView_produto.Name = "dataGridView_produto";
            this.dataGridView_produto.Size = new System.Drawing.Size(982, 517);
            this.dataGridView_produto.TabIndex = 50;
            // 
            // textBox_id
            // 
            this.textBox_id.AcceptsReturn = true;
            this.textBox_id.AcceptsTab = true;
            this.textBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(213, 89);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_id.Size = new System.Drawing.Size(0, 21);
            this.textBox_id.TabIndex = 52;
            // 
            // label_pesquisar
            // 
            this.label_pesquisar.AutoSize = true;
            this.label_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.label_pesquisar.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisar.Location = new System.Drawing.Point(8, 55);
            this.label_pesquisar.Name = "label_pesquisar";
            this.label_pesquisar.Size = new System.Drawing.Size(179, 19);
            this.label_pesquisar.TabIndex = 51;
            this.label_pesquisar.Text = "Pesquisar Produto";
            // 
            // button_busca
            // 
            this.button_busca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busca.Location = new System.Drawing.Point(787, 49);
            this.button_busca.Name = "button_busca";
            this.button_busca.Size = new System.Drawing.Size(207, 33);
            this.button_busca.TabIndex = 49;
            this.button_busca.Text = "Buscar";
            this.button_busca.UseVisualStyleBackColor = false;
            this.button_busca.Click += new System.EventHandler(this.button_busca_Click);
            // 
            // textBox_pesquisar
            // 
            this.textBox_pesquisar.AcceptsReturn = true;
            this.textBox_pesquisar.AcceptsTab = true;
            this.textBox_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pesquisar.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pesquisar.Location = new System.Drawing.Point(213, 55);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pesquisar.Size = new System.Drawing.Size(523, 21);
            this.textBox_pesquisar.TabIndex = 54;
            this.textBox_pesquisar.TextChanged += new System.EventHandler(this.textBox_pesquisar_TextChanged);
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_produto);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_pesquisar);
            this.Controls.Add(this.button_busca);
            this.Controls.Add(this.textBox_pesquisar);
            this.Name = "frm_inventario";
            this.Text = "frm_inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_inventario_FormClosed);
            this.Load += new System.EventHandler(this.frm_inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_produto;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_pesquisar;
        private System.Windows.Forms.Button button_busca;
        private System.Windows.Forms.TextBox textBox_pesquisar;
    }
}