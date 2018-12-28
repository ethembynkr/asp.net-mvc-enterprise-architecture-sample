using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interfaces.LessonInfo
{
    interface ILessonsInfoService : IGenericService<LessonsInfo>
    {
        bool Delete(int lessonId,int teacherId);
        LessonsInfo Get(int lessonId, int teacherId);
    }
}
