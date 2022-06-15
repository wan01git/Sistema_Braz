using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Braz.BLL_Classes
{
    internal class user_BLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string contato { get; set; }
        public string adm { get; set; }
        public DateTime data_add { get; set; }
        public int user_add { get; set; }
    }
}
