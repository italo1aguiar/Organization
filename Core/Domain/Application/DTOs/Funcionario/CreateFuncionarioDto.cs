using System;
namespace Application.DTOs.Funcionario
{
	public class CreateFuncionarioDto
	{
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Rg { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Mail { get; set; }
		public string Telefone { get; set; }
	}
}

