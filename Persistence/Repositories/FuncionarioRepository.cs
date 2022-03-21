using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Persistence.Contracts;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
	{
		private readonly FuncionarioDbContext _dbContext;
		public FuncionarioRepository(FuncionarioDbContext dbContext)
		{
			_dbContext = dbContext;
		}

        public async Task Save()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task CreateFuncionario(Funcionario NewFuncionario)
        {
            try
            {
                await _dbContext.AddAsync(NewFuncionario);
                await Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario GetFuncionarioByCpf(string Cpf)
        {
            var funcionar = _dbContext.Funcionarios.FirstOrDefault(q => string.Equals(q.Cpf, Cpf));

            return funcionar;
        }
    }
}

