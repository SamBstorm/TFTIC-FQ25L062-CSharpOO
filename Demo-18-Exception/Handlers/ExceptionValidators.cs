using Demo_18_Exception.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_18_Exception.Handlers
{
    internal static class ExceptionValidators
    {
        public static void CheckYearsOld(DateOnly startdate, int limit = 18)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            int yearNow = today.Year;
            int yearStart = startdate.Year;
            int yearsOld = yearNow - yearStart;
            if(startdate.Month > today.Month && startdate.Day > today.Day)
            {
                yearsOld--;
            }
            if (yearsOld < limit) throw new YearsOldLimitException($"L'âge est plus petit que la limite : {limit}", startdate, today, limit, yearsOld);
        }
    }
}
