using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_MVC
{
    public class Aluno
    {
        public string Código { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }

        public string GeraCódigo()
        {
            string Result="";

            DateTime x = new DateTime();

            x = DateTime.Now;

            Result += x.Date.ToString().Substring(0, 2);
            Result += x.Date.ToString().Substring(3, 2);
            Result += x.Date.ToString().Substring(8, 2);
            Result += x.Second.ToString() + x.Minute.ToString() + x.Hour.ToString();

            return Result;
        }
    }
}
