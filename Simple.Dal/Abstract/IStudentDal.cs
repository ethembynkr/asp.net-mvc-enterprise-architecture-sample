using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Dal.Abstract
{
    public interface IStudentDal
    {
        Students Create(Students entity);
        List<Students> List();
        List<Students> List(Expression<Func<Students, bool>> predicate);
        Students Get(int id);
        bool Update(Students entity);
        bool Delete(int id);
    }
}
