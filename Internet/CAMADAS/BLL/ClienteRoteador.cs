using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
