using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSâmelaSara
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaMercado = new List<string>();
            string opcao = "1";
            while (opcao == "1")
            {
                Console.WriteLine("Digite o que deseja adicionar à lista.");
                string produtodesejado = Console.ReadLine();
                listaMercado.Add(produtodesejado);
                Console.WriteLine("Deseja inserir algo em sua lista? Se SIM digite [1], caso não queira digite[2]");
                opcao = Console.ReadLine();

            }

            listaMercado.Sort();
            Console.WriteLine(" Sua lista de compra contém " + listaMercado.Count + " intens");

            for (int i = 0; i < listaMercado.Count; i++)
            {
                Console.WriteLine(listaMercado[i]);
            }
            {
                Console.WriteLine(" Deseja remover algo? Sim[3] Não [4].");
                opcao = Console.ReadLine();
                if (opcao == "3")
                {
                    Console.WriteLine("Qual dos produtos deseja retirar?");
                    string produtodesejado = Console.ReadLine();
                    listaMercado.Remove(produtodesejado);
                    Console.WriteLine("O produtos foi retirar");
                    { }
                }
                else
                {
                    listaMercado.Sort();
                    {
                        Console.WriteLine(" Sua lista de compra contém " + listaMercado.Count + " intens");
                    }

                    for
                        (int i = 0; i < listaMercado.Count; i++)
                    {
                        Console.WriteLine(listaMercado[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

    






