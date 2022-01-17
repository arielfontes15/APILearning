using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Negocio
{
    public interface IPessoaNegocio
    {
        List<Pessoa> FindAll();
        Pessoa FindByID(long id);
        Pessoa Create(Pessoa pessoa);
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

    }
}
