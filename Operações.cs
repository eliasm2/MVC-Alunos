using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Aplicação_MVC
{
    class Operações
    {
        Dados MeusDados;

        public Operações()
        {
            MeusDados = new Dados();
        }

        public void Inserir()
        {
            Aluno MeuAluno;

            do
            {
                MeuAluno = new Aluno();

                Console.Clear();

                Console.WriteLine("Cadastramento de Aluno");
                Console.WriteLine("======================\n");

                MeuAluno.Código = MeuAluno.GeraCódigo();
                Console.WriteLine("Código.......: {0}", MeuAluno.Código);

                Console.Write("Nome do Aluno: ");
                MeuAluno.Nome = Console.ReadLine();

                Console.Write("Telefone.....: ");
                MeuAluno.Telefone = Console.ReadLine();

                Console.Write("Mail.........: ");
                MeuAluno.Mail = Console.ReadLine();

                MeusDados.InserirAluno(MeuAluno);

                Console.WriteLine("\nInserir outro Registro? (ESC para Cancelar...)");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public void Alterar()
        {
            Aluno MeuAluno;
            Aluno MeuAlunoAlterado;

            string CódPesq;

            Console.Clear();

            Console.WriteLine("Alteração de Dados de Aluno no Cadastro");
            Console.WriteLine("=======================================\n");

            Console.Write("Código.......: ");
            CódPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CódPesq);
            MeuAlunoAlterado = new Aluno();

            if (MeuAluno != null)
            {
                Console.WriteLine("\nNome do Aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.WriteLine("Telefone.....: {0}", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0}\n", MeuAluno.Mail);

                Console.WriteLine("\nDados de Atualização:\n");

                MeuAlunoAlterado.Código = MeuAluno.Código;
                Console.WriteLine("Código.......: {0}", MeuAlunoAlterado.Código);

                Console.Write("Nome do Aluno: ");
                MeuAlunoAlterado.Nome = Console.ReadLine();

                Console.Write("Telefone.....: ");
                MeuAlunoAlterado.Telefone = Console.ReadLine();

                Console.Write("Mail.........: ");
                MeuAlunoAlterado.Mail = Console.ReadLine();

                MeusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);

                Console.Write("\nDados Atualizados!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Write("\nAluno não encontrado no Cadastro de Alunos!");
                Thread.Sleep(2000);
            }
        }

        public void Excluir()
        {
            Aluno MeuAluno;

            string CódPesq;

            Console.Clear();

            Console.WriteLine("Exclusão de Aluno no Cadastro");
            Console.WriteLine("=============================\n");

            Console.Write("Código.......: ");
            CódPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CódPesq);

            if (MeuAluno != null)
            {
                MeusDados.ExcluirAluno(MeuAluno);

                Console.Write("\nAluno excluído!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Write("\nAluno não encontrado no Cadastro de Alunos!");
                Thread.Sleep(2000);
            }
        }

        public void Pesquisar()
        {
            Aluno MeuAluno;

            string CódPesq;

            Console.Clear();

            Console.WriteLine("Pesquisa no Cadastro de Alunos");
            Console.WriteLine("==============================\n");

            Console.Write("Código.......: ");
            CódPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CódPesq);

            if (MeuAluno != null)
            {
                Console.WriteLine("\nNome do Aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.WriteLine("Telefone.....: {0}", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0}\n", MeuAluno.Mail);

                Console.ReadKey();
            }
            else
            {
                Console.Write("\nAluno não encontrado no Cadastro de Alunos!");
                Thread.Sleep(2000);
            }
        }

        public void Listar()
        {
            Aluno MeuAluno = new Aluno();

            ArrayList Lista;

            Console.Clear();

            Console.WriteLine("Listagem Geral do Cadastro de Alunos");
            Console.WriteLine("====================================\n");

            Lista = MeusDados.ListarAlunos();

            foreach (Aluno x in Lista)
            {
                Console.WriteLine("Nome do Aluno: {0} ({1})", x.Nome, x.Código);
                Console.WriteLine("Telefone.....: {0}", x.Telefone);
                Console.WriteLine("Mail.........: {0}\n", x.Mail);
            }

            Console.ReadKey();
        }

        public void Ordenar()
        {
            int Registros;
            
            Console.Clear();

            Console.WriteLine("Ordenação de Registros do Cadastro de Alunos");
            Console.WriteLine("============================================\n");

            Registros=MeusDados.OrdenarAlunos();

            Console.Write("Total de Registros: {0}", Registros);

            Thread.Sleep(2000);
        }

        public void SalvarXML()
        {
            int TotReg;

            TotReg = MeusDados.SalvarArquivo();

            Console.Clear();

            Console.WriteLine("Salvar Cadastro em Arquivo XML");
            Console.WriteLine("==============================\n");

            Console.WriteLine("Arquivo XML gerado com sucesso!");
            Console.WriteLine("Total de Registros: {0}", TotReg);

            Thread.Sleep(3000);
        }

        public void LerXML()
        {
            int TotReg;

            TotReg = MeusDados.LerArquivo();

            Console.Clear();

            Console.WriteLine("Ler Arquivo XML");
            Console.WriteLine("===============\n");

            Console.WriteLine("Arquivo XML carregado com sucesso!");
            Console.WriteLine("Total de Registros: {0}", TotReg);

            Thread.Sleep(3000);
        }
    }
}
