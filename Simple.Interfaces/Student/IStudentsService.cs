using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interfaces.Student
{
    interface IStudentsService : IGenericService<Students>
    {
        bool Delete(int id);
        Students Get(int id);
    }
}
