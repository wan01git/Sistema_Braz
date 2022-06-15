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
    internal class categorias_DAL
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
                string sql = "Select * from Table_categoria2";
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
        public bool Insert(categorias_BLL c)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Table_categoria2(titulo,descricao,data_add,user_add)" +
                    " VALUES (@titulo,@descricao,@data_add,@user_add)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@titulo", c.titulo);
                cmd.Parameters.AddWithValue("@descricao", c.descricao);
                cmd.Parameters.AddWithValue("@data_add", c.data_add);
                cmd.Parameters.AddWithValue("@user_add", c.user_add);

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
        public bool update(categorias_BLL c)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Table_categoria2 SET titulo=@titulo,descricao=@descricao,data_add=@data_add,user_add=@user_add where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@titulo", c.titulo);
                cmd.Parameters.AddWithValue("@descricao",c.descricao);
                cmd.Parameters.AddWithValue("@data_add", c.data_add);
                cmd.Parameters.AddWithValue("@user_add", c.user_add);

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
        public bool delete(categorias_BLL c)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM Table_categoria2 WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", c.id);

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
                string sql = "Select * from Table_categoria2 WHERE id LIKE '%" + keywords + "%' or titulo LIKE '%" + keywords + "%' or descricao LIKE '%" + keywords + "%'";
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
        #region GeT_ID
        public categorias_BLL GETID_cat(string nome)
        {
            categorias_BLL bll = new categorias_BLL();
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id from Table_categoria2 where titulo= '" + nome + "' ";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
                if (dt.Rows.Count > 0)
                    bll.id = int.Parse(dt.Rows[0]["id"].ToString());
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            return bll;

        }
        #endregion
    }
}
