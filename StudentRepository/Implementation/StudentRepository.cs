using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Implementation
{
    public class StudentRepository : IStudentCreateRepository, IStudentGetAllRepository, IStudentGetRepository
    {

        StudentRepository studentRepository = new StudentRepository();
        public void Create(string matricNo, string department)
        {
            studentRepository.Create(matricNo, department);
        }

        public List<Student> GetAll(int id)
        {
            return studentRepository.GetAll(id);
        }

        public Student GetStudent(string martricNo)
        {
            return studentRepository.GetStudent(martricNo);
        }
    }
}
