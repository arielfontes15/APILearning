using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Repositorio
{
    public interface IPessoaRepositorio
    {
        List<Pessoa> FindAll();
        Pessoa FindByID(long id);
        Pessoa Create(Pessoa pessoa);
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

        bool Exists(long id);
    }
}
