using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShortProject.Entities
{
    public abstract class BaseEntities
    {
        public string Id {  get; set; }   
        public string Isdeleted { get; set; }
    }
}
