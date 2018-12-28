using Simple.Dal.Abstract;
using Simple.Entity.Model;
using Simple.Interfaces.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Bll.Student
{
    public class StudentManager : IStudentsService
    {
        IStudentDal studentDal;

        public StudentManager(IStudentDal _studentDal)
        {
            studentDal = _studentDal;
        }

        public Students Create(Students entity)
        {
            return studentDal.Create(entity);
        }

        public bool Delete(int id)
        {
            return studentDal.Delete(id);
        }

        public Students Get(int id)
        {
            return studentDal.Get(id);
        }

        public List<Students> List()
        {
            return studentDal.List();
        }

        public List<Students> List(Expression<Func<Students, bool>> predicate)
        {
            return studentDal.List(predicate);
        }

        public bool Update(Students entity)
        {
            return studentDal.Update(entity);
        }
    }
}
