using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.IO;
using System.Xml;
using System.Xml.Serialization;  

namespace Aplicação_MVC
{
    class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public void AlterarAluno(Aluno x, Aluno y)
        {
            int Posição;

            Posição = Cadastro.IndexOf(x);

            Cadastro.Remove(x);
            Cadastro.Insert(Posição, y);
        }

        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);
        }
        
        public Aluno PesquisarAluno(string Cód)
        {
            foreach (Aluno x in Cadastro)
            {
                if (x.Código == Cód)
                {
                    return x;
                }
            }

            return null;
        }
        
        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }

        public int OrdenarAlunos()
        {
            Cadastro.Sort(new MinhaOrdenação());

            return Cadastro.Count;
        }

        public int SalvarArquivo()
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\Lixo\CadastroAlunos.xml");

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaAlunoVetor);

            MeuWriter.Close();

            return Cadastro.Count;
        }

        public int LerArquivo()
        {
            int Reg;
            
            FileStream Arquivo = new FileStream(@"D:\Lixo\CadastroAlunos.xml", FileMode.Open);
            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            ListaAlunoVetor = (Aluno[])Serialização.Deserialize(Arquivo);              

            Cadastro.Clear();                                                          
            Cadastro.AddRange(ListaAlunoVetor);

            Reg = Cadastro.Count;

            Arquivo.Close();

            return Reg;
        }

        public class MinhaOrdenação : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
            }
        }
    }
}
