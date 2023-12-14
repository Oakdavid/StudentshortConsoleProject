using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Implementation;
using StudentShortProject.StudentRepository.Interface;
using StudentShortProject.StudentService.IStudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentService.Implementaton
{
    public class ProfileService : IProfileService
    {
        IProfileRepository profileRepository = new ProfileRepository();
        public void Create(string name, string lastName, string gender, string email)
        {
            if (email == null)
            {
                Profile profile = new Profile()
                {
                    Name = name,
                    LastName = lastName,
                    Gender = gender,
                    Email = email,
                };
                profileRepository.Create(name, lastName, gender, email);
                Console.WriteLine("Created successfully");
            }
        }

        //public Profile Get(int id)
        //{
        //    profileRepository.Get(id);
        //    if(id == 0 )
        //    {
        //        return profileRepository.Get(0);

        //    }
        //    return null;
        //}
        public Profile Get(string email)
        {
            // profileRepository.Get(email);
            Profile profile = profileRepository.Get(email);
            if (email == email)
            {
                // return profileRepository.Get(email);
                return profile;
            };
            return null;
        }

        public List<Profile> GetAll()
        {
            profileRepository.GetAll();     // what is the difference between the two or which is better
            var profileList = profileRepository.GetAll();

            foreach (var item in profileRepository.GetAll())
            {
                Console.WriteLine($"Name:{item.Name}, lastName:{item.LastName}," +
                    $" Gender: {item.Gender}, Email: {item.Gender}");
            }
            //return profileRepository.GetAll();
            return profileList;
        }
    }
}
