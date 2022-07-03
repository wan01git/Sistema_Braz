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
    internal class user_DAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings
            ["Sistema_Braz.Properties.Settings.sistema_brazConnectionString"].ConnectionString;

        #region Selecionar dados do banco de dados
        public DataTable select()
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from Table_usuario";
                SqlCommand  cmd = new SqlCommand(sql, conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                conexao.Open();
                adaptar.Fill(dt);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally{
                conexao.Close();
            }
            return dt;

        }
        #endregion
        #region Cadastro de dados no banco de dados
        public bool Insert(user_BLL u)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Table_usuario(nome,sobrenome,email,usuario,senha,contato,adm,data_add,user_add)" +
                    " VALUES (@nome,@sobrenome,@email,@usuario,@senha,@contato,@adm,@data_add,@user_add)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@adm", u.adm);
                cmd.Parameters.AddWithValue("@data_add", u.data_add);
                cmd.Parameters.AddWithValue("@user_add", u.user_add);

                conexao.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
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
        #region Atualizar dados no banco de dados
        public bool update(user_BLL u)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Table_usuario SET nome=@nome,sobrenome=@sobrenome,email=@email,usuario=@usuario," +
                    "senha=@senha,contato=@contato,adm=@adm,data_add=@data_add,user_add=@user_add WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@adm", u.adm);
                cmd.Parameters.AddWithValue("@data_add", u.data_add);
                cmd.Parameters.AddWithValue("@user_add", u.user_add);
                cmd.Parameters.AddWithValue("@id", u.id);

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
        #region Deletar usuario no banco de dados
        public bool delete(user_BLL u)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM Table_usuario WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", u.id);

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
        #region Pesquisar
        public DataTable Pesquisar (string keywords)
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from Table_usuario WHERE id LIKE '%" + keywords+"%' or nome LIKE '%"+keywords+"%'";
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
        public user_BLL GETID_user(string nome)
        {
            user_BLL bll = new user_BLL();
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id from Table_usuario WHERE nome= '"+nome +"'";
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
