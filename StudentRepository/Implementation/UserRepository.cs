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
        List<User> user = new List<User>();
        public void Create(string email, string password)
        {
            var user = new User()
            {
                Email = email,
                Password = password
            };
        }

        public User Get(string email)
        {
           var userGet = user.SingleOrDefault(x => x.Email == email);
            return userGet;
        }

        public List<User> GetAll()
        {
             var userList = new List<User>();
            return userList;
        }
    }
}
