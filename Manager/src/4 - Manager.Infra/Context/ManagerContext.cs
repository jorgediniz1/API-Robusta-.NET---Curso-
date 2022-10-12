using Microsoft.EntityFrameworkCore;
using Manager.Domain.Entities;
using Manager.Infra.Mappings;

namespace Manager.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(){}

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {} // Construtor para injeção de dependencia.

        public virtual DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap()); //Mudar para From Assemply
        }     
        
    }
} 