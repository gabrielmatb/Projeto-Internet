using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.MODEL
{
    public class Rede
    {
        public int id { get; set; }
        public string ip { get; set; }
        public string gateway { get; set; }
        public string mascara { get; set; }
        public float valor { get; set; }
        public int situacao { get; set; }

    }
}
