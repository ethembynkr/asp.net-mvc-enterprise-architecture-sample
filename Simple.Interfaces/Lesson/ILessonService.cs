using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interfaces.Lesson
{
    public interface ILessonService : IGenericService<Lessons>
    {
        bool Delete(int id);
        Lessons Get(int id);
    }
}
