using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_12_Interface_01
{
    internal interface IRoulable
    {
        int NbRoues { get; }
        void Rouler(int distance);
    }
}
