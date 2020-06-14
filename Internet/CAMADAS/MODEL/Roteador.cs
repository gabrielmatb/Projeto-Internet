using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.MODEL
{
    public class Roteador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string mac { get; set; }
        public int situacao { get; set; }

    }
}
