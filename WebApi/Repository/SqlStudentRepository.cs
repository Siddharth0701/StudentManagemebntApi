using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataModels;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository( StudentAdminContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            return context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }
    }
}
