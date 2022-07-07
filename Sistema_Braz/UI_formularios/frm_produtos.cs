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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }
        produtos_BLL bll = new produtos_BLL();
        produtos_DAL dal = new produtos_DAL();
        categorias_DAL cat_dal = new categorias_DAL();
        user_DAL user = new user_DAL();
        private void frm_produtos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            DataTable dt_categoria = cat_dal.select();
            comboBox_categoria.DataSource = dt_categoria;
            comboBox_categoria.DisplayMember = "titulo";
            comboBox_categoria.ValueMember = "titulo";
            DataTable dt = dal.select();
            dataGridView_produtos.DataSource = dt;
        }

        private void button_cadastro_Click(object sender, EventArgs e)
        {
             user_BLL usr = user.GETID_user(frm_login.logado);
              bll.user_add = usr.id;
            categorias_BLL cat = cat_dal.GETID_cat(comboBox_categoria.Text);
            bll.nome = textBox_nome.Text;
            bll.categoria = cat.id;
            bll.descricao = textBox_descricao.Text;
            bll.quantidade = int.Parse(textBox_quantidade.Text);
            bll.avaliacao = decimal.Parse(textBox_avaliacao.Text);
            bll.data_add = DateTime.Now;
            bool sucesso = dal.Insert(bll);
            if (sucesso)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                limpar();
            }
            else
                MessageBox.Show("Produto não pode ser cadastrado");
            DataTable dt = dal.select();
            dataGridView_produtos.DataSource = dt;
        }
        public void limpar()
        {
            textBox_doID.Clear();
            textBox_descricao.Clear();
            textBox_nome.Clear();
            textBox_quantidade.Clear();
            textBox_avaliacao.Clear();

        }

        private void dataGridView_produtos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox_doID.Text = dataGridView_produtos.Rows[rowIndex].Cells[0].Value.ToString();
            textBox_nome.Text = dataGridView_produtos.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox_categoria.Text = dataGridView_produtos.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_descricao.Text = dataGridView_produtos.Rows[rowIndex].Cells[3].Value.ToString();
            textBox_avaliacao.Text = dataGridView_produtos.Rows[rowIndex].Cells[4].Value.ToString();
            textBox_quantidade.Text = dataGridView_produtos.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            bll.id = int.Parse(textBox_doID.Text);
            bll.nome = textBox_nome.Text;
            categorias_BLL cat = cat_dal.GETID_cat(comboBox_categoria.Text);
            bll.categoria = cat.id;
            bll.descricao = textBox_descricao.Text;
            bll.avaliacao = decimal.Parse(textBox_avaliacao.Text);
            bll.quantidade = int.Parse(textBox_quantidade.Text);
            bll.data_add = DateTime.Now;
            user_BLL usr = user.GETID_user(frm_login.logado);
            bll.user_add = usr.id;
            bool sucesso = dal.update(bll);
            if (sucesso == true)
            {
                MessageBox.Show("Cadastro atualizado com sucesso!");
                limpar();
                DataTable dt_categoria = cat_dal.select();
                comboBox_categoria.DataSource = dt_categoria;
            }

            else
                MessageBox.Show("Não foi possivel realizar atualização do usuario!");
            DataTable dt = dal.select();
            dataGridView_produtos.DataSource = dt;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult opcao = new DialogResult();
            opcao = MessageBox.Show("Tem certeza que deseja deletar produto?", "Atenção!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcao == DialogResult.OK)
            {
                bll.id = int.Parse(textBox_doID.Text);
                bool sucesso = dal.delete(bll);
                if (sucesso == true)
                {
                    MessageBox.Show("produto deletado com sucesso!");
                    limpar();
                    DataTable dt_categoria = cat_dal.select();
                    comboBox_categoria.DataSource = dt_categoria;
                }

                else
                    MessageBox.Show("Não foi possivel deletar usuario!");
                DataTable dt = dal.select();
                dataGridView_produtos.DataSource = dt;
            }
        }

        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox_pesquisar.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_produtos.DataSource = dt;
            }

            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_produtos.DataSource = dt;
            }
        }

        private void dataGridView_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
