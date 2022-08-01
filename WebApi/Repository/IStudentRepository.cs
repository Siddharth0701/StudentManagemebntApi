using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataModels;

namespace WebApi.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
