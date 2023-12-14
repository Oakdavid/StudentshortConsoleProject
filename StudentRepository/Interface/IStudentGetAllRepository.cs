using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Interface
{
    public interface IStudentGetAllRepository
    {
        List<Student> GetAll(int id);
    }
}
