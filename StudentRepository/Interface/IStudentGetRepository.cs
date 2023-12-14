using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Interface
{
    public interface IStudentGetRepository
    {
        Student GetStudent(string martricNo);
    }
}
