using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] pokemom = {"Pikachu  ","Charmander","Lapras   ","Charizad","Sandslash","Vulpix  ","Growlithe","Marowak  ","Cyndaquil","Umbreon  " };
            string[]    tipo = {"Eletri","Fogo","Água","Fogo","Ground","Fogo","Fogo","Ground","Fogo","Dark"};
            string[] tamanho = {"0.4 m", "0.6 m", "2.5 m", "1.7 m", "1.0 m", "0.6 m", "0.7 m", "1.0 m", "0.5 m", "1.0 m"};
            string[]    peso = {"6.0 kg", "8.5 kg", "220.0 kg", "90.5 kg", "29.5 kg", "9.9 kg", "19.0 kg", "45.0 kg", "7.9 kg", "27.0 kg"};
          


            Console.WriteLine(" POKEMONS DA MINHA POKEDEX");

            Console.Write("NOME DO POKEMOM" );
            Console.Write("\t\t");
            Console.Write("TIPO DE ELEMENTO" );
            Console.Write("\t");
            Console.Write("TAMANHO DO POKEMOM") ;
            Console.Write("\t");
            Console.WriteLine("PESO DO POKEMOM");


            for (int i = 0; i < pokemom.Length; i++)
            {
               
                Console.Write(pokemom[i]);
                Console.Write("\t\t");
                Console.Write(tipo[i]);
                Console.Write("\t\t\t");
                Console.Write(tamanho[i]);
                Console.Write("\t\t\t\t");
                Console.WriteLine(peso[i]);




            }




















        }
    }
}
