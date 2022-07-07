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
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
        }
        produtos_DAL produtos_DAL = new produtos_DAL();
        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_pesquisar.Text != null)
            {
                DataTable dt = produtos_DAL.Pesquisar(textBox_pesquisar.Text);
                dataGridView_produto.DataSource = dt;
            }
        }

        private void frm_inventario_Load(object sender, EventArgs e)
        {
            DataTable dt = produtos_DAL.mostrarProdutosAll();
            dataGridView_produto.DataSource = dt;
        }

        private void button_busca_Click(object sender, EventArgs e)
        {
            DataTable dt = produtos_DAL.mostrarProdutosAll();
            dataGridView_produto.DataSource = dt;
        }

        private void frm_inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
