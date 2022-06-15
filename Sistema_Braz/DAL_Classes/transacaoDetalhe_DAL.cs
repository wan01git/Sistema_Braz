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
    internal class transacaoDetalhe_DAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings
           ["Sistema_Braz.Properties.Settings.sistema_brazConnectionString"].ConnectionString;
        #region insert transação detalhada  
        public bool Insert(transacao_detalhe_BLL td)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Table_transacao_det(id_produto,quantidade,total,id_cliente,data_add,user_add)" +
                    " VALUES (@id_produto,@quantidade,@total,@id_cliente,@data_add,@user_add)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id_produto", td.id_produto);
                cmd.Parameters.AddWithValue("@quantidade", td.quantidade);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@id_cliente", td.cliente_id);
                cmd.Parameters.AddWithValue("@data_add", td.data_add);
                cmd.Parameters.AddWithValue("@user_add", td.user_add);

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
    }
}
