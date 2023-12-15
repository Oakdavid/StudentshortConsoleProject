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

        List<Student> student = new List<Student>();
        public void Create(string matricNo, string department)
        {
            var student = new Student()
            {
                MatricNumber = matricNo,
                Department = department
            };
        }

        public List<Student> GetAll(int id)
        {
           var list = new List<Student>();
            return list;
        }

        public Student GetStudent(string martricNo)
        {
            var students = student.SingleOrDefault(students => students.MatricNumber == martricNo);
            return students;
        }
    }
}
