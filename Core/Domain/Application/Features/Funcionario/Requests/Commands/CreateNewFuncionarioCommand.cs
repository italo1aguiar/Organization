using System;
using Application.DTOs.Funcionario;
using MediatR;
using Domain;
using Application.DTOs.Responses;

namespace Application.Features.Funcionario.Requests.Commands
{
	public class CreateNewFuncionarioCommand : IRequest<CreateNewFuncionarioResponse>
	{
		public CreateFuncionarioDto NewFuncionario { get; set; }
	}
}

