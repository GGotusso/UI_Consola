using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IGenericDAO<T> where T : class
    {
        ///Pensamos en un CRUD para cualquier entidad
        ///

        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetById(Guid id);
        

    }
}
