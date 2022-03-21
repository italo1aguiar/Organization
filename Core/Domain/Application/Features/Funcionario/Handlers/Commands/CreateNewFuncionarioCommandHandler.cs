using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Funcionario.Requests.Commands;
using MediatR;
using Application.Persistence.Contracts;
using Application.DTOs.Responses;
using System.Net.Mail;
using Application.Models;

namespace Application.Features.Funcionario.Handlers.Commands
{
    public class CreateNewFuncionarioCommandHandler : IRequestHandler<CreateNewFuncionarioCommand, CreateNewFuncionarioResponse>
    {
        private readonly IFuncionarioRepository _funcionarioRespository;
        private readonly IEmailSender _emailSender;
        public CreateNewFuncionarioCommandHandler(IFuncionarioRepository funcionarioRespository, IEmailSender emailSender)
        {
            _funcionarioRespository = funcionarioRespository;
            _emailSender = emailSender;
        }

        public async Task<CreateNewFuncionarioResponse> Handle(CreateNewFuncionarioCommand request, CancellationToken cancellationToken)
        {
            var funcionario = new Domain.Funcionario(request.NewFuncionario.Nome,
                request.NewFuncionario.Cpf,
                request.NewFuncionario.Rg,
                request.NewFuncionario.DataNascimento,
                request.NewFuncionario.Mail,
                request.NewFuncionario.Telefone) ;
            await _funcionarioRespository.CreateFuncionario(funcionario);
            var response = new CreateNewFuncionarioResponse(funcionario.Id);

            try
            {
                var email = new Email
                {
                    To = "italo_aguiar@alu.ufc.br",
                    Body = "Serviço de Email Funcionando",
                    Subject = "Vamo la, meu fi !"
                };
                await _emailSender.SendEmail(email);

            }catch(Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}

