using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Dal.Abstract
{
    interface ILessonInfo
    {
        LessonsInfo Create(LessonsInfo entity);
        List<LessonsInfo> List();
        List<LessonsInfo> List(Expression<Func<LessonsInfo, bool>> predicate);
        LessonsInfo Get(int lessonId, int teacherId);
        bool Update(LessonsInfo entity);
        bool Delete(int lessonId,int teacherId);
    }
}
