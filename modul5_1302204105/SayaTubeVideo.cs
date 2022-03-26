using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204105
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo() { }
        public SayaTubeVideo(string judul)
        {
            if (judul.Length > 200)
                throw new Exception("Judul terlalu panjang");
            if (judul == null)
                throw new Exception("Judul kosong");
            title = judul;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
            playCount = 0;
        }
        public void IncreasePlayCount(int jumlah)
        {
            if (jumlah > 25000000)
                throw new Exception("Penambahan terlalu banyak");
            if (jumlah < 0)
                throw new Exception("Penambahan tidak boleh negatif");
            playCount = checked(playCount + jumlah);
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID       :" + id);
            Console.WriteLine("Judul    :" + title);
            Console.WriteLine("Views    :" + playCount);
        }
        public int getPlayCount()
        {
            return playCount;
        }
        public string getTitle()
        {
            return title;
        }
    }
}
