using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Numerics;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Formats;
using Config;

namespace Cotacao
{


    class Programa
    {

        static async Task RunAsync(string acao, Double Preco_Venda, Double Preco_Compra)
        {

            using (HttpClient client = new HttpClient())
            {

                string ticker = acao;


                try
                {

                    var response = client.GetAsync("https://brapi.dev/api/quote/" + ticker + "?token=unSqMAUK1Ab2xtcz72LciK").Result;


                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("\r\nO programa está em execução ! \r\n\r\nPara finalizar a aplicação é necessário fechar a janela ! \r\n\r\nBons Negócios!");

                        while (true)
                        {
                            var resultado = response.Content.ReadAsStringAsync().Result;
                            Rootobject resposta = JsonConvert.DeserializeObject<Rootobject>(resultado);


                            double Preço_ultimo = resposta.results[0].regularMarketPrice;
                            string ativo = resposta.results[0].symbol;

                            double Minimo = Math.Round(resposta.results[0].regularMarketDayLow, 2);
                            double Maximo = Math.Round(resposta.results[0].regularMarketDayHigh, 2);
                            double Preco_Ultimo = Math.Round(resposta.results[0].regularMarketPrice, 2);
                            string Horario_atualização = resposta.results[0].regularMarketTime;

                            if (resposta.results[0].regularMarketPrice >= Preco_Venda)
                            {

                                //Configura o corpo do e-mail
                                string texto = "Hora de vender o Ativo! \r\n \r\n" + ticker + " atingiu a cotação MÁXIMA configurada (R$ " + Preco_Venda + ").\r\n\r\n" +
                                    "Preço Último: R$" + Preco_Ultimo + "\r\n" +
                                    "Preço Máximo no dia: R$" + Maximo + "\r\n" +
                                    "Preço Mínimo no dia: R$" + Minimo + "\r\n\r\n" +
                                    "Bons Negócios! \r\n\r\n" +
                                    "Cotação Atualizada às " + Horario_atualização + "\r\n \r\n";


                                MailConfig mailConfig = new MailConfig();
                                mailConfig.DisparaMail(texto, "Preço máximo atingido");

                                Console.WriteLine("\r\nO ativo: " + ticker + " atingiu a cotação MÁXIMA configurada ! \r\nE-mail enviado! \r\n***");

                            }
                            else if (resposta.results[0].regularMarketPrice <= Preco_Compra)
                            {
                                //Configura o corpo do e-mail
                                string texto = "Hora de comprar o Ativo! \r\n \r\n" + ticker + " atingiu a cotação MÍNIMA configurada (R$ " + Preco_Compra + ").\r\n\r\n" +
                                    "Preço Último: R$" + Preco_Ultimo + "\r\n" +
                                    "Preço Máximo no dia: R$" + Maximo + "\r\n" +
                                    "Preço Mínimo no dia: R$" + Minimo + "\r\n\r\n" +
                                    "Bons Negócios! \r\n\r\n" +
                                    "Cotação Atualizada às " + Horario_atualização + "\r\n \r\n";


                                MailConfig mailConfig = new MailConfig();
                                mailConfig.DisparaMail(texto, "Preço minímo atingido");

                                Console.WriteLine("\r\nO ativo: " + ticker + " atingiu a cotação MÍNIMA configurada ! \r\nE-mail enviado! \r\n***");

                            }
                            else
                            {
                                Console.WriteLine("O ativo não atingiu os Stops configurados");
                            }


                        }


                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }



        }

        public static void Main(string[] args)

        {
            string acao = "PETR4"; //"args[0];
            double Preco_Venda = 37.50; //Convert.ToDouble(args[1]);
            double Preco_Compra = 36.00; //Convert.ToDouble(args[2]);

            RunAsync(acao, Preco_Venda, Preco_Compra).Wait();
            Console.ReadKey();
        }
    }

}