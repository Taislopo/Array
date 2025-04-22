using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] clientes = {"maria", "jose", "cleiton"} ;
            int[] idades = { 19, 15, 35 };

            Console.WriteLine(" Nome do Cliente: " + clientes[0]);
            Console.WriteLine(" Idade do Cliente: " + idades[0]);

            clientes[1] = "JOSÉ";

            Console.WriteLine(" Nome do Cliente: " + clientes[1]);
            Console.WriteLine(" Idade do Cliente: " + idades[1]);

            Console.WriteLine(" Total de clientes: " + clientes.Length);


            Console.WriteLine("LISTAGEM DE CLIENTES");
            Console.WriteLine("ID\tNome\t\tIdade");
            
            
            
            for (int i = 0; i < clientes.Length; i++) 
            {

                Console.Write(i);
                Console.Write("\t");
                Console.Write(clientes[i]);
                Console.Write("\t\t");
                Console.WriteLine(idades[i]);

            }

        }
    }
}
