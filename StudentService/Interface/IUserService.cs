using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentService.Interface
{
   public interface IUserService
    {
        void Create(string email, string password);
        User Get(string email);
        List<User> GetAll();
    }
}
