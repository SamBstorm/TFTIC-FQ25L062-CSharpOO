using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_26_Generic_01.Utils
{
    public static class ArrayUtils
    {
        public static int FindPosition(List<string> list, string search)
        {
            for(int i = 0; i < list.Count; i++ )
            {
                if( list[i] == search )
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FindPosition<T>(List<T> list, T search) where T : IEquatable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(search))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FindPosition<T>(List<T> list, Func<T, bool> del)
        {
            if (list is null)
            {
                return -1;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is not null)
                {
                    if (del(list[i]))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
