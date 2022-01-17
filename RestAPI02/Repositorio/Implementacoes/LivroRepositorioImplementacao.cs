using RestAPI02.Data;
using RestAPI02.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI02.Repositorio.Implementacoes
{
    public class LivroRepositorioImplementacao : ILivroRepositorio
    {
        private Context _context;

        public LivroRepositorioImplementacao(Context context)
        {
            _context = context;
        }

        public List<Livro> FindAll()
        {
            return _context.Livros.ToList();
        }

        public Livro FindByID(long id)
        {
            return _context.Livros.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Livro Create(Livro livro)
        {
            try
            {
                _context.Add(livro);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return livro;
        }

        public Livro Update(Livro livro)
        {
            if (!Exists(livro.Id))
                return null;

            var result = _context.Livros.SingleOrDefault(p => p.Id.Equals(livro.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(livro);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return livro;
        }

        public void Delete(long id)
        {
            var result = _context.Livros.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Livros.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Livros.Any(p => p.Id.Equals(id));
        }
    }
}