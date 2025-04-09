using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

public struct Song
{
    public string? Title;
    public string? Artist;
    public int Length;

    public Song(string title, string artist, int length = 0)
    {
        if (title == null && artist == null)
        {
            Console.WriteLine("No song detected.");
        }
        else
        {
            Title = title;
            Artist = artist;
            Length = length;
        }
    }

    public override string ToString()
    {
        return $"{Title} by {Artist} ({Length} seconds)";
    }

}

class Setup
{
    public static Song s1 = new Song(); //Song, Artist, Length in seconds
    public static Song s2 = new Song();
    public static Song s3 = new Song();

    public  static Song activeSong = new Song(); //Song that is currently playing
    public  static int runTime = 0; //how long the song has been playing for
    public  static bool songFinished = false;

    public static Song q1 = new Song();
    public static Song q2 = new Song();
    public static Song q3 = new Song();

    public static Stack<Song> lastPlayed = new Stack<Song>();
    public static Stack<Song> previoused = new Stack<Song>();
    public static Queue<Song> nextUp = new Queue<Song>();

    public static (string, int) buttonPressed = ("", 0); //what button was pressed, and how many times within, say 3 seconds of each other


    public static void setup()
    {
        s1 = new Song("Demons", "Imagine Dragons", 178);
        Console.WriteLine(s1);

        s2 = new Song("Something Just Like This", "Coldplay", 247);
        s3 = new Song("Faded", "Alan Walker", 212);

        activeSong = new Song("The Nights", "Avicii", 176);
        runTime = 0;

        q1 = new Song("A Sky Full of Stars", "Coldplay", 267);
        q2 = new Song("Counting Stars", "One Republic", 257);
        q3 = new Song("Wake Me Up", "Avicii", 249);
        
        lastPlayed.Push(s3);
        lastPlayed.Push(s2);
        lastPlayed.Push(s1);

        nextUp.Enqueue(q1);
        nextUp.Enqueue(q2);
        nextUp.Enqueue(q3);


        Console.WriteLine("Hello, World!");
    }
    
}

