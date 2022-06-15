using Sistema_Braz.BLL_Classes;
using Sistema_Braz.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Braz.UI_formularios
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        Login_BLL login_bll = new Login_BLL();
        Login_DAL login_dal = new Login_DAL();
        public static string logado;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                login_bll.usuario = textBox_usuario.Text.Trim();
                login_bll.senha = textBox_senha.Text.Trim();
                login_bll.adm = comboBox_adm.Text.Trim();
                bool sucesso =login_dal.login(login_bll);
                logado = textBox_usuario.Text.Trim();
                textBox_usuario.Text = "";
                textBox_senha.Text = "";
                if (sucesso == true)
                {
        
                    MessageBox.Show("Login realizado com suceso", "login");
                    switch (login_bll.adm)
                    {
                        case "Usuário":
                            {
                                frm_usuario_painel user = new frm_usuario_painel();
                                user.Show();
                                this.Hide();
                            }break;
                        case "Administrador":
                            {
                                frm_adm adm = new frm_adm();
                                adm.Show();
                                this.Hide();
                            }
                            break;
                        default:
                            {
                                frm_usuario_painel user = new frm_usuario_painel();
                                user.Show();
                                this.Hide();
                            }
                            break;


                    }
                }
                else
                    MessageBox.Show("Dados informados incorreto", "login");
            } 
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
                
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void comboBox_adm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
