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
    public partial class frm_transacao : Form
    {
        public frm_transacao()
        {
            InitializeComponent();
        }
        Transacao_DAL transacaoDAL = new Transacao_DAL();
        private void label_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void frm_transacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void frm_transacao_Load(object sender, EventArgs e)
        {
            DataTable dt = transacaoDAL.mostrarTransacao();
            dataGridView_transacao.DataSource = dt;
            
        }

        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = transacaoDAL.mostrarTransacaoPorData(textBox_pesquisar.Text);
            dataGridView_transacao.DataSource = dt;
        }
    }
}
