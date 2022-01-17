using RestAPI02.Data;
using RestAPI02.Models;
using RestAPI02.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI02.Negocio.Implementacoes
{
    public class PessoaNegocioImplementacao : IPessoaNegocio
    {
        private readonly IPessoaRepositorio _repositorio;

        public PessoaNegocioImplementacao(IPessoaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Pessoa> FindAll()
        {
            return _repositorio.FindAll();
        }

        public Pessoa FindByID(long id)
        {
            return _repositorio.FindByID(id);
        }

        public Pessoa Create(Pessoa pessoa)
        {
            return _repositorio.Create(pessoa);
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return _repositorio.Update(pessoa);
        }

        public void Delete(long id) => _repositorio.Delete(id);

    }
}
