using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_18_Exception.Models.Exceptions
{
    internal class YearsOldLimitException : Exception
    {
        public DateOnly StartDate { get; private set; }
        public DateOnly ExceptionDate { get; private set; }
        public int Limit { get; private set; }
        public int YearsOld { get; private set; }
        public YearsOldLimitException(string? message) : base(message)
        {
        }

        public YearsOldLimitException() : base("L'âge est plus petit que la limite")
        {
        }

        public YearsOldLimitException(string? message, DateOnly startDate, DateOnly exceptionDate, int limit, int yearsOld) : this(message)
        {
            StartDate = startDate;
            ExceptionDate = exceptionDate;
            Limit = limit;
            YearsOld = yearsOld;
        }
    }
}
