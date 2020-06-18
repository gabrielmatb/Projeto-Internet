using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.RELATORIOS
{
    public class relatorioClienteRoteador
    {
        public static void relClienteRoteador()
        {
            CAMADAS.BLL.ClienteRoteador bllClienteRoteador = new CAMADAS.BLL.ClienteRoteador();
            List<CAMADAS.MODEL.ClienteRoteador> listaClienteRoteador = new List<CAMADAS.MODEL.ClienteRoteador>();
            listaClienteRoteador = bllClienteRoteador.Select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelatorioClienteRoteador.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html lang='pt-br'>");
                sw.WriteLine("<head>");

                sw.WriteLine("<meta charset='UTF - 8'>");
                sw.WriteLine("<meta name='viewport' content='width = device - width, initial - scale = 1.0'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("<title>Relatorio Cliente - Roteador</title>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body style = 'background-color:black'>");
                sw.WriteLine("<div style = 'color:white'");
                sw.WriteLine("<br><hr border='5px' />");
                sw.WriteLine("<h1> Relatório de Cliente/Roteador </h1>");
                sw.WriteLine("<hr border='5px' /><br>");
                sw.WriteLine("</div>");
                sw.WriteLine("<table class='table table-striped table-dark'>");

                //sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr align='center'>");

                sw.WriteLine("<th>ID</th>");
                sw.WriteLine("<th>Cliente</th>");
                sw.WriteLine("<th>Roteador</th>");
                sw.WriteLine("<th>Data Inicio</th>");
                sw.WriteLine("<th>Data Fim</th>");

                int contador = 0;
                foreach (CAMADAS.MODEL.ClienteRoteador clienteRoteador in listaClienteRoteador)
                {
                    sw.WriteLine("<tr align='center'>");

                    sw.WriteLine("<th>" + clienteRoteador.id + "</th>");
                    sw.WriteLine("<td>" + clienteRoteador.clienteID + "</td>");
                    sw.WriteLine("<td>" + clienteRoteador.roteadorID + "</td>");
                    sw.WriteLine("<td>" + clienteRoteador.dataInicio + "</td>");
                    sw.WriteLine("<td>" + clienteRoteador.dataFim + "</td>");

                    sw.WriteLine("</tr>");

                    contador++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<div style = 'color:white'>");
                sw.WriteLine("<h5> Quantidade de Itens na Movimentação: " + contador + "</h5>");
                sw.WriteLine("</div>");
                sw.WriteLine("");

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
                //sw.WriteLine("</thead class='thead-dark'>");
                sw.WriteLine("</tr>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
