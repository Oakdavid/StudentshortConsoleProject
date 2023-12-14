using StudentShortProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Interface
{
    public interface IProfileRepository
    {
        void Create(string name, string lastName, string gender, string email);
      //  Profile Get(int id);
        Profile Get(string email);
        List<Profile> GetAll();
        Profile Update(string gender);

    }
}
