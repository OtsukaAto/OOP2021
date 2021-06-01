using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args)
        {
            //2.1.3
            var songs = new Song[] {
                new Song("Creepy Nuts","Who am I",823),
                new Song("RHYMESTER","K.U.F.U",265),
                new Song("RUN D.M.C","Walk This Way",339),
                new Song("The Jimmy Castor Bunch","It's Just Begun",215),
                new Song("Beastie Boys","Brass Monkey",508),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) 
        {
            foreach (var song in songs) 
            {
                Console.WriteLine("{0},{1},{2}",song.Title,song.ArtistName,song.Length);

        
        
            }
        }
    }
}
