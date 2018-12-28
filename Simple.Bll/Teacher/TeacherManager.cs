using Simple.Dal.Abstract;
using Simple.Entity.Model;
using Simple.Interfaces.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Bll.Teacher
{
    public class TeacherManager : ITeachersService
    {
        ITeacherDal teacherDal;

        public TeacherManager(ITeacherDal _teacherDal)
        {
            teacherDal = _teacherDal;
        }

        public Teachers Create(Teachers entity)
        {
            return teacherDal.Create(entity);
        }

        public bool Delete(int id)
        {
            return teacherDal.Delete(id);
        }

        public Teachers Get(int id)
        {
            return teacherDal.Get(id);
        }

        public List<Teachers> List()
        {
            return teacherDal.List();
        }

        public List<Teachers> List(Expression<Func<Teachers, bool>> predicate)
        {
            return teacherDal.List(predicate);
        }

        public bool Update(Teachers entity)
        {
            return teacherDal.Update(entity);
        }
    }
}
