namespace Sistema_Braz.UI_formularios
{
    partial class frm_CompraVenda
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
            this.button_finalizarCompra = new System.Windows.Forms.Button();
            this.button_add_produto = new System.Windows.Forms.Button();
            this.dataGridView_produtos = new System.Windows.Forms.DataGridView();
            this.label_imposto = new System.Windows.Forms.Label();
            this.textBox_Desconto = new System.Windows.Forms.TextBox();
            this.label_desconto = new System.Windows.Forms.Label();
            this.textBox_SubTotal = new System.Windows.Forms.TextBox();
            this.label_subTotal = new System.Windows.Forms.Label();
            this.textBox_produto_quantidade = new System.Windows.Forms.TextBox();
            this.label_quantidade_produto = new System.Windows.Forms.Label();
            this.textBox_produto_nome = new System.Windows.Forms.TextBox();
            this.label_nome_produto = new System.Windows.Forms.Label();
            this.textBox_pesquisar_produto = new System.Windows.Forms.TextBox();
            this.label_pesquisar_produto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo_produto = new System.Windows.Forms.Label();
            this.label_detalhesCompra = new System.Windows.Forms.Label();
            this.textBox_Imposto = new System.Windows.Forms.TextBox();
            this.label_produtos_add = new System.Windows.Forms.Label();
            this.label_ValorTotal = new System.Windows.Forms.Label();
            this.textBox_ValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TotalPago = new System.Windows.Forms.TextBox();
            this.textBox_Troco = new System.Windows.Forms.TextBox();
            this.textBox_produto_qtd_total = new System.Windows.Forms.TextBox();
            this.label_quantidade_disponivel = new System.Windows.Forms.Label();
            this.textBox_produto_avaliacao = new System.Windows.Forms.TextBox();
            this.label_avaliacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_finalizarCompra
            // 
            this.button_finalizarCompra.BackColor = System.Drawing.Color.ForestGreen;
            this.button_finalizarCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finalizarCompra.Location = new System.Drawing.Point(1208, 321);
            this.button_finalizarCompra.Name = "button_finalizarCompra";
            this.button_finalizarCompra.Size = new System.Drawing.Size(117, 77);
            this.button_finalizarCompra.TabIndex = 42;
            this.button_finalizarCompra.Text = "finalizar Compra";
            this.button_finalizarCompra.UseVisualStyleBackColor = false;
            this.button_finalizarCompra.Click += new System.EventHandler(this.button_finalizarCompra_Click);
            // 
            // button_add_produto
            // 
            this.button_add_produto.BackColor = System.Drawing.Color.Bisque;
            this.button_add_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_produto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_produto.Location = new System.Drawing.Point(16, 323);
            this.button_add_produto.Name = "button_add_produto";
            this.button_add_produto.Size = new System.Drawing.Size(416, 32);
            this.button_add_produto.TabIndex = 41;
            this.button_add_produto.Text = "adicionar à compra";
            this.button_add_produto.UseVisualStyleBackColor = false;
            this.button_add_produto.Click += new System.EventHandler(this.button_add_produto_Click);
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
            this.dataGridView_produtos.Location = new System.Drawing.Point(553, 101);
            this.dataGridView_produtos.Name = "dataGridView_produtos";
            this.dataGridView_produtos.Size = new System.Drawing.Size(564, 519);
            this.dataGridView_produtos.TabIndex = 38;
            // 
            // label_imposto
            // 
            this.label_imposto.AutoSize = true;
            this.label_imposto.BackColor = System.Drawing.Color.Transparent;
            this.label_imposto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imposto.Location = new System.Drawing.Point(12, 485);
            this.label_imposto.Name = "label_imposto";
            this.label_imposto.Size = new System.Drawing.Size(87, 22);
            this.label_imposto.TabIndex = 36;
            this.label_imposto.Text = "Imposto";
            // 
            // textBox_Desconto
            // 
            this.textBox_Desconto.AcceptsReturn = true;
            this.textBox_Desconto.AcceptsTab = true;
            this.textBox_Desconto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Desconto.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Desconto.Location = new System.Drawing.Point(150, 451);
            this.textBox_Desconto.Name = "textBox_Desconto";
            this.textBox_Desconto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Desconto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Desconto.Size = new System.Drawing.Size(282, 21);
            this.textBox_Desconto.TabIndex = 35;
            this.textBox_Desconto.Text = "0,00";
            this.textBox_Desconto.TextChanged += new System.EventHandler(this.textBox_Desconto_TextChanged);
            // 
            // label_desconto
            // 
            this.label_desconto.AutoSize = true;
            this.label_desconto.BackColor = System.Drawing.Color.Transparent;
            this.label_desconto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desconto.Location = new System.Drawing.Point(12, 451);
            this.label_desconto.Name = "label_desconto";
            this.label_desconto.Size = new System.Drawing.Size(98, 22);
            this.label_desconto.TabIndex = 34;
            this.label_desconto.Text = "Desconto";
            // 
            // textBox_SubTotal
            // 
            this.textBox_SubTotal.AcceptsReturn = true;
            this.textBox_SubTotal.AcceptsTab = true;
            this.textBox_SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SubTotal.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SubTotal.Location = new System.Drawing.Point(150, 407);
            this.textBox_SubTotal.Name = "textBox_SubTotal";
            this.textBox_SubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_SubTotal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SubTotal.Size = new System.Drawing.Size(282, 21);
            this.textBox_SubTotal.TabIndex = 33;
            this.textBox_SubTotal.Text = "0,00";
            // 
            // label_subTotal
            // 
            this.label_subTotal.AutoSize = true;
            this.label_subTotal.BackColor = System.Drawing.Color.Transparent;
            this.label_subTotal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subTotal.Location = new System.Drawing.Point(12, 406);
            this.label_subTotal.Name = "label_subTotal";
            this.label_subTotal.Size = new System.Drawing.Size(109, 22);
            this.label_subTotal.TabIndex = 32;
            this.label_subTotal.Text = "Sub Total";
            // 
            // textBox_produto_quantidade
            // 
            this.textBox_produto_quantidade.AcceptsReturn = true;
            this.textBox_produto_quantidade.AcceptsTab = true;
            this.textBox_produto_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_produto_quantidade.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_produto_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_produto_quantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_produto_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_produto_quantidade.Location = new System.Drawing.Point(150, 269);
            this.textBox_produto_quantidade.Name = "textBox_produto_quantidade";
            this.textBox_produto_quantidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_produto_quantidade.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_produto_quantidade.Size = new System.Drawing.Size(282, 21);
            this.textBox_produto_quantidade.TabIndex = 31;
            // 
            // label_quantidade_produto
            // 
            this.label_quantidade_produto.AutoSize = true;
            this.label_quantidade_produto.BackColor = System.Drawing.Color.Transparent;
            this.label_quantidade_produto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade_produto.Location = new System.Drawing.Point(12, 269);
            this.label_quantidade_produto.Name = "label_quantidade_produto";
            this.label_quantidade_produto.Size = new System.Drawing.Size(120, 22);
            this.label_quantidade_produto.TabIndex = 30;
            this.label_quantidade_produto.Text = "quantidade";
            // 
            // textBox_produto_nome
            // 
            this.textBox_produto_nome.AcceptsReturn = true;
            this.textBox_produto_nome.AcceptsTab = true;
            this.textBox_produto_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_produto_nome.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_produto_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_produto_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_produto_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_produto_nome.Location = new System.Drawing.Point(150, 160);
            this.textBox_produto_nome.Name = "textBox_produto_nome";
            this.textBox_produto_nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_produto_nome.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_produto_nome.Size = new System.Drawing.Size(282, 21);
            this.textBox_produto_nome.TabIndex = 27;
            // 
            // label_nome_produto
            // 
            this.label_nome_produto.AutoSize = true;
            this.label_nome_produto.BackColor = System.Drawing.Color.Transparent;
            this.label_nome_produto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_produto.Location = new System.Drawing.Point(12, 157);
            this.label_nome_produto.Name = "label_nome_produto";
            this.label_nome_produto.Size = new System.Drawing.Size(65, 22);
            this.label_nome_produto.TabIndex = 26;
            this.label_nome_produto.Text = "nome ";
            // 
            // textBox_pesquisar_produto
            // 
            this.textBox_pesquisar_produto.AcceptsReturn = true;
            this.textBox_pesquisar_produto.AcceptsTab = true;
            this.textBox_pesquisar_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pesquisar_produto.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_pesquisar_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pesquisar_produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisar_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pesquisar_produto.Location = new System.Drawing.Point(150, 122);
            this.textBox_pesquisar_produto.Name = "textBox_pesquisar_produto";
            this.textBox_pesquisar_produto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pesquisar_produto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pesquisar_produto.Size = new System.Drawing.Size(282, 21);
            this.textBox_pesquisar_produto.TabIndex = 25;
            this.textBox_pesquisar_produto.TextChanged += new System.EventHandler(this.textBox_pesquisar_produto_TextChanged);
            // 
            // label_pesquisar_produto
            // 
            this.label_pesquisar_produto.AutoSize = true;
            this.label_pesquisar_produto.BackColor = System.Drawing.Color.Transparent;
            this.label_pesquisar_produto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisar_produto.Location = new System.Drawing.Point(12, 122);
            this.label_pesquisar_produto.Name = "label_pesquisar_produto";
            this.label_pesquisar_produto.Size = new System.Drawing.Size(109, 22);
            this.label_pesquisar_produto.TabIndex = 24;
            this.label_pesquisar_produto.Text = "Pesquisar";
            this.label_pesquisar_produto.Click += new System.EventHandler(this.label_nome_Click);
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
            this.panel1.Size = new System.Drawing.Size(1390, 40);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(648, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titulo_produto
            // 
            this.titulo_produto.AutoSize = true;
            this.titulo_produto.BackColor = System.Drawing.Color.Transparent;
            this.titulo_produto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_produto.Location = new System.Drawing.Point(118, 63);
            this.titulo_produto.Name = "titulo_produto";
            this.titulo_produto.Size = new System.Drawing.Size(219, 22);
            this.titulo_produto.TabIndex = 44;
            this.titulo_produto.Text = "detalhes do produto";
            this.titulo_produto.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_detalhesCompra
            // 
            this.label_detalhesCompra.AutoSize = true;
            this.label_detalhesCompra.BackColor = System.Drawing.Color.Transparent;
            this.label_detalhesCompra.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detalhesCompra.Location = new System.Drawing.Point(118, 363);
            this.label_detalhesCompra.Name = "label_detalhesCompra";
            this.label_detalhesCompra.Size = new System.Drawing.Size(208, 22);
            this.label_detalhesCompra.TabIndex = 32;
            this.label_detalhesCompra.Text = "Detalhes da compra";
            // 
            // textBox_Imposto
            // 
            this.textBox_Imposto.AcceptsReturn = true;
            this.textBox_Imposto.AcceptsTab = true;
            this.textBox_Imposto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Imposto.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Imposto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Imposto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Imposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Imposto.Location = new System.Drawing.Point(150, 485);
            this.textBox_Imposto.Name = "textBox_Imposto";
            this.textBox_Imposto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Imposto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Imposto.Size = new System.Drawing.Size(282, 21);
            this.textBox_Imposto.TabIndex = 45;
            this.textBox_Imposto.Text = "0,00";
            this.textBox_Imposto.TextChanged += new System.EventHandler(this.textBox_Imposto_TextChanged);
            // 
            // label_produtos_add
            // 
            this.label_produtos_add.AutoSize = true;
            this.label_produtos_add.BackColor = System.Drawing.Color.Transparent;
            this.label_produtos_add.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_produtos_add.Location = new System.Drawing.Point(733, 63);
            this.label_produtos_add.Name = "label_produtos_add";
            this.label_produtos_add.Size = new System.Drawing.Size(230, 22);
            this.label_produtos_add.TabIndex = 46;
            this.label_produtos_add.Text = "Produtos Adicionados";
            // 
            // label_ValorTotal
            // 
            this.label_ValorTotal.AutoSize = true;
            this.label_ValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.label_ValorTotal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorTotal.Location = new System.Drawing.Point(12, 525);
            this.label_ValorTotal.Name = "label_ValorTotal";
            this.label_ValorTotal.Size = new System.Drawing.Size(131, 22);
            this.label_ValorTotal.TabIndex = 47;
            this.label_ValorTotal.Text = "Valor Total";
            // 
            // textBox_ValorTotal
            // 
            this.textBox_ValorTotal.AcceptsReturn = true;
            this.textBox_ValorTotal.AcceptsTab = true;
            this.textBox_ValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ValorTotal.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_ValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorTotal.Location = new System.Drawing.Point(149, 526);
            this.textBox_ValorTotal.Name = "textBox_ValorTotal";
            this.textBox_ValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ValorTotal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ValorTotal.Size = new System.Drawing.Size(282, 21);
            this.textBox_ValorTotal.TabIndex = 48;
            this.textBox_ValorTotal.Text = "0,00";
            this.textBox_ValorTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Troco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Total Pago";
            // 
            // textBox_TotalPago
            // 
            this.textBox_TotalPago.AcceptsReturn = true;
            this.textBox_TotalPago.AcceptsTab = true;
            this.textBox_TotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TotalPago.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_TotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TotalPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_TotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalPago.Location = new System.Drawing.Point(149, 567);
            this.textBox_TotalPago.Name = "textBox_TotalPago";
            this.textBox_TotalPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_TotalPago.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_TotalPago.Size = new System.Drawing.Size(282, 21);
            this.textBox_TotalPago.TabIndex = 51;
            this.textBox_TotalPago.Text = "0,00";
            this.textBox_TotalPago.TextChanged += new System.EventHandler(this.textBox_TotalPago_TextChanged);
            // 
            // textBox_Troco
            // 
            this.textBox_Troco.AcceptsReturn = true;
            this.textBox_Troco.AcceptsTab = true;
            this.textBox_Troco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Troco.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Troco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Troco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Troco.Location = new System.Drawing.Point(149, 608);
            this.textBox_Troco.Name = "textBox_Troco";
            this.textBox_Troco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Troco.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Troco.Size = new System.Drawing.Size(282, 21);
            this.textBox_Troco.TabIndex = 52;
            this.textBox_Troco.Text = "0,00";
            // 
            // textBox_produto_qtd_total
            // 
            this.textBox_produto_qtd_total.AcceptsReturn = true;
            this.textBox_produto_qtd_total.AcceptsTab = true;
            this.textBox_produto_qtd_total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_produto_qtd_total.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_produto_qtd_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_produto_qtd_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_produto_qtd_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_produto_qtd_total.Location = new System.Drawing.Point(150, 192);
            this.textBox_produto_qtd_total.Name = "textBox_produto_qtd_total";
            this.textBox_produto_qtd_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_produto_qtd_total.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_produto_qtd_total.Size = new System.Drawing.Size(282, 21);
            this.textBox_produto_qtd_total.TabIndex = 54;
            // 
            // label_quantidade_disponivel
            // 
            this.label_quantidade_disponivel.AutoSize = true;
            this.label_quantidade_disponivel.BackColor = System.Drawing.Color.Transparent;
            this.label_quantidade_disponivel.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade_disponivel.Location = new System.Drawing.Point(12, 189);
            this.label_quantidade_disponivel.Name = "label_quantidade_disponivel";
            this.label_quantidade_disponivel.Size = new System.Drawing.Size(120, 22);
            this.label_quantidade_disponivel.TabIndex = 53;
            this.label_quantidade_disponivel.Text = "inventário";
            // 
            // textBox_produto_avaliacao
            // 
            this.textBox_produto_avaliacao.AcceptsReturn = true;
            this.textBox_produto_avaliacao.AcceptsTab = true;
            this.textBox_produto_avaliacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_produto_avaliacao.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_produto_avaliacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_produto_avaliacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_produto_avaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_produto_avaliacao.Location = new System.Drawing.Point(150, 233);
            this.textBox_produto_avaliacao.Name = "textBox_produto_avaliacao";
            this.textBox_produto_avaliacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_produto_avaliacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_produto_avaliacao.Size = new System.Drawing.Size(282, 21);
            this.textBox_produto_avaliacao.TabIndex = 56;
            // 
            // label_avaliacao
            // 
            this.label_avaliacao.AutoSize = true;
            this.label_avaliacao.BackColor = System.Drawing.Color.Transparent;
            this.label_avaliacao.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avaliacao.Location = new System.Drawing.Point(12, 230);
            this.label_avaliacao.Name = "label_avaliacao";
            this.label_avaliacao.Size = new System.Drawing.Size(109, 22);
            this.label_avaliacao.TabIndex = 55;
            this.label_avaliacao.Text = "avaliação";
            // 
            // frm_CompraVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 639);
            this.Controls.Add(this.textBox_produto_avaliacao);
            this.Controls.Add(this.label_avaliacao);
            this.Controls.Add(this.textBox_produto_qtd_total);
            this.Controls.Add(this.label_quantidade_disponivel);
            this.Controls.Add(this.textBox_Troco);
            this.Controls.Add(this.textBox_TotalPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ValorTotal);
            this.Controls.Add(this.label_ValorTotal);
            this.Controls.Add(this.label_produtos_add);
            this.Controls.Add(this.textBox_Imposto);
            this.Controls.Add(this.titulo_produto);
            this.Controls.Add(this.button_finalizarCompra);
            this.Controls.Add(this.button_add_produto);
            this.Controls.Add(this.dataGridView_produtos);
            this.Controls.Add(this.label_imposto);
            this.Controls.Add(this.textBox_Desconto);
            this.Controls.Add(this.label_desconto);
            this.Controls.Add(this.textBox_SubTotal);
            this.Controls.Add(this.label_detalhesCompra);
            this.Controls.Add(this.label_subTotal);
            this.Controls.Add(this.textBox_produto_quantidade);
            this.Controls.Add(this.label_quantidade_produto);
            this.Controls.Add(this.textBox_produto_nome);
            this.Controls.Add(this.label_nome_produto);
            this.Controls.Add(this.textBox_pesquisar_produto);
            this.Controls.Add(this.label_pesquisar_produto);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CompraVenda";
            this.Text = "CompraVenda";
            this.Load += new System.EventHandler(this.frm_CompraVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produtos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_finalizarCompra;
        private System.Windows.Forms.Button button_add_produto;
        private System.Windows.Forms.DataGridView dataGridView_produtos;
        private System.Windows.Forms.Label label_imposto;
        private System.Windows.Forms.TextBox textBox_Desconto;
        private System.Windows.Forms.Label label_desconto;
        private System.Windows.Forms.TextBox textBox_SubTotal;
        private System.Windows.Forms.Label label_subTotal;
        private System.Windows.Forms.TextBox textBox_produto_quantidade;
        private System.Windows.Forms.Label label_quantidade_produto;
        private System.Windows.Forms.TextBox textBox_produto_nome;
        private System.Windows.Forms.Label label_nome_produto;
        private System.Windows.Forms.TextBox textBox_pesquisar_produto;
        private System.Windows.Forms.Label label_pesquisar_produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo_produto;
        private System.Windows.Forms.Label label_detalhesCompra;
        private System.Windows.Forms.TextBox textBox_Imposto;
        private System.Windows.Forms.Label label_produtos_add;
        private System.Windows.Forms.Label label_ValorTotal;
        private System.Windows.Forms.TextBox textBox_ValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TotalPago;
        private System.Windows.Forms.TextBox textBox_Troco;
        private System.Windows.Forms.TextBox textBox_produto_qtd_total;
        private System.Windows.Forms.Label label_quantidade_disponivel;
        private System.Windows.Forms.TextBox textBox_produto_avaliacao;
        private System.Windows.Forms.Label label_avaliacao;
    }
}