using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interfaces.Teacher
{
    public interface ITeachersService :IGenericService<Teachers>
    {
        bool Delete(int id);
        Teachers Get(int id);
    }
}
