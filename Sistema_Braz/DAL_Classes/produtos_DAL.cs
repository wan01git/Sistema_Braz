using Sistema_Braz.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Braz.DAL_Classes
{
    internal class produtos_DAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings
           ["Sistema_Braz.Properties.Settings.sistema_brazConnectionString"].ConnectionString;
        #region Selecionar Categorias
        public DataTable select()
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from Table_produto";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();
            }
            return dt;
        }
        #endregion
        #region Inserir categoria
        public bool Insert(produtos_BLL p)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Table_produto(nome,categoria,descricao,avaliacao,quantidade,data_add,user_add)" +
                    " VALUES (@nome,@categoria,@descricao,@avaliacao,@quantidade,@data_add,@user_add)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                cmd.Parameters.AddWithValue("@data_add", p.data_add);
                cmd.Parameters.AddWithValue("@user_add", p.user_add);

                conexao.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSucesso = true;
                else
                    isSucesso = false;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return isSucesso;
        }
        #endregion
        #region Atulizar categoria
        public bool update(produtos_BLL p)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {

                string sql = "UPDATE Table_produto SET nome=@nome,categoria=@categoria,descricao=@descricao,avaliacao=@avaliacao,quantidade=@quantidade,data_add=@data_add,user_add=@user_add where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", p.id);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                cmd.Parameters.AddWithValue("@data_add", p.data_add);
                cmd.Parameters.AddWithValue("@user_add", p.user_add);

                conexao.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSucesso = true;
                else
                    isSucesso = false;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return isSucesso;
        }
        #endregion
        #region Deletar categoria
        public bool delete(produtos_BLL p)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM Table_produto WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", p.id);

                conexao.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSucesso = true;
                else
                    isSucesso = false;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return isSucesso;
        }
        #endregion
        #region Pesquisar Categoria
        public DataTable Pesquisar(string keywords)
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from Table_produto WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or categoria LIKE '%" + keywords + "%'or descricao LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dt;

        }
        #endregion
        #region Pesquisar Categoria transação
        public produtos_BLL Pesquisar_produto_transacao(string keywords)
        {
            produtos_BLL produtos_BLL = new produtos_BLL();
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select id from Table_produto WHERE  nome= '" + keywords + "'";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    produtos_BLL.id = int.Parse(dt.Rows[0]["ID"].ToString());
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            return produtos_BLL;
        }
        #endregion
        public produtos_BLL Pesquisar_produto(string keywords)
        {
            produtos_BLL produtos_BLL = new produtos_BLL();
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select nome,avaliacao,quantidade from Table_produto WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or categoria LIKE '%" + keywords + "%'or descricao LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    produtos_BLL.nome = dt.Rows[0]["nome"].ToString();
                    produtos_BLL.avaliacao = decimal.Parse(dt.Rows[0]["avaliacao"].ToString());
                    produtos_BLL.quantidade = int.Parse(dt.Rows[0]["quantidade"].ToString());
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            return produtos_BLL;
        }
        public int GetProdutoQtd(int id_produto)
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            int quantidade = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "select quantidade FROM Table_produto WHERE id="+id_produto;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conexao.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    quantidade = int.Parse(dt.Rows[0]["quantidade"].ToString());
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return quantidade;
        }

        public bool updateQtd(int id_produto, int quantidade)
        {
            bool sucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
         
            try
            {
                string sql = "update Table_produto set quantidade=@quantidade WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@id", id_produto);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conexao.Open(); 
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    sucesso = true;
                else
                    sucesso = false;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return sucesso;
        }



        public bool removeProduto(int id_produto, int quantidade)
        {
            bool sucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);

            try
            {
                int correnteQtd = GetProdutoQtd(id_produto);
                int novaQtd = correnteQtd - quantidade;
                sucesso = updateQtd(id_produto, novaQtd);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();

            }
            return sucesso;
        }

        public DataTable mostrarProdutosAll()
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * FROM Table_produto";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }
    }
}
