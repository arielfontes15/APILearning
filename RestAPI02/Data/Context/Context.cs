using Microsoft.EntityFrameworkCore;
using RestAPI02.Models;

namespace RestAPI02.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(local)\SQLEXPRESS;Database=APILearning;Integrated Security = True;MultipleActiveResultSets=true");
        }

        public Context()
        {

        }


    }
}
