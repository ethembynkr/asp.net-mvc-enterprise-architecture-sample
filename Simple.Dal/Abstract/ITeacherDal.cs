using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Dal.Abstract
{
    public interface ITeacherDal
    {
        Teachers Create(Teachers entity);
        List<Teachers> List();
        List<Teachers> List(Expression<Func<Teachers, bool>> predicate);
        Teachers Get(int id);
        bool Update(Teachers entity);
        bool Delete(int id);
    }
}
