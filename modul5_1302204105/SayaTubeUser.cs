using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204105
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser() { }
        public SayaTubeUser(string user)
        {
            Username = user;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                total = total + uploadedVideos[i].getPlayCount();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
