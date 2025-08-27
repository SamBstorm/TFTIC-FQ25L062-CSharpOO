using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_Polymorphisme
{
    internal class ObjetSoin : ObjetQuantifiable
    {
		public void Soigner()
		{
            Console.WriteLine("Je vous soigne!");
		}

	}
}
