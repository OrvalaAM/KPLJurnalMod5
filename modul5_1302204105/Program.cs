using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204105
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                SayaTubeUser user = new SayaTubeUser("Orvala");
                SayaTubeVideo video = new SayaTubeVideo("Review Film Interstellar oleh " + user.Username);
                video.IncreasePlayCount(20);
                video.PrintVideoDetails();
                Console.WriteLine();


                SayaTubeVideo video2 = new SayaTubeVideo("Review Film G30S/PKI oleh " + user.Username);
                SayaTubeVideo video3 = new SayaTubeVideo("Review Film Fast and Furious oleh " + user.Username);
                SayaTubeVideo video4 = new SayaTubeVideo("Review Film Battle of Surabaya oleh " + user.Username);
                SayaTubeVideo video5 = new SayaTubeVideo("Review Film John Wick oleh " + user.Username);
                SayaTubeVideo video6 = new SayaTubeVideo("Review Film Transformer oleh " + user.Username);
                SayaTubeVideo video7 = new SayaTubeVideo("Review Film Terminator oleh " + user.Username);
                SayaTubeVideo video8 = new SayaTubeVideo("Review Film Bang Dream Live2nd oleh " + user.Username);
                SayaTubeVideo video9 = new SayaTubeVideo("Review Film Sherlock Holmes oleh " + user.Username);
                SayaTubeVideo video10 = new SayaTubeVideo("Review Film Avatar oleh " + user.Username);
                user.AddVideo(video);
                user.AddVideo(video2);
                user.AddVideo(video3);
                user.AddVideo(video4);
                user.AddVideo(video5);
                user.AddVideo(video6);
                user.AddVideo(video7);
                user.AddVideo(video8);
                user.AddVideo(video9);
                user.AddVideo(video10);
                user.PrintAllVideoPlayCount();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}