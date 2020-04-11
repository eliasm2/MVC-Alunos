using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aplicação_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opção;

            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("5 - Listar");
                Console.WriteLine("6 - Salvar Dados em Arquivo");
                Console.WriteLine("7 - Ler Dados do Arquivo");
                Console.WriteLine("8 - Sair");

                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        //Inserir(); 
                        break;
                    case 2:
                        //Alterar();
                        break;
                    case 3:
                        //Excluir();
                        break;
                    case 4:
                        //Pesquisar();
                        break;
                    case 5:
                        //Listar();
                        break;
                    case 6:
                        //SalvarXML();
                        break;
                    case 7:
                        //LerXML();
                        break;
                    case 8:
                        Console.Write("\nSaída do Sistema...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!!");
                        Thread.Sleep(2000);
                        break;

                }
            } while (Opção != 8);
        }
    }
}
