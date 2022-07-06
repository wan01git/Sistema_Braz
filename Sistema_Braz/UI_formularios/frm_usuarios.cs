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
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        user_BLL bll = new user_BLL();
        user_DAL dal = new user_DAL();
        DataGridView dvgusuario = new DataGridView();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bll.nome = textBox_nome.Text;
            bll.sobrenome = textBox_sobrenome.Text;
            bll.email = textBox_email.Text;
            bll.usuario= textBox_nick.Text;
            bll.senha= textBox_senha.Text;
            bll.contato= textBox_contato.Text;
            bll.adm = comboBox_adm.Text;
            bll.data_add= DateTime.Now;
            bll.user_add = 1;

            bool sucesso = dal.Insert(bll);
            if (sucesso == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                limpar();
            }
                
            else
                MessageBox.Show("Não foi possivel realizar o cadastro!");
            DataTable dt = dal.select();
            dataGridView_usuarios.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bll.id =Convert.ToInt16(textBox_id.Text);
            bll.nome= textBox_nome.Text;
            bll.sobrenome= textBox_sobrenome.Text;
            bll.email= textBox_email.Text;
            bll.usuario = textBox_nick.Text;
            bll.senha = textBox_senha.Text;
            bll.contato = textBox_contato.Text;
            bll.adm= comboBox_adm.Text;
            bll.user_add= 1;
            bll.data_add = DateTime.Now;

            bool sucesso = dal.update(bll);
            if (sucesso == true)
            {
                MessageBox.Show("Cadastro atualizado com sucesso!");
                limpar();
            }

            else
                MessageBox.Show("Não foi possivel realizar atualização do usuario!");
            DataTable dt = dal.select();
            dataGridView_usuarios.DataSource = dt;
        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            dataGridView_usuarios.DataSource = dt;
        }
        public void limpar()
        {
            textBox_nome.Text = " ";
            textBox_sobrenome.Text = " ";
            textBox_email.Text = " ";
            textBox_nick.Text = " ";
            textBox_senha.Text = " ";
            textBox_contato.Text = " ";
            comboBox_adm.Text = " ";
        }

        private void dataGridView_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_usuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox_id.Text = dataGridView_usuarios.Rows[rowIndex].Cells[0].Value.ToString();
            textBox_nome.Text = dataGridView_usuarios.Rows[rowIndex].Cells[1].Value.ToString();
            textBox_sobrenome.Text = dataGridView_usuarios.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_email.Text = dataGridView_usuarios.Rows[rowIndex].Cells[3].Value.ToString();
            textBox_nick.Text = dataGridView_usuarios.Rows[rowIndex].Cells[4].Value.ToString();
            textBox_senha.Text = dataGridView_usuarios.Rows[rowIndex].Cells[5].Value.ToString();
            textBox_contato.Text = dataGridView_usuarios.Rows[rowIndex].Cells[6].Value.ToString();
            comboBox_adm.Text = dataGridView_usuarios.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {   
            DialogResult opcao = new DialogResult();
            opcao = MessageBox.Show("Tem certeza que deseja deletar usuário?", "Atenção!",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (opcao == DialogResult.OK)
            {
                bll.id = Convert.ToInt16(textBox_id.Text);
                bool sucesso = dal.delete(bll);
                if (sucesso == true)
                {
                    MessageBox.Show("Cadastro deletado com sucesso!");
                    limpar();
                }

                else
                    MessageBox.Show("Não foi possivel deletar usuario!");
                DataTable dt = dal.select();
                dataGridView_usuarios.DataSource = dt;
            }
            
        }

        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox_pesquisar.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_usuarios.DataSource = dt;
            }

            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dataGridView_usuarios.DataSource = dt;
            }
               

        }

        private void frm_usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
