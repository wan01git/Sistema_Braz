using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Braz.BLL_Classes
{
    internal class produtos_BLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int categoria { get; set; }
        public string descricao { get; set; }   
        public decimal avaliacao { get; set; }
        public int quantidade { get; set; }
        public DateTime data_add { get; set; }
        public int user_add { get; set; }

    }
}
