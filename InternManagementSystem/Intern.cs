using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagementSystem
{
    public class Intern
    {
      

        public string InternName { get; set; }
        public string InternEmail { get; set; }

        public string InternPhone { get; set; }
        public DateTime InternDoB { get; set; }
        public string InternRole { get; set; }
        public string InternSkills { get; set; }

        public Intern(string internName, string internEmail, string internPhone, DateTime internDoB, string internRole, string internSkills)
        {
         

            InternName = internName;
            InternEmail = internEmail;
            InternPhone = internPhone;
            InternDoB = internDoB;
            InternRole = internRole;
            InternSkills = internSkills;
        }


    }
}
