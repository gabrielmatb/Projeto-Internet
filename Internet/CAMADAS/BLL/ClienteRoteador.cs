using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet.CAMADAS.BLL
{
    public class ClienteRoteador
    {
        public List<MODEL.ClienteRoteador> Select()
        {
            DAL.ClienteRoteador dalClienteRoteador = new DAL.ClienteRoteador();
            return dalClienteRoteador.Select();
        }

        public void Insert(MODEL.ClienteRoteador clienteRoteador)
        {
            DAL.ClienteRoteador dalClienteRoteador = new DAL.ClienteRoteador();
            //dalClienteRoteador.Insert(clienteRoteador);
            Roteador bllRoteador = new Roteador();
            List <MODEL.Roteador> listaRoteador = bllRoteador.SelectByID(clienteRoteador.roteadorID);
            MODEL.Roteador roteador = listaRoteador[0];
            //Console.WriteLine("Situação: " + roteador.situacao);
            if (roteador.situacao == 1)
            {
                roteador.situacao = 2;
            }
            //Console.WriteLine("Situação2: " + roteador.situacao);
            bllRoteador.Update(roteador);
            dalClienteRoteador.Insert(clienteRoteador);
        }

        public void Update(MODEL.ClienteRoteador clienteRoteador)
        {
            DAL.ClienteRoteador dalClienteRoteador = new DAL.ClienteRoteador();
            dalClienteRoteador.Update(clienteRoteador);
        }

        public void Delete(int idClienteRoteador)
        {
            DAL.ClienteRoteador dalClienteRoteador = new DAL.ClienteRoteador();
            dalClienteRoteador.Delete(idClienteRoteador);
        }

        public void Devolver(MODEL.ClienteRoteador clienteRoteador)
        {
            DAL.ClienteRoteador dalClienteRoteador = new DAL.ClienteRoteador();
            _ = new DAL.ClienteRoteador();

            BLL.Roteador bllRoteador = new BLL.Roteador();

            List<MODEL.Roteador> listaRoteador = bllRoteador.SelectByID(clienteRoteador.roteadorID);
            MODEL.Roteador roteador = listaRoteador[0];

            if(roteador.situacao == 2)
            {
                roteador.situacao = 1;
            }
            bllRoteador.Update(roteador);

            clienteRoteador.dataFim = DateTime.Now;
            Update(clienteRoteador);

            //Delete(clienteRoteador);
        }
    }
}
