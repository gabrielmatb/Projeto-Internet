using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.MODEL
{
    public class ClienteRoteador
    {

        public int id { get; set; }
        public int clienteID { get; set; }
        public int roteadorID { get; set; }
        public string cliente { get; set; }
        public string roteador { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }

    }
}
