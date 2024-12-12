// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Quiz2;
using System;
using static System.Console;


public enum SongGenre
{
    Unclassfied = 0,
    Pop = 1,
    Rock = 2,
    Blues = 4,
    Country = 8,
    Metal = 16,
    Soul = 32
}

public class Program
{
    public static void Main()
    {
/*        SongGenre myFavoriteGenres = SongGenre.Rock | SongGenre.Blues;
        WriteLine(myFavoriteGenres);

        bool Flag = (myFavoriteGenres & SongGenre.Rock) == SongGenre.Rock;
        WriteLine(Flag);*/




        //To test the constructor and the ToString method
        Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
        Console.WriteLine(new Song("The Promise", "Chris Cornell ",
          4.26, SongGenre.Country | SongGenre.Rock));     //genre is composed of two genres

        Library.LoadSongs("Week_03_lab_09_songs4.txt");   //Class methods are invoke with the class name
        Console.WriteLine("\n\nAll songs");
        Library.DisplaySongs();

        SongGenre genre = SongGenre.Rock;
        Console.WriteLine("\n\n{0} songs", genre);
        Library.DisplaySongs(genre);

        string artist = "Bob Dylan";
        Console.WriteLine("\n\nSongs by {0}", artist);
        Library.DisplaySongs(artist);

        double length = 5.0;
        Console.WriteLine("\n\nSongs more than {0}mins", length);
        Library.DisplaySongs(length);
        
    }
}