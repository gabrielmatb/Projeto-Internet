using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.RELATORIOS
{
    public class relatorioRoteadorRede
    {
        public static void relRoteadorRede()
        {
            CAMADAS.BLL.RoteadorRede bllRoteadorRede = new CAMADAS.BLL.RoteadorRede();
            List<CAMADAS.MODEL.RoteadorRede> listaRoteadorRede = new List<CAMADAS.MODEL.RoteadorRede>();
            listaRoteadorRede = bllRoteadorRede.Select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelatorioRoteadorRede.html";
            string arquivopdf = pasta + @"\RelatorioRoteadorRede.pdf";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html lang='pt-br'>");
                sw.WriteLine("<head>");

                sw.WriteLine("<meta http-equiv = 'Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<meta name='viewport' content='width = device - width, initial - scale = 1.0'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("<title>Relatorio Roteador - Rede</title>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body style = 'background-color:black'>");
                sw.WriteLine("<div style = 'color:white'");
                sw.WriteLine("<br><hr border='5px' />");
                sw.WriteLine("<h2> Relatório de Roteador/Rede </h2>");
                sw.WriteLine("<hr border='5px' /><br>");
                sw.WriteLine("</div>");
                sw.WriteLine("<table class='table table-striped table-dark'>");

                //sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr align='center'>");

                sw.WriteLine("<th>ID</th>");
                sw.WriteLine("<th>Roteador</th>");
                sw.WriteLine("<th>Rede</th>");
                sw.WriteLine("<th>Data Inicio</th>");
                sw.WriteLine("<th>Data Fim</th>");

                int contador = 0;
                foreach (CAMADAS.MODEL.RoteadorRede roteadorRede in listaRoteadorRede)
                {
                    sw.WriteLine("<tr align='center'>");

                    sw.WriteLine("<th>" + roteadorRede.id + "</th>");
                    sw.WriteLine("<td>" + roteadorRede.roteador + "</td>");
                    sw.WriteLine("<td>" + roteadorRede.rede + "</td>");
                    sw.WriteLine("<td>" + roteadorRede.dataInicio + "</td>");
                    sw.WriteLine("<td>" + roteadorRede.dataFim + "</td>");

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

            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.CustomWkHtmlArgs = "--dpi 300";
            htmlToPdf.GeneratePdfFromFile(arquivo, null, arquivopdf);
        }
    }
}
