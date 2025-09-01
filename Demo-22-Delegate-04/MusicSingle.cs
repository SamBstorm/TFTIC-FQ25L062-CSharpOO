using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_22_Delegate_04
{
    internal class MusicSingle
    {

        public string ArtistName { get; private set; }
        public string Title { get; private set; }
        public int Milliseconds { get; private set; }
        public MusicSingle(string artistName, string title, int milliseconds)
        {
            ArtistName = artistName;
            Title = title;
            Milliseconds = milliseconds;
        }

    }
}
