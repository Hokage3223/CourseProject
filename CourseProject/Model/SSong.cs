using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class SSong
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string SongTitle { get; set; }
        public int Year { get; set; }

        public SSong(string artist, string album, string songTitle, int year)
        {
            Artist = artist;
            Album = album;
            SongTitle = songTitle;
            Year = year;
        }
    }
}
