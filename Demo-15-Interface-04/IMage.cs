using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal interface IMage : IPersonnage
    {
        void AttackMagic(Personnage adversaire);
    }
}
