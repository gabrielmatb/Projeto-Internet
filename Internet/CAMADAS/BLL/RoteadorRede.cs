using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.CAMADAS.BLL
{
    public class RoteadorRede
    {
        public List<MODEL.RoteadorRede> Select()
        {
            DAL.RoteadorRede dalRoteadorRede = new DAL.RoteadorRede();
            return dalRoteadorRede.Select();
        }

        public void Insert(MODEL.RoteadorRede roteadorRede)
        {
            DAL.RoteadorRede dalRoteadorRede = new DAL.RoteadorRede();

            Rede bllRede = new Rede();
            List<MODEL.Rede> listaRede = bllRede.SelectByID(roteadorRede.redeID);
            MODEL.Rede rede = listaRede[0];

            if (rede.situacao == 1)
            {
                rede.situacao = 2;
            }

            bllRede.Update(rede);
            dalRoteadorRede.Insert(roteadorRede);
        }

        public void Update(MODEL.RoteadorRede roteadorRede)
        {
            DAL.RoteadorRede dalRoteadorRede = new DAL.RoteadorRede();
            dalRoteadorRede.Update(roteadorRede);
        }

        public void Delete(int idRoteadorRede)
        {
            DAL.RoteadorRede dalRoteadorRede = new DAL.RoteadorRede();
            dalRoteadorRede.Delete(idRoteadorRede);
        }

        public void Devolver(MODEL.RoteadorRede roteadorRede)
        {
            DAL.RoteadorRede dalRoteadorRede = new DAL.RoteadorRede();
            _ = new DAL.RoteadorRede();

            BLL.Rede bllRede = new BLL.Rede();

            List<MODEL.Rede> listaRede = bllRede.SelectByID(roteadorRede.redeID);
            MODEL.Rede rede = listaRede[0];

            if (rede.situacao == 2)
            {
                rede.situacao = 1;
            }
            bllRede.Update(rede);

            roteadorRede.dataFim = DateTime.Now;
            Update(roteadorRede);

            //Delete(clienteRoteador);
        }
    }
}
