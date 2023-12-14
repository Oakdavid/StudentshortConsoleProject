using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Interface
{
    public  interface IUserRepository
    {
        void Create(string email, string password);
        User Get(string email);
        List<User> GetAll();
    }
}
