using System;
using TP_modul6_103082400038;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Dimas");

            // test
            video.IncreasePlayCount(1000);
            video.PrintVideoDetails();

          
            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(1000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}