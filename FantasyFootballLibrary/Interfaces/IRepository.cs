using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballLibrary.Interfaces
{
//Contract for the repository 
     public interface IRepository<T>
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression); //takes a lamda expression in, as its own arguement 

        T Create(T entity);

        T Update(T entity);

        void Delete(T entity);

    }
}
