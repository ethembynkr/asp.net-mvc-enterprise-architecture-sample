using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Dal.Abstract
{
    interface ILessonDal
    {
        Lessons Create(Lessons entity);
        List<Lessons> List();
        List<Lessons> List(Expression<Func<Lessons, bool>> predicate);
        Lessons Get(int id);
        bool Update(Lessons entity);
        bool Delete(int id);
    }
}
