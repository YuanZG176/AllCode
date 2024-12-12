using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Quiz2
{
    internal class Library
    {
        private static List<Song> songs = new List<Song>();

        public static void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                WriteLine(song.ToString());
            }
        }

        public static void  DisplaySongs(double longerThan)
        {
            foreach (Song song in songs)
            {
                if(song.Length > longerThan)
                {
                    WriteLine(song.ToString());
                }
            }
        }

        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song song in songs)
            {
                if (song.Genre == genre)
                {
                    WriteLine(song.ToString());
                }
            }
        }

        public static void DisplaySongs(string artist)
        {
            foreach (Song song in songs)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    WriteLine(song.ToString());
                }
            }
        }

        public static void LoadSongs(string fileNama)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileNama))
                {
                    while (!reader.EndOfStream)
                    {
                        string title = reader.ReadLine();
                        if (title == null)
                        {
                            break;
                        }
                        string artist = reader.ReadLine();
                        string lengthString = reader.ReadLine();
                        string genreSTring = reader.ReadLine();

                        if (genreSTring == null || lengthString == null || artist == null)
                        {
                            break;
                        }
                        double length = double.Parse(lengthString);
                        SongGenre genre = (SongGenre)Enum.Parse(typeof(SongGenre), genreSTring);

                        Song song = new Song(title, artist, length, genre);
                        songs.Add(song);

                        //reader.ReadLine();
                    }
                }
            }
            catch (Exception ex) {
                WriteLine("An error occurred while loading songs: {0}",ex.Message);
            }
        }
    }
}
