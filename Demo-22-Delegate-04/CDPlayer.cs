using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_22_Delegate_04
{
    delegate void DelegateProgram();
    internal class CDPlayer
    {
        private DelegateProgram _monProgram;
        public CompactDisk? CurrentCD { get; set; }

        public void Play()
        {
            if (CurrentCD is null) throw new InvalidOperationException("Il n'y a pas de CD dans le lecteur...");
            if(_monProgram is null)
            {
                int trackNumber = 1;
                int currentTime = 0;
                foreach (MusicSingle music in CurrentCD.Tracks)
                {
                    Console.WriteLine($"Lecture de la piste ${trackNumber} : {music.Title} ({music.ArtistName}) : {currentTime}ms");
                    trackNumber++;
                    currentTime += music.Milliseconds;
                }
            }
            else
            {
                _monProgram();
            }
        }

        public void AjouterProgramme(int trackNumber)
        {
            _monProgram += GenererProgram(trackNumber);
        }

        private DelegateProgram GenererProgram(int trackNumber)
        {
            int timer = 0;
            for (int i = 0; i < trackNumber-1; i++)
            {
                timer += CurrentCD.Tracks[i].Milliseconds;
            }
            MusicSingle music = CurrentCD.Tracks[trackNumber - 1];

            return delegate() { Console.WriteLine($"Lecture de la piste ${trackNumber} : {music.Title} ({music.ArtistName}) : {timer}ms"); };
        }
    }
}
