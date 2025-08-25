using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_ProprietesAutoCalculees
{
    internal class User
    {
        public DateOnly BirthDate { get; set; }

        public int YearsOld
        {
            get
            {
                DateOnly today = DateOnly.FromDateTime(DateTime.Now);
                int age = today.Year - BirthDate.Year;
                if(BirthDate.Month > today.Month && BirthDate.Day > today.Day)
                {
                    age--;
                }
                return age;
            }
        }
    }
}
