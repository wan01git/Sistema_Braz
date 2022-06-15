namespace Sistema_Braz.UI_formularios
{
    partial class frm_login
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label_user_type = new System.Windows.Forms.Label();
            this.comboBox_adm = new System.Windows.Forms.ComboBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_login.Location = new System.Drawing.Point(331, 74);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(134, 54);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            // 
            // label_user
            // 
            this.label_user.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.Transparent;
            this.label_user.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_user.Location = new System.Drawing.Point(216, 147);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(133, 41);
            this.label_user.TabIndex = 1;
            this.label_user.Text = "Usuário";
            // 
            // label_senha
            // 
            this.label_senha.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_senha.AutoSize = true;
            this.label_senha.BackColor = System.Drawing.Color.Transparent;
            this.label_senha.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F);
            this.label_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_senha.Location = new System.Drawing.Point(216, 217);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(106, 41);
            this.label_senha.TabIndex = 2;
            this.label_senha.Text = "senha";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(436, 166);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(170, 20);
            this.textBox_usuario.TabIndex = 3;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(436, 237);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(170, 20);
            this.textBox_senha.TabIndex = 4;
            // 
            // label_user_type
            // 
            this.label_user_type.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_user_type.AutoSize = true;
            this.label_user_type.BackColor = System.Drawing.Color.Transparent;
            this.label_user_type.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_user_type.Location = new System.Drawing.Point(217, 295);
            this.label_user_type.Name = "label_user_type";
            this.label_user_type.Size = new System.Drawing.Size(214, 35);
            this.label_user_type.TabIndex = 5;
            this.label_user_type.Text = "tipo de usuário";
            this.label_user_type.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_adm
            // 
            this.comboBox_adm.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox_adm.FormattingEnabled = true;
            this.comboBox_adm.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.comboBox_adm.Location = new System.Drawing.Point(437, 309);
            this.comboBox_adm.Name = "comboBox_adm";
            this.comboBox_adm.Size = new System.Drawing.Size(170, 21);
            this.comboBox_adm.TabIndex = 15;
            this.comboBox_adm.SelectedIndexChanged += new System.EventHandler(this.comboBox_adm_SelectedIndexChanged);
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(337, 365);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(128, 54);
            this.button_login.TabIndex = 16;
            this.button_login.Text = "logar";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Braz.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.comboBox_adm);
            this.Controls.Add(this.label_user_type);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_login);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label_user_type;
        private System.Windows.Forms.ComboBox comboBox_adm;
        private System.Windows.Forms.Button button_login;
    }
}