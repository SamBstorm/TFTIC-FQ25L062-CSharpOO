using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal interface IPersonnage
    {
        string Nom { get; }
        int CurrentPV { get; }
        int PVMax { get; }
        int Attack { get; }
        int SpellAttack { get; }
        int Def { get; }
        int SpellDef { get; }
    }
}
