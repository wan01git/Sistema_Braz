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
    internal class Transacao_DAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings
           ["Sistema_Braz.Properties.Settings.sistema_brazConnectionString"].ConnectionString;
        #region insert transação   
        public bool Insert(Transacao_BLL t,out int transacao_id)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            transacao_id = -1;
            try
            {
                string sql = "INSERT INTO Table_transacao2(tipo,id_cliente,total,data_trasacao,imposto,desconto,data_add,user_add)" +
                    " VALUES (@tipo,@id_cliente,@total,@data_trasacao,@imposto,@desconto,@data_add,@user_add);SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@tipo", t.tipo);
                cmd.Parameters.AddWithValue("@id_cliente", t.cliente_id);
                cmd.Parameters.AddWithValue("@total", t.total);
                cmd.Parameters.AddWithValue("@data_trasacao",t.data_transacao);
                cmd.Parameters.AddWithValue("@imposto", t.imposto);
                cmd.Parameters.AddWithValue("@desconto", t.desconto);
                cmd.Parameters.AddWithValue("@data_add", t.data_add); 
                cmd.Parameters.AddWithValue("@user_add", t.user_add);

                conexao.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    transacao_id = int.Parse(o.ToString());
                    isSucesso = true;
                }
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
        public DataTable mostrarTransacao()
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * FROM Table_transacao2";
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


        public DataTable mostrarTransacaoPorData(string data)
        {
            SqlConnection conexao = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * FROM Table_transacao2 where data_transacao= '"+data+"'";
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
