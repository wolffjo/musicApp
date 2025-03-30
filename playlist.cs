public class Playlist
{
    public string Name;

    public LinkedList<Song> songs = new LinkedList<Song>();

    public Playlist(string name)
    {
        Name = name;
    }

    public void AddSong(Song song)
    {
        if (songs.Find(song) == null)
        {
            songs.AddLast(song);
            Console.WriteLine("Song added");
        }
    }

    public void RemoveSong(Song song)
    {
        if (songs.Find(song) != null)
        {
            songs.Remove(song);
            Console.WriteLine("Song removed");
        }
        else
        {
            Console.WriteLine("Song not in playlist");
        }
    }

    public void MoveSong(Song song, Song location)
    {
        if (songs.Find(song) != null)
        {
            songs.Remove(song);
            LinkedListNode<Song>? currentNode;
            LinkedListNode<Song>? locationNode = songs.Find(location);
            if (songs.First != null)
            {
                currentNode = songs.First;
                while (currentNode != null)
                {
                    if (currentNode == locationNode)
                    {
                        songs.AddAfter(locationNode, song);
                    }
                    currentNode = currentNode.Next;
                }
            }
        }
    }

    public void CopySongTo(Song song, Playlist playlist)
    {
        if (songs.Find(song) != null)
        {
            playlist.AddSong(song);
        }
    }

    public void Display()
    {
        
        if (songs.First != null)
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }
        }
        else
        {
            Console.WriteLine("[]");
        }
    }

    public void Delete()
    {
        songs.Clear();
        songs = null;
        Name = null;
    }
}