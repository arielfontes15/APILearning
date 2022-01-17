using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Repositorio
{
    public interface ILivroRepositorio
    {
        Livro Create(Livro livro);
        Livro FindByID(long id);
        Livro Update(Livro livro);
        void Delete(long id);
        bool Exists(long id);
        List<Livro> FindAll();
    }
}
