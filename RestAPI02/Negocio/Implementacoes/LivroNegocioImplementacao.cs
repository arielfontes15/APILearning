using RestAPI02.Models;
using RestAPI02.Repositorio;
using System.Collections.Generic;

namespace RestAPI02.Negocio.Implementacoes
{
    public class LivroNegocioImplementacao : ILivroNegocio
    {
        private readonly ILivroRepositorio _repositorio;

        public LivroNegocioImplementacao(ILivroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Livro> FindAll()
        {
            return _repositorio.FindAll();
        }

        public Livro FindByID(long id)
        {
            return _repositorio.FindByID(id);
        }

        public Livro Create(Livro livro)
        {
            return _repositorio.Create(livro);
        }

        public Livro Update(Livro livro)
        {
            return _repositorio.Update(livro);
        }

        public void Delete(long id) => _repositorio.Delete(id);
    }
}
