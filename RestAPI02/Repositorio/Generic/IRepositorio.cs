using RestAPI02.Models.Base;
using System.Collections.Generic;

namespace RestAPI02.Repositorio.Generic
{
    public interface IRepositorio<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        T Update(T item);
        void Delete(long id);

        bool Exists(long id);
        List<T> FindAll();
    }
}
