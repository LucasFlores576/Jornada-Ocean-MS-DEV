using System;
using System.IO;
using System.Threading;

using ProjetoElevador.MODEL;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(String[] args)
        {

            ELEVADOR UPDOWN = new ELEVADOR();
            int CAP = 0;
            int TOTFLOOR = 0;
            int COMANDO = 0;


            Console.WriteLine("Atenção!Elevador entrando em Operação!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Definir Capacidade do elevador");
            CAP = int.Parse(Console.ReadLine());
            Console.WriteLine("Definir Total de Andares do Edificio");
            TOTFLOOR = int.Parse(Console.ReadLine());

            UPDOWN.Inicializar(CAP,TOTFLOOR);
            Console.Clear();

            bool continuar = true;

           
            do
            {
                Console.WriteLine(@" Escolha uma opção:
                                     1 - Entrando
                                     2 - Saindo
                                     3 - Subindo
                                     4 - Descendo
                                     5 - Sair");

                string TAKE = Console.ReadLine();
                Console.Clear();

                switch (TAKE)
                {
                    case "1":
                        Console.WriteLine("Entrar");
                        UPDOWN.Entrar();
                        break;
                    case "2":
                        Console.WriteLine("Sair");
                        UPDOWN.Sair();
                        break;
                    case "3":
                        Console.WriteLine("Subir");
                        UPDOWN.Subir();
                        break;
                    case "4":
                        UPDOWN.Descer();
                        Console.WriteLine("Descer");
                        break;
                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }
            }

            while (continuar);          


        }
    }
}