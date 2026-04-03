using System;
using System.Collections.Generic;
using System.Text;

namespace TP_modul6_103082400038
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999); 
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int jumlah)
        {
            playCount += jumlah;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}
