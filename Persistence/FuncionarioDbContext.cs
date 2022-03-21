using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
	public class FuncionarioDbContext: DbContext
	{
        
        public DbSet<Funcionario> Funcionarios { get; set; }

        public FuncionarioDbContext(DbContextOptions<FuncionarioDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(FuncionarioDbContext).Assembly);
        }

	}
}

