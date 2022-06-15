namespace Sistema_Braz.UI_formularios
{
    partial class frm_categorias
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_cadastro = new System.Windows.Forms.Button();
            this.label_pesquisar = new System.Windows.Forms.Label();
            this.dataGridView_categorias = new System.Windows.Forms.DataGridView();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id_categoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Brown;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(397, 504);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(82, 49);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Deletar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_atualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.Location = new System.Drawing.Point(213, 504);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(82, 49);
            this.button_atualizar.TabIndex = 22;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_cadastro
            // 
            this.button_cadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastro.Location = new System.Drawing.Point(39, 504);
            this.button_cadastro.Name = "button_cadastro";
            this.button_cadastro.Size = new System.Drawing.Size(82, 49);
            this.button_cadastro.TabIndex = 21;
            this.button_cadastro.Text = "Cadastrar";
            this.button_cadastro.UseVisualStyleBackColor = false;
            this.button_cadastro.Click += new System.EventHandler(this.button_cadastro_Click);
            // 
            // label_pesquisar
            // 
            this.label_pesquisar.AutoSize = true;
            this.label_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.label_pesquisar.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisar.Location = new System.Drawing.Point(356, 49);
            this.label_pesquisar.Name = "label_pesquisar";
            this.label_pesquisar.Size = new System.Drawing.Size(199, 19);
            this.label_pesquisar.TabIndex = 25;
            this.label_pesquisar.Text = "Pesquisar Categoria";
            // 
            // dataGridView_categorias
            // 
            this.dataGridView_categorias.AllowUserToDeleteRows = false;
            this.dataGridView_categorias.AllowUserToResizeColumns = false;
            this.dataGridView_categorias.AllowUserToResizeRows = false;
            this.dataGridView_categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_categorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_categorias.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView_categorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_categorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_categorias.Location = new System.Drawing.Point(551, 107);
            this.dataGridView_categorias.Name = "dataGridView_categorias";
            this.dataGridView_categorias.Size = new System.Drawing.Size(422, 503);
            this.dataGridView_categorias.TabIndex = 24;
            this.dataGridView_categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_categorias_CellContentClick);
            this.dataGridView_categorias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_categorias_RowHeaderMouseClick);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(12, 197);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(109, 22);
            this.label_email.TabIndex = 31;
            this.label_email.Text = "Descrição";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.AcceptsReturn = true;
            this.textBox_titulo.AcceptsTab = true;
            this.textBox_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_titulo.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_titulo.Location = new System.Drawing.Point(213, 131);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_titulo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_titulo.Size = new System.Drawing.Size(305, 21);
            this.textBox_titulo.TabIndex = 30;
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.label_sobrenome.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sobrenome.Location = new System.Drawing.Point(12, 133);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(199, 19);
            this.label_sobrenome.TabIndex = 29;
            this.label_sobrenome.Text = "Título da categoria";
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
            this.textBox_id.Location = new System.Drawing.Point(213, 80);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_id.Size = new System.Drawing.Size(64, 21);
            this.textBox_id.TabIndex = 28;
            // 
            // label_id_categoria
            // 
            this.label_id_categoria.AutoSize = true;
            this.label_id_categoria.BackColor = System.Drawing.Color.Transparent;
            this.label_id_categoria.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_categoria.Location = new System.Drawing.Point(12, 77);
            this.label_id_categoria.Name = "label_id_categoria";
            this.label_id_categoria.Size = new System.Drawing.Size(142, 22);
            this.label_id_categoria.TabIndex = 27;
            this.label_id_categoria.Text = "Categoria ID";
            this.label_id_categoria.Click += new System.EventHandler(this.label_nome_Click);
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
            this.panel1.Size = new System.Drawing.Size(985, 40);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Categorias";
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.AcceptsReturn = true;
            this.textBox_descricao.AcceptsTab = true;
            this.textBox_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_descricao.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descricao.Location = new System.Drawing.Point(213, 200);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_descricao.Size = new System.Drawing.Size(320, 247);
            this.textBox_descricao.TabIndex = 32;
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
            this.textBox_pesquisar.Location = new System.Drawing.Point(561, 49);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pesquisar.Size = new System.Drawing.Size(412, 21);
            this.textBox_pesquisar.TabIndex = 35;
            this.textBox_pesquisar.TextChanged += new System.EventHandler(this.textBox_pesquisar_TextChanged_1);
            // 
            // frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 622);
            this.Controls.Add(this.textBox_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_descricao);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_titulo);
            this.Controls.Add(this.label_sobrenome);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id_categoria);
            this.Controls.Add(this.label_pesquisar);
            this.Controls.Add(this.dataGridView_categorias);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.button_cadastro);
            this.Name = "frm_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_categorias";
            this.Load += new System.EventHandler(this.frm_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_cadastro;
        private System.Windows.Forms.Label label_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView_categorias;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label_sobrenome;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id_categoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.TextBox textBox_pesquisar;
    }
}