using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.MODEL
{
    public class RoteadorRede
    {
        public int id { get; set; }
        public int roteadorID { get; set; }
        public int redeID { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }

    }
}
