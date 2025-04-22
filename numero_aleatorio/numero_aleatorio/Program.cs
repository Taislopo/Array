using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace numero_aleatorio
{
    internal class Program
    {
        public class Ficha
        {   //propriedade

            public string nomeDoJogador;
            public string nomeDopersonagem;
            public string raca;
            public string classe;
            public int vida;

            public void ImprimirFicha()
            {
                Console.WriteLine("\n");
                Console.WriteLine(" ╔══════ FICHA DO PERSONAGEM ══════╗ ");
                Console.WriteLine("  Nome do personagem: " + nomeDopersonagem);
                Console.WriteLine("  Raça: " + raca);
                Console.WriteLine("  Classe: " + classe);
                Console.WriteLine("  Vida: " + vida);
                Console.WriteLine(" ╚═════════════════════════════════╝");
                Console.WriteLine("\n");
            }



        }

        static void Main(string[] args)
        {



            Random random = new Random();
            int d6Jogador = 0;
            int d6inimigo = 0;

            Ficha personagemPrincipal = new Ficha(); // instanciar novo objeto
            personagemPrincipal.nomeDoJogador = "Guto";
            personagemPrincipal.nomeDopersonagem = "Aldir";
            personagemPrincipal.raca = "Elfo";
            personagemPrincipal.classe = "Guerreiro";
            personagemPrincipal.vida = 100;


            Console.WriteLine(" ====== AVENTURA COMEÇA ======  ");
            personagemPrincipal.ImprimirFicha();
            Console.WriteLine(" Você está bebendo em uma taverna. ");
            Console.WriteLine(" Uma pessoa esbarra em você. O que você faz?\n[1] se vira\n[2] continua como se nada fosse ");
            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.WriteLine("======= Agora começa a Batalha !!! ========");
                Ficha inimigo = new Ficha();
                inimigo.nomeDoJogador = "NPC";
                inimigo.nomeDopersonagem = "Baltazar";
                inimigo.raca = "ORC";
                inimigo.classe = "Ladrão";
                inimigo.vida = 50;
                inimigo.ImprimirFicha();


                while (inimigo.vida > 0 && personagemPrincipal.vida > 0)
                {


                    // rolar os dados
                    d6Jogador = random.Next(1, 6);
                    d6inimigo = random.Next(1, 6);


                    // comparar os valores dos dados
                    if (d6Jogador > d6inimigo)
                    {
                        // se o jogador ganhou, dar o dano no inimigo
                        inimigo.vida -= 10;
                        Console.WriteLine(" Boa consegui acertar ");
                    }
                    else if (d6Jogador < d6inimigo)
                    {
                        // se o inimigo ganhou, dar o dano no jogador
                        personagemPrincipal.vida -= 10;
                        Console.WriteLine(" Eita, essa doeu! ");
                    }
                    else
                    {
                        Console.WriteLine(" Nada Acontece ");
                    }

                    // exibir a vida do jogador e do inimigo
                    Console.WriteLine(" Vida do Jogador: " + personagemPrincipal.vida);
                    Console.WriteLine(" Vida do inimigo " + inimigo.vida);
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);

                }

                if (personagemPrincipal.vida == 0)
                {
                    // se a vida do jogador chegar a 0 mostrar "voce perdeu"
                    Console.WriteLine(" ============= ");
                    Console.WriteLine("  VOCÊ PERDEU ");
                    Console.WriteLine(" ============= ");
                }
                else
                {
                    // se a vida do inimigo chegar a 0 mostrar "voce ganhou"
                    Console.WriteLine(" ============= ");
                    Console.WriteLine("  VOCÊ GANHOU ");
                    Console.WriteLine(" ============= ");
                }

            }



            else
            {
                Console.WriteLine(" Você continua a beber... ");
            }

        }

    
            

          










        }
    }


