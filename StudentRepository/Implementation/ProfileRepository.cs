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
        ProfileRepository profileRepository = new ProfileRepository();
        // List<Profile> profile = new List<Profile>();


        public void Create(string name, string lastName, string gender, string email)
        {
            profileRepository.Create(name, lastName, gender, email);
            //Profile profile = new Profile()
            //{
            //    Name = name,
            //    LastName = lastName,
            //    Gender = gender,
            //    Email = email
            //};
            //profileRepository.Create(profile);
           // profile.Add(profile);
        }

        //public Profile Get(int id)
        //{
        //    return profileRepository.Get(id);
        //}

        public Profile Get(string email)
        {
            return profileRepository.Get(email);
        }

        public List<Profile> GetAll()
        {
            return profileRepository.GetAll();
        }

        public Profile Update(string gender)
        {
            return profileRepository.Update(gender);
        }
    }
}
