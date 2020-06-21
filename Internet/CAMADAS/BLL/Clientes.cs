using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            return dalClientes.Select();
        }

        public MODEL.Clientes SelectByID(int id)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            return dalClientes.SelectByID(id);
        }

        public List<MODEL.Clientes> SelectByNome(string nome)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            return dalClientes.SelectbyNome(nome);
        }

        public void Insert (MODEL.Clientes cliente)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            dalClientes.Insert(cliente);
        }

        public void Update (MODEL.Clientes cliente)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            dalClientes.Update(cliente);
        }

        public void Delete (int idCliente)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            dalClientes.Delete(idCliente);
        }
    }
}
