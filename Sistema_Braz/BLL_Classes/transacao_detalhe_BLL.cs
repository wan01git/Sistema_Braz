using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Braz.BLL_Classes
{
    internal class transacao_detalhe_BLL
    {
        public int id { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public decimal avaliacao { get; set; }
        public decimal total { get; set; }
        public int cliente_id { get; set; }
        public DateTime data_add { get; set; }
        public int user_add { get; set; }

    }
}
