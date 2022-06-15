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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }
        categorias_BLL bll = new categorias_BLL();
        categorias_DAL dal = new categorias_DAL();
        user_DAL user = new user_DAL();
        private void label_nome_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void button_cadastro_Click(object sender, EventArgs e)
        {
            bll.titulo = textBox_titulo.Text;
            bll.descricao = textBox_descricao.Text;
            bll.data_add = DateTime.Now;        
            user_BLL usr = user.GETID_user(frm_login.logado);
            bll.user_add = usr.id;

            bool sucesso = dal.Insert(bll);
            if (sucesso)
            {
                MessageBox.Show("Categoria cadastrada com sucesso");
                textBox_descricao.Clear();
                textBox_id.Clear();
                textBox_titulo.Clear();
            }
                

            else
                MessageBox.Show("Não foi possivel cadastrar a categoria!");
            DataTable dt = dal.select();
            dataGridView_categorias.DataSource = dt;
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            dataGridView_categorias.DataSource = dt;
        }

        private void dataGridView_categorias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox_id.Text = dataGridView_categorias.Rows[rowIndex].Cells[0].Value.ToString();
            textBox_titulo.Text = dataGridView_categorias.Rows[rowIndex].Cells[1].Value.ToString();
            textBox_descricao.Text = dataGridView_categorias.Rows[rowIndex].Cells[2].Value.ToString();
            
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            bll.id = int.Parse(textBox_id.Text);
            bll.titulo = textBox_titulo.Text;
            bll.descricao = textBox_descricao.Text;
            bll.data_add = DateTime.Now;
            user_BLL usr = user.GETID_user(frm_login.logado);
            bll.user_add = usr.id;

            bool sucesso = dal.update(bll);
            if (sucesso == true)
            {
                MessageBox.Show("Cadastro atualizado com sucesso!");
                textBox_descricao.Clear();
                textBox_id.Clear();
                textBox_titulo.Clear();
            }

            else
                MessageBox.Show("Não foi possivel realizar atualização do usuario!");
            DataTable dt = dal.select();
            dataGridView_categorias.DataSource = dt;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult opcao = new DialogResult();
            opcao = MessageBox.Show("Tem certeza que deseja deletar categoria?", "Atenção!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcao == DialogResult.OK)
            {
                bll.id = int.Parse(textBox_id.Text);
                bool sucesso = dal.delete(bll);
                if (sucesso == true)
                {
                    MessageBox.Show("Categoria deletado com sucesso!");
                    textBox_descricao.Clear();
                    textBox_id.Clear();
                    textBox_titulo.Clear();
                }

                else
                    MessageBox.Show("Não foi possivel deletar usuario!");
                DataTable dt = dal.select();
                dataGridView_categorias.DataSource = dt;
            }
        }

        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_pesquisar_TextChanged_1(object sender, EventArgs e)
        {
            string keywords = textBox_pesquisar.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_categorias.DataSource = dt;
            }

            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_categorias.DataSource = dt;
            }
        }

        private void dataGridView_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
