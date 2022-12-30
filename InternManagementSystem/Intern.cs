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
            /*
            if (string.IsNullOrEmpty(internName))
            {
                throw new ArgumentException($"'{nameof(internName)}' cannot be null or empty.", nameof(internName));
            }

            if (string.IsNullOrEmpty(internEmail))
            {
                throw new ArgumentException($"'{nameof(internEmail)}' cannot be null or empty.", nameof(internEmail));
            }

            if (string.IsNullOrEmpty(internPhone))
            {
                throw new ArgumentException($"'{nameof(internPhone)}' cannot be null or empty.", nameof(internPhone));
            }

            if (string.IsNullOrEmpty(internRole))
            {
                throw new ArgumentException($"'{nameof(internRole)}' cannot be null or empty.", nameof(internRole));
            }

            if (string.IsNullOrEmpty(internSkills))
            {
                throw new ArgumentException($"'{nameof(internSkills)}' cannot be null or empty.", nameof(internSkills));
            }
            */

            InternName = internName;
            InternEmail = internEmail;
            InternPhone = internPhone;
            InternDoB = internDoB;
            InternRole = internRole;
            InternSkills = internSkills;
        }


    }
}
