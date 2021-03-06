﻿using System;
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
            Operações MinhasOperações = new Operações();
            
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
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Salvar Dados em Arquivo");
                Console.WriteLine("8 - Ler Dados do Arquivo");
                Console.WriteLine("9 - Sair");

                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        MinhasOperações.Inserir(); 
                        break;
                    case 2:
                        MinhasOperações.Alterar();
                        break;
                    case 3:
                        MinhasOperações.Excluir();
                        break;
                    case 4:
                        MinhasOperações.Pesquisar();
                        break;
                    case 5:
                        MinhasOperações.Listar();
                        break;
                    case 6:
                        MinhasOperações.Ordenar();
                        break;
                    case 7:
                        MinhasOperações.SalvarXML();
                        break;
                    case 8:
                        MinhasOperações.LerXML();
                        break;
                    case 9:
                        Console.Write("\nSaída do Sistema...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!!");
                        Thread.Sleep(2000);
                        break;

                }
            } while (Opção != 9);
        }
    }
}
