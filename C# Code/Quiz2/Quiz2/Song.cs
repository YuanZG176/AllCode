using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Song
    {
        public string Artist { get; }
        public SongGenre Genre { get; }
        public double Length { get; }
        public string Title { get; }

        public Song(string artist, string title, double length, SongGenre genre)
        {
            this.Artist = artist;
            this.Genre = genre;
            this.Length = length;
            this.Title = title;
        }

        public override string ToString()
        {
            /*return string.Format("{0}'s {1}, has {2} minutes long and belongs to {3} styles.",Artist,Title,
                Length,Genre);*/

            return string.Format("{0} by {1}({2}) {3}min.", Title, Artist,
                 Genre, Length);
            
        }
    }
}
