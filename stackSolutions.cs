using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace musicApp;

public static class stackSolutions
{
    public static void runSong(Song activeSong, ref int runTime, ref bool songFinished)
    {
        while (runTime < activeSong.Length) //maybe later, add a check for paused
        {
            runTime += 1;
            if (runTime % 10 == 0)
            {
                Console.WriteLine(runTime);
            }
        }
        songFinished = true;
        Console.WriteLine($"Song finished: {activeSong} ");
        Console.WriteLine("");
    }
    public static void AddLastPlayed(Stack<Song> lastPlayed, ref Song activeSong, ref bool songFinished, Queue<Song> nextUp)
    {
        if (songFinished == true)
        {
            lastPlayed.Push(activeSong);
            activeSong = nextUp.Dequeue();
            songFinished = false;
            Console.WriteLine(songFinished);  
        }
        Console.WriteLine($"Playing next song: {activeSong}"); //possibly move to a next function in the future
        Console.WriteLine("");
    }
    public static void RestartSong((string, int) buttonPressed, ref int runTime, Song activeSong)
    {
        if (buttonPressed == ("Previous", 1))
        {
            runTime = 0;
            Console.WriteLine($"Song restarted: {activeSong}");
            Console.WriteLine("");
        }
    }

    public static void PreviousSong((string, int) buttonPressed, ref int runTime, ref Song activeSong, Stack<Song> lastPlayed, Queue<Song> nextUp)
    {
        if (buttonPressed.Item1 == "Previous" && buttonPressed.Item2 > 1)
        {
            runTime = 0;
                List<Song> tempList = new List<Song>();

                while (nextUp.Count > 0)
                {
                    tempList.Add(nextUp.Dequeue());
                }

                nextUp.Enqueue(activeSong);
                Console.WriteLine($"Enqueued {activeSong}");
                Console.WriteLine("");

                foreach (var item in tempList)
                {
                    nextUp.Enqueue(item);
                    Console.WriteLine($"Reenqueued {item}");
                }
            
            if (lastPlayed.Count > 0)
            {
                activeSong = lastPlayed.Pop();
                Console.WriteLine($"New song: {activeSong}");
                Console.WriteLine("");
            }
            else
            {
                activeSong.Title = "none";
                activeSong.Artist = "None";
                activeSong.Length = 0;
                Console.WriteLine("Defaulting to empty.");
            }
        }
    }
}