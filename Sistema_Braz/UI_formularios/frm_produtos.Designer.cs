namespace Sistema_Braz.UI_formularios
{
    partial class frm_produtos
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
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id_categoria = new System.Windows.Forms.Label();
            this.label_pesquisar = new System.Windows.Forms.Label();
            this.dataGridView_produtos = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_cadastro = new System.Windows.Forms.Button();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.textBox_doID = new System.Windows.Forms.TextBox();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.label_adm = new System.Windows.Forms.Label();
            this.textBox_avaliacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).BeginInit();
            this.SuspendLayout();
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
            this.textBox_pesquisar.Location = new System.Drawing.Point(561, 69);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pesquisar.Size = new System.Drawing.Size(412, 21);
            this.textBox_pesquisar.TabIndex = 48;
            this.textBox_pesquisar.TextChanged += new System.EventHandler(this.textBox_pesquisar_TextChanged);
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
            this.panel1.Size = new System.Drawing.Size(992, 40);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(12, 304);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(109, 22);
            this.label_email.TabIndex = 45;
            this.label_email.Text = "Descrição";
            // 
            // textBox_nome
            // 
            this.textBox_nome.AcceptsReturn = true;
            this.textBox_nome.AcceptsTab = true;
            this.textBox_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nome.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(213, 141);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_nome.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_nome.Size = new System.Drawing.Size(266, 21);
            this.textBox_nome.TabIndex = 44;
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.label_sobrenome.Font = new System.Drawing.Font("Monospac821 BT", 14F, System.Drawing.FontStyle.Bold);
            this.label_sobrenome.Location = new System.Drawing.Point(12, 143);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(175, 22);
            this.label_sobrenome.TabIndex = 43;
            this.label_sobrenome.Text = "Nome do Produto";
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
            this.textBox_id.Location = new System.Drawing.Point(213, 100);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_id.Size = new System.Drawing.Size(0, 21);
            this.textBox_id.TabIndex = 42;
            // 
            // label_id_categoria
            // 
            this.label_id_categoria.AutoSize = true;
            this.label_id_categoria.BackColor = System.Drawing.Color.Transparent;
            this.label_id_categoria.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_categoria.Location = new System.Drawing.Point(12, 97);
            this.label_id_categoria.Name = "label_id_categoria";
            this.label_id_categoria.Size = new System.Drawing.Size(120, 22);
            this.label_id_categoria.TabIndex = 41;
            this.label_id_categoria.Text = "Produto ID";
            // 
            // label_pesquisar
            // 
            this.label_pesquisar.AutoSize = true;
            this.label_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.label_pesquisar.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisar.Location = new System.Drawing.Point(356, 69);
            this.label_pesquisar.Name = "label_pesquisar";
            this.label_pesquisar.Size = new System.Drawing.Size(179, 19);
            this.label_pesquisar.TabIndex = 40;
            this.label_pesquisar.Text = "Pesquisar Produto";
            // 
            // dataGridView_produtos
            // 
            this.dataGridView_produtos.AllowUserToDeleteRows = false;
            this.dataGridView_produtos.AllowUserToResizeColumns = false;
            this.dataGridView_produtos.AllowUserToResizeRows = false;
            this.dataGridView_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_produtos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produtos.Location = new System.Drawing.Point(551, 127);
            this.dataGridView_produtos.Name = "dataGridView_produtos";
            this.dataGridView_produtos.Size = new System.Drawing.Size(422, 503);
            this.dataGridView_produtos.TabIndex = 39;
            this.dataGridView_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produtos_CellContentClick);
            this.dataGridView_produtos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_produtos_RowHeaderMouseClick);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Brown;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(397, 571);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(82, 49);
            this.button_delete.TabIndex = 38;
            this.button_delete.Text = "Deletar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_atualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.Location = new System.Drawing.Point(213, 571);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(82, 49);
            this.button_atualizar.TabIndex = 37;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_cadastro
            // 
            this.button_cadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastro.Location = new System.Drawing.Point(39, 571);
            this.button_cadastro.Name = "button_cadastro";
            this.button_cadastro.Size = new System.Drawing.Size(82, 49);
            this.button_cadastro.TabIndex = 36;
            this.button_cadastro.Text = "Cadastrar";
            this.button_cadastro.UseVisualStyleBackColor = false;
            this.button_cadastro.Click += new System.EventHandler(this.button_cadastro_Click);
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
            this.textBox_descricao.Location = new System.Drawing.Point(213, 307);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_descricao.Size = new System.Drawing.Size(285, 247);
            this.textBox_descricao.TabIndex = 46;
            // 
            // textBox_doID
            // 
            this.textBox_doID.AcceptsReturn = true;
            this.textBox_doID.AcceptsTab = true;
            this.textBox_doID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_doID.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_doID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_doID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_doID.Enabled = false;
            this.textBox_doID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_doID.Location = new System.Drawing.Point(213, 100);
            this.textBox_doID.Name = "textBox_doID";
            this.textBox_doID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_doID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_doID.Size = new System.Drawing.Size(56, 21);
            this.textBox_doID.TabIndex = 49;
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.comboBox_categoria.Location = new System.Drawing.Point(213, 180);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(266, 21);
            this.comboBox_categoria.TabIndex = 51;
            // 
            // label_adm
            // 
            this.label_adm.AutoSize = true;
            this.label_adm.BackColor = System.Drawing.Color.Transparent;
            this.label_adm.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adm.Location = new System.Drawing.Point(10, 180);
            this.label_adm.Name = "label_adm";
            this.label_adm.Size = new System.Drawing.Size(109, 22);
            this.label_adm.TabIndex = 50;
            this.label_adm.Text = "Categoria";
            // 
            // textBox_avaliacao
            // 
            this.textBox_avaliacao.AcceptsReturn = true;
            this.textBox_avaliacao.AcceptsTab = true;
            this.textBox_avaliacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_avaliacao.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_avaliacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_avaliacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_avaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_avaliacao.Location = new System.Drawing.Point(213, 217);
            this.textBox_avaliacao.Name = "textBox_avaliacao";
            this.textBox_avaliacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_avaliacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_avaliacao.Size = new System.Drawing.Size(266, 21);
            this.textBox_avaliacao.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Avaliação";
            // 
            // textBox_quantidade
            // 
            this.textBox_quantidade.AcceptsReturn = true;
            this.textBox_quantidade.AcceptsTab = true;
            this.textBox_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_quantidade.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_quantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantidade.Location = new System.Drawing.Point(213, 264);
            this.textBox_quantidade.Name = "textBox_quantidade";
            this.textBox_quantidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_quantidade.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_quantidade.Size = new System.Drawing.Size(266, 21);
            this.textBox_quantidade.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Quantidade";
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 651);
            this.Controls.Add(this.textBox_quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_avaliacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.label_adm);
            this.Controls.Add(this.textBox_doID);
            this.Controls.Add(this.textBox_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_sobrenome);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id_categoria);
            this.Controls.Add(this.label_pesquisar);
            this.Controls.Add(this.dataGridView_produtos);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.button_cadastro);
            this.Controls.Add(this.textBox_descricao);
            this.Name = "frm_produtos";
            this.Text = "frm_produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_produtos_FormClosed);
            this.Load += new System.EventHandler(this.frm_produtos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_sobrenome;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id_categoria;
        private System.Windows.Forms.Label label_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView_produtos;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_cadastro;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.TextBox textBox_doID;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Label label_adm;
        private System.Windows.Forms.TextBox textBox_avaliacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_quantidade;
        private System.Windows.Forms.Label label3;
    }
}