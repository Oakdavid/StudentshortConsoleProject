using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentService.Interface
{
    public interface IStudentGetService
    {
        Student GetStudent(string martricNo);
    }
}
