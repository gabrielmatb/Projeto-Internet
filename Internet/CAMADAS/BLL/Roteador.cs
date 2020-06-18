using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.BLL
{
    public class Roteador
    {
        public List<MODEL.Roteador> Select()
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            return dalRoteador.Select();
        }

        public List<MODEL.Roteador> SelectByID(int id)
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            return dalRoteador.SelectByID(id);
        }

        public List<MODEL.Roteador> SelectByNome(string nome)
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            return dalRoteador.SelectbyNome(nome);
        }

        public void Insert (MODEL.Roteador roteador)
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            dalRoteador.Insert(roteador);
        }

        public void Update (MODEL.Roteador roteador)
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            dalRoteador.Update(roteador);
        }

        public void Delete (int idRotedor)
        {
            DAL.Roteador dalRoteador = new DAL.Roteador();
            dalRoteador.Delete(idRotedor);
        }
    }
}
