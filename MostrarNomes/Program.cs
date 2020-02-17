using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MostrarNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nomes = new ArrayList();
            string entrada, salario;

            do
            {
                Console.WriteLine("Digite um nome");
                entrada = Console.ReadLine();
                Console.WriteLine("Digite o salário ou sair");
                salario = Console.ReadLine();

                if  (entrada == "sair") 
                { 
                    break; 
                }
                else 
                {
                    nomes.Add(entrada);
                    nomes.Add(salario);
                }                  
            }while (true);

            foreach (Object obj in nomes)
            {
                Console.WriteLine("{0}", obj);
            }               

            Console.ReadKey();
        }
    }
}
