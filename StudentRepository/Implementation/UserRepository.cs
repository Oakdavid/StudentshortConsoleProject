using StudentShortProject.Context;
using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Implementation
{
    public class UserRepository : IUserRepository
    {
        UserRepository userRepository = new UserRepository();
        public void Create(string email, string password)
        {
            userRepository.Create(email, password);
        }

        public User Get(string email)
        {
            return userRepository.Get(email);
           // return StudentContext.usersDb.FirstOrDefault( a => a.Email == email);
        }

        public List<User> GetAll()
        {
             return userRepository.GetAll();
        }
    }
}
