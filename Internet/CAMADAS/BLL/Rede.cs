using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.BLL
{
    public class Rede
    {
        public List<MODEL.Rede> Select()
        {
            DAL.Rede dalRede = new DAL.Rede();
            return dalRede.Select();
        }

        public List<MODEL.Rede> SelectByID(int id)
        {
            DAL.Rede dalRede = new DAL.Rede();
            return dalRede.SelectByID(id);
        }

        public List<MODEL.Rede> SelectByIP(string ip)
        {
            DAL.Rede dalRede = new DAL.Rede();
            return dalRede.SelectbyIP(ip);
        }
        public void Insert(MODEL.Rede rede)
        {
            DAL.Rede dalRede = new DAL.Rede();
            dalRede.Insert(rede);
        }

        public void Update(MODEL.Rede rede)
        {
            DAL.Rede dalRede = new DAL.Rede();
            dalRede.Update(rede);
        }

        public void Delete(int idRede)
        {
            DAL.Rede dalRede = new DAL.Rede();
            dalRede.Delete(idRede);
        }
    }
}
