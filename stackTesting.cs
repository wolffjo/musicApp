// See https://aka.ms/new-console-template for more information
using musicApp;

Setup.setup();

Console.WriteLine($"Setup song: {Setup.activeSong}");

stackSolutions.runSong(Setup.activeSong, ref Setup.runTime, ref Setup.songFinished);

stackSolutions.AddLastPlayed(Setup.lastPlayed, ref Setup.activeSong, ref Setup.songFinished, Setup.nextUp);

Console.WriteLine("Last Played List: ");
foreach (var item in Setup.lastPlayed)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Setup.runTime = 15;
Console.WriteLine("Runtime Changed");
Console.WriteLine($"Current Active: {Setup.activeSong}");
Console.WriteLine("");

Setup.buttonPressed = ("Previous", 1);
stackSolutions.RestartSong(Setup.buttonPressed, ref Setup.runTime, Setup.activeSong);


Console.WriteLine("Previous song");
Setup.buttonPressed = ("Previous", 2);
stackSolutions.PreviousSong(Setup.buttonPressed, ref Setup.runTime, ref Setup.activeSong, Setup.lastPlayed, Setup.nextUp);

Console.WriteLine("Previous song again");
Console.WriteLine("");
Setup.buttonPressed = ("Previous", 3);
stackSolutions.PreviousSong(Setup.buttonPressed, ref Setup.runTime, ref Setup.activeSong, Setup.lastPlayed, Setup.nextUp);

