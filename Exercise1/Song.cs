using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song 
    {
        //2.1.1
        //歌のタイトル
        public string Title { get; set; }
        //アーティスト名
        public string ArtistName { get; set; }
        //演奏時間
        public int Length { get; set; }

        //2.1.2
        public Song(string title, string artistname, int length) 
        {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
