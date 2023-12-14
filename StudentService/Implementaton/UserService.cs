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
    public class UserService : IUserService
    {
        IUserRepository userRepository = new UserRepository();

        public void Create(string email, string password)
        {
            var user = new User();
            if (user == null)
            {
                new User()
                {
                    Email = email,
                    Password = password
                };
                userRepository.Create(email, password);
                Console.WriteLine("Created successfully");
            }
        }

        public User Get(string email)
        {
            var user = userRepository.Get(email);
            {
                if(user == null)
                {
                    return user;
                }
                return null;
            }
        }

        public List<User> GetAll()
        {
            var userList = userRepository.GetAll();
            foreach (var user in userList)
            {
                Console.WriteLine($"Email: {user.Email}, Password: {user.Password}");
            }
            return userList;
        }
    }
}
