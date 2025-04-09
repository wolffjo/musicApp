// See https://aka.ms/new-console-template for more information
using musicApp;

List<Song> database = Database.DatabaseSongs;
Setup.setup();
Library library = new Library();


// Stack Testing
/*
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
*/



/*
//Linked List Testing
//Basic Playlist Functionality
Console.WriteLine("Creating");
Playlist LikedSongs = new Playlist("Liked Songs");
LikedSongs.Display();

Playlist HatedSongs = new Playlist("Hated Songs");
HatedSongs.Display();

Console.WriteLine("");

Console.WriteLine("Adding");
LikedSongs.AddSong(Setup.s1);
LikedSongs.AddSong(Setup.s2);
LikedSongs.AddSong(Setup.s3);
LikedSongs.AddSong(Setup.q1);
LikedSongs.AddSong(Setup.q2);
LikedSongs.AddSong(Setup.q3);
Console.WriteLine("Liked Songs");
LikedSongs.Display();
Console.WriteLine();
Console.WriteLine("Hated Songs");
HatedSongs.Display();
Console.WriteLine();

Console.WriteLine("Removing");
LikedSongs.RemoveSong(Setup.q3);
Console.WriteLine("Liked Songs");
LikedSongs.Display();
Console.WriteLine();

Console.WriteLine("Moving");
LikedSongs.MoveSong(Setup.s2, Setup.q1);
Console.WriteLine("Liked Songs");
LikedSongs.Display();
Console.WriteLine();

Console.WriteLine("Copying");
LikedSongs.CopySongTo(Setup.q2, HatedSongs);
Console.WriteLine("Liked Songs");
LikedSongs.Display();
Console.WriteLine();
Console.WriteLine("Hated Songs");
HatedSongs.Display();
Console.WriteLine();
Console.WriteLine();



//Library Functionality
Console.WriteLine("Creating empty playlists");
Playlist playlist1 = new Playlist("playlist1");
Playlist playlist2 = new Playlist("playlist2");
Playlist playlist3 = new Playlist("playlist3");
Console.WriteLine();

Console.WriteLine("Adding Playlists");
library.AddPlaylist(LikedSongs);
library.AddPlaylist(HatedSongs);
library.AddPlaylist(playlist1);
library.AddPlaylist(playlist2);
library.AddPlaylist(playlist3);
library.Display(); 
Console.WriteLine();

Console.WriteLine("Removing playlist");
library.RemovePlaylist(playlist2);
library.Display();
Console.WriteLine($"Displaying deleted playlist: ", playlist2);
Console.WriteLine();

Console.WriteLine("Moving Playlist");
library.MovePlaylist(HatedSongs, playlist3);
library.Display();
*/


/*
//Tree Testing
//Tree Creation
BinarySearchTree titleTree = new BinarySearchTree();
BinarySearchTree artistTree = new BinarySearchTree();

Console.WriteLine("Title Tree:");
titleTree.Display("title");
Console.WriteLine();

//Add to and display songs in order
foreach(Song song in database)
{
    titleTree.InsertTitle(song);
    //Console.Write("Added song: ");
    //Console.WriteLine(song);
}

Console.WriteLine();
Console.WriteLine("Title Tree:");
titleTree.Display("title");
Console.WriteLine();
Console.WriteLine();

//Artist Tree
Console.WriteLine("Artist Tree:");
artistTree.Display("artist");
Console.WriteLine();

foreach (Song song in database)
{
    artistTree.InsertArtist(song);
    //Console.WriteLine($"Added artist: ", song.Artist);
}

Console.WriteLine("Artist Tree:");
artistTree.Display("artist");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("All Details: ");
titleTree.Display("all");
Console.WriteLine();
Console.WriteLine();

//Searching
string? input = "";
Console.WriteLine("Press ` to quit.");
while (input != "`")
{
    Console.Write("Search: ");
    input = Console.ReadLine();
    titleTree.SearchDatabase(input);

    Console.WriteLine();
    Console.WriteLine();

    artistTree.SearchDatabase(input);
    Console.WriteLine();
}
*/




