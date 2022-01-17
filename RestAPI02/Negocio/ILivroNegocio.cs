using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Negocio
{
    public interface ILivroNegocio
    {
        List<Livro> FindAll();
        Livro FindByID(long id);
        Livro Create(Livro livro);
        Livro Update(Livro livro);
        void Delete(long id);

    }
}
