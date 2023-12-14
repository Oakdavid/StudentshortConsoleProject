using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.StudentRepository.Interface
{
    public interface IStudentCreateRepository
    {
        void Create(string matricNo, string department);
    }
}
