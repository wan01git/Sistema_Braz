using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Braz.BLL_Classes
{
    internal class Transacao_BLL
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public int cliente_id { get; set; }
        public decimal total { get; set; }
        public DateTime data_transacao { get; set; }
        public decimal imposto { get; set; }
        public decimal desconto { get; set; }
        public DateTime data_add { get; set; }
        public int user_add { get; set; }
    }
}
