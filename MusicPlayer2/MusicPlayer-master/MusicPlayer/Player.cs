using MusicPlayer.Extensions;
using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class Player
    {
        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 100;

        private bool _locked;
        private int _volume;

        public List<Song> Songs = new List<Song>();

        public bool Playing { get; private set; }

        public int Volume
        {
            get
            {
                return _volume;
            }

            private set
            {
                if (value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        public void VolumeUp()
        {
            if (_locked == false)
            {
                Volume++;
                Console.WriteLine("Звук увеличен на 1");
            }
            else
            {
                Console.WriteLine("Плеер заблокирован");
            }
        }

        public void VolumeDown()
        {
            if (_locked == false)
            {
                Volume--;
                Console.WriteLine("Звук уменьшен на 1");
            }
            else
            {
                Console.WriteLine("Плеер заблокирован");
            }
        }

        public void VolumeChange(int step)
        {
            if (_locked == false)
            {
                Volume += step;
                Console.WriteLine($"Звук изменен на {step}");
            }
            else
            {
                Console.WriteLine("Плеер заблокирован");
            }
        }

        public void Lock()
        {
            _locked = true;
            Console.WriteLine("Плеер заблокирован");
        }

        public void Unlock()
        {
            _locked = false;
            Console.WriteLine("Плеер разблокирован");
        }

        public bool Stop()
        {
            if (_locked)
            {
                Console.WriteLine("Плеер заблокирован");
                return Playing;
            }
            else
            {
                Playing = false;
                Console.WriteLine("Плеер остановлен");
                return Playing;
            }
        }

        public bool Play(bool loop = false)
        {
            if (_locked)
            {
                Console.WriteLine("Плеер заблокирован");
                return Playing;
            }
            else
            {
                if (loop)
                {
                    Console.WriteLine($"Player is playing: {Songs[0].Title}, duration is {Songs[0].Duration}");
                }
                else
                {
                    Playing = true;
                    for (int i = 0; i < Songs.Count; i++)
                    {
                        Console.WriteLine($"Player is playing: {Songs[i].Title}, duration is {Songs[i].Duration}");
                       
                    }
                }
                return Playing;
            }
        }

        public void Add(IEnumerable<Song> songList)
        {
            Songs.AddRange(songList);

        }

        public void Shuffle()
        {
            {
                this.Songs.Shuffle();
            }
        }

        public void SortByTitle()
        {

            Songs.Sort();
           
        }

        public void SortByTitle1()
        {
            Song temp;
            for (int i = 0; i < Songs.Count; i++)
            {
                for (int j = i + 1; j < Songs.Count; j++)
                {
                    if (Songs[i].Title.CompareTo(Songs[j].Title) > 0)
                    {
                        temp = Songs[i];
                        Songs[i] = Songs[j];
                        Songs[j] = temp;
                    }
                }
            }
        }
    }
}
