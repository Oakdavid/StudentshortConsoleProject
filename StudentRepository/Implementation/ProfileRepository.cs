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
    public class ProfileRepository : IProfileRepository
    {

        List<Profile> profiles = new List<Profile>();

        public void Create(string name, string lastName, string gender, string email)
        {

            Profile profile = new Profile()
            {
                Name = name,
                LastName = lastName,
                Gender = gender,
                Email = email
            };
            profiles.Add(profile);
            
        }


        public Profile Get(string email)
        {
           var  s = profiles.SingleOrDefault(s => s.Email == email);
           return s;
        }

        public List<Profile> GetAll()
        {
           var profileList = new List<Profile>();
           return profileList;
        }

        public Profile Update(string gender)
        {
            var updateProfile = profiles.FirstOrDefault(s => s.Gender == gender);
            return updateProfile;

        }
    }
}
