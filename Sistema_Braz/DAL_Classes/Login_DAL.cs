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
    internal class Login_DAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings
           ["Sistema_Braz.Properties.Settings.sistema_brazConnectionString"].ConnectionString;
        public bool login(Login_BLL login)
        {
            bool isSucesso = false;
            SqlConnection conexao = new SqlConnection(myconnstring);
            try
            {
                string sql = "Select * from Table_usuario WHERE usuario=@usuario and senha=@senha and adm=@adm";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@usuario", login.usuario);
                cmd.Parameters.AddWithValue("@senha", login.senha);
                cmd.Parameters.AddWithValue("@adm", login.adm);
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptar.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso=false;
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
            return isSucesso;
        }


    }
}
