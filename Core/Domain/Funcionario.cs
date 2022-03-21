using System;
using System.Linq;

namespace Domain
{
	public class Funcionario
	{
        public Funcionario(string nome, string cpf, string rg, DateTime dataNascimento, string mail, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                Idade = Idade - 1;
            DataIngresso = DateTime.Now;
            Mail = mail;
        }

        public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Rg { get; set; }
        public string Telefone { get; set; }
        public int Id { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }
		public DateTime DataIngresso { get; set; }
		public string Mail { get; set; }
	}
}

