using System;
using System.Threading.Tasks;
using Application.DTOs.Funcionario;
using Domain;
using MediatR;

namespace Application.Persistence.Contracts
{
	public interface IFuncionarioRepository
	{
		Funcionario GetFuncionarioByCpf(string Cpf);
		Task CreateFuncionario(Funcionario NewFuncionario);
		Task Save();
	}
}

