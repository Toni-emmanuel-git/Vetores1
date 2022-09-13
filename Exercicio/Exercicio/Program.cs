using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] aluguel = new Aluguel[10];

            Console.WriteLine("Combien de chambres seront louées ? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                Console.WriteLine();
                Console.WriteLine("Name: ");
                string Nom = Console.ReadLine();

                Console.WriteLine("Email: ");
                string Em = Console.ReadLine();  

                Console.WriteLine("Room: ");
                int chambres = int.Parse(Console.ReadLine());

                aluguel[chambres] = new Aluguel(Nom, Em); 
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            
            for (int i = 0; i < 10; i++ ) {
                if (aluguel[i] != null) {
                    Console.WriteLine(i + ": " + aluguel[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
