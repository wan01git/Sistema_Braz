using Sistema_Braz.UI_formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Braz
{
    public partial class frm_adm : Form
    {
        public frm_adm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios user = new frm_usuarios();
            user.Show();
        }

        private void frm_adm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias categoria = new frm_categorias();
            categoria.Show();
        }

        private void frm_adm_Load(object sender, EventArgs e)
        {
            label_usuario.Text = frm_login.logado.ToString();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos produtos = new frm_produtos(); 
            produtos.Show();
        }

        private void label_usuario_Click(object sender, EventArgs e)
        {

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CompraVenda compraVenda = new frm_CompraVenda();
            compraVenda.Show();
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_transacao transacao = new frm_transacao();
            transacao.Show();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_inventario inventario = new frm_inventario();
            inventario.Show();
        }
    }
}
