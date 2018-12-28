using Simple.Dal.Abstract;
using Simple.Entity.Model;
using Simple.Interfaces.LessonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Bll.LessonInfo
{
    public class LessonInfoManager : ILessonsInfoService
    {
        ILessonInfoDal lessonsInfoDal;
        public LessonInfoManager(ILessonInfoDal _lessonInfoDal)
        {
            lessonsInfoDal = _lessonInfoDal;
        }
        public LessonsInfo Create(LessonsInfo entity)
        {
            return lessonsInfoDal.Create(entity);
        }

        public bool Delete(int lessonId, int teacherId)
        {
            return lessonsInfoDal.Delete(lessonId, teacherId);
        }

        public LessonsInfo Get(int lessonId, int teacherId)
        {
            return lessonsInfoDal.Get(lessonId, teacherId);
        }

        public List<LessonsInfo> List()
        {
            return lessonsInfoDal.List();
        }

        public List<LessonsInfo> List(Expression<Func<LessonsInfo, bool>> predicate)
        {
            return lessonsInfoDal.List(predicate);
        }

        public bool Update(LessonsInfo entity)
        {
            return lessonsInfoDal.Update(entity);
        }
    }
}
