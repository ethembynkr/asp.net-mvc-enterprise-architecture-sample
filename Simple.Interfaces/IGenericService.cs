using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interfaces
{
    interface IGenericService<T>
    {
        T Create(T entity);
        List<T> List();
        List<T> List(Expression<Func<T, bool>> predicate);
        bool Update(T entity);
    }
}
