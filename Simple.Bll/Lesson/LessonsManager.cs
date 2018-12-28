using Simple.Dal.Abstract;
using Simple.Entity.Model;
using Simple.Interfaces.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Bll.Lesson
{
    public class LessonsManager: ILessonService
    {
        ILessonDal lessonDal;

        public LessonsManager(ILessonDal _lessonDal)
        {
            lessonDal = _lessonDal;
        }

        public Lessons Create(Lessons entity)
        {
            return lessonDal.Create(entity);
        }

        public bool Delete(int id)
        {
            return lessonDal.Delete(id);
        }

        public Lessons Get(int id)
        {
            return lessonDal.Get(id);
        }

        public List<Lessons> List()
        {
            return lessonDal.List();
        }

        public List<Lessons> List(Expression<Func<Lessons, bool>> predicate)
        {
            return lessonDal.List(predicate);
        }

        public bool Update(Lessons entity)
        {
            return lessonDal.Update(entity);
        }
    }
}
