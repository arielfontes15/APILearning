using Microsoft.EntityFrameworkCore;
using RestAPI02.Models;

namespace RestAPI02.Data
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Livro> Livros { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString:@"Server=(local)\SQLEXPRESS;Database=RestAPI02;Integrated Security = True;MultipleActiveResultSets=true");
        //}

        public Context()
        {

        }

        public Context(DbContext<Context> options) : base(otpiosn) { }
    }
}
