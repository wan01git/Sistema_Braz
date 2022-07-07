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
    public partial class frm_usuario_painel : Form
    {
        public frm_usuario_painel()
        {
            InitializeComponent();
           
        }

        private void frm_usuario_painel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CompraVenda compraVenda = new frm_CompraVenda();
            compraVenda.Show();
        }

        private void frm_usuario_painel_Load(object sender, EventArgs e)
        {
            label_usuario.Text = frm_login.logado.ToString();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_inventario frm_Inventario = new frm_inventario();
            frm_Inventario.Show();
        }
    }
}
