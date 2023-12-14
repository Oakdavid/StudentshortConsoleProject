using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Implementation;
using StudentShortProject.StudentRepository.Interface;
using StudentShortProject.StudentService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentService.Implementaton
{
    public class StudentService : IStudentCreateService, IStudentGetAllRepository, IStudentGetService
    {
        IStudentCreateRepository studentCreateRepository;
        IStudentGetRepository studentGetRepository;
        IStudentGetAllRepository studentGetAllRepository;

        public void Create(string matricNo, string department)
        {
            var student = studentCreateRepository;
            if(student == null)
            {
                new Student
                {
                    MatricNumber = matricNo,
                    Department = department
                };
                studentCreateRepository.Create(matricNo, department);
                Console.WriteLine("Created successfully");
            }
        }

        public List<Student> GetAll(int id)
        {
            var getAllStudent = studentGetAllRepository.GetAll(id);
            foreach(var student in getAllStudent)
            {
                Console.WriteLine($"MatricNo: {student.MatricNumber}, Department: {student.Department}");
            }
            return getAllStudent;
        }

        public Student GetStudent(string martricNo)
        {
            var student = studentGetRepository.GetStudent(martricNo);
            if(student == null)
            {
                return student;
            }
            return null;
        }
    }
}
