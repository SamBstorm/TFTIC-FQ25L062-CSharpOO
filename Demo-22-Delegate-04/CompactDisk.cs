using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_22_Delegate_04
{
    internal class CompactDisk
    {
        public string AlbumTitle { get; private set; }
        public MusicSingle[] Tracks { get; private set; }

        public CompactDisk( string albumTitle, MusicSingle[] tracks)
        {
            Tracks = tracks;
        }
    }
}
