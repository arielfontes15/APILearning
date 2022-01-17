using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Repositorio
{
    public interface IPessoaRepositorio
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

        bool Exists(long id);
        List<Pessoa> FindAll();
    }
}
