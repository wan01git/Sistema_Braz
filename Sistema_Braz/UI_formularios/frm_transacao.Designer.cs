namespace Sistema_Braz.UI_formularios
{
    partial class frm_transacao
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
            this.dataGridView_transacao = new System.Windows.Forms.DataGridView();
            this.button_busca = new System.Windows.Forms.Button();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.label_pesquisar = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transacao)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1006, 40);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transação";
            // 
            // dataGridView_transacao
            // 
            this.dataGridView_transacao.AllowUserToDeleteRows = false;
            this.dataGridView_transacao.AllowUserToResizeColumns = false;
            this.dataGridView_transacao.AllowUserToResizeRows = false;
            this.dataGridView_transacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_transacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_transacao.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView_transacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_transacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_transacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transacao.Location = new System.Drawing.Point(12, 105);
            this.dataGridView_transacao.Name = "dataGridView_transacao";
            this.dataGridView_transacao.Size = new System.Drawing.Size(982, 517);
            this.dataGridView_transacao.TabIndex = 39;
            // 
            // button_busca
            // 
            this.button_busca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_busca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_busca.Location = new System.Drawing.Point(787, 52);
            this.button_busca.Name = "button_busca";
            this.button_busca.Size = new System.Drawing.Size(207, 33);
            this.button_busca.TabIndex = 36;
            this.button_busca.Text = "Buscar";
            this.button_busca.UseVisualStyleBackColor = false;
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
            this.textBox_pesquisar.Location = new System.Drawing.Point(213, 58);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pesquisar.Size = new System.Drawing.Size(551, 21);
            this.textBox_pesquisar.TabIndex = 48;
            this.textBox_pesquisar.TextChanged += new System.EventHandler(this.textBox_pesquisar_TextChanged);
            // 
            // label_pesquisar
            // 
            this.label_pesquisar.AutoSize = true;
            this.label_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.label_pesquisar.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisar.Location = new System.Drawing.Point(8, 58);
            this.label_pesquisar.Name = "label_pesquisar";
            this.label_pesquisar.Size = new System.Drawing.Size(199, 19);
            this.label_pesquisar.TabIndex = 40;
            this.label_pesquisar.Text = "Pesquisar Transação";
            this.label_pesquisar.Click += new System.EventHandler(this.label_pesquisar_Click);
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
            this.textBox_id.Location = new System.Drawing.Point(213, 92);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_id.Size = new System.Drawing.Size(0, 21);
            this.textBox_id.TabIndex = 42;
            // 
            // frm_transacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_pesquisar);
            this.Controls.Add(this.dataGridView_transacao);
            this.Controls.Add(this.button_busca);
            this.Controls.Add(this.textBox_pesquisar);
            this.Name = "frm_transacao";
            this.Text = "frm_transacao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_transacao_FormClosed);
            this.Load += new System.EventHandler(this.frm_transacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_transacao;
        private System.Windows.Forms.Button button_busca;
        private System.Windows.Forms.TextBox textBox_pesquisar;
        private System.Windows.Forms.Label label_pesquisar;
        private System.Windows.Forms.TextBox textBox_id;
    }
}