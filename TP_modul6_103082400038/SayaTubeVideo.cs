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
            // ini precondition
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null dan maksimal 100 karakter");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int jumlah)
        {
            // precondition
            if (jumlah > 10000000)
            {
                throw new ArgumentException("Penambahan play count maksimal 1000");
            }

            try
            {
                checked
                {
                    playCount += jumlah;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}

