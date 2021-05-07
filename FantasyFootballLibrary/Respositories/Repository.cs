using FantasyFootballLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FantasyFootballLibrary.Respositories
{
    public class Repository<T> : IRepository<T> where T : class // inherits from IRepository, where the T inherits from the class
    //Click Ctrl + . on the phrase "IRepository<T> in order to implement interferences 
    {
        protected ApplicationDbContext RepositoryContext { get; set; }

        public Repository(ApplicationDbContext repositoryContext) //Dependency injection

            {
            
            RepositoryContext = RepositoryContext;
            
            }


        public T Create(T entity)
        {
        return RepositoryContext.Set<T>().Add(entity).Entity;
        }

        public void Delete(T entity)
        {
           RepositoryContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
           
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            
        }

        public T Update(T entity)
        {
            
        }
    }
}
