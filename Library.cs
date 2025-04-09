public class Library
{
    public LinkedList<Playlist> playlists = new LinkedList<Playlist>();

    public void AddPlaylist(Playlist playlist)
    {
        if (playlists.Find(playlist) == null)
        {
            playlists.AddLast(playlist);
            Console.WriteLine("Playlist added");
        }
    }

    public void RemovePlaylist(Playlist playlist)
    {
        if (playlists.Find(playlist) != null)
        {
            playlist.Delete();
            playlists.Remove(playlist);
            Console.WriteLine("Playlist deleted");
        }
        else
        {
            Console.WriteLine("Playlist not in library");
        }
    }

    public void MovePlaylist(Playlist playlist, Playlist location)
    {
        if (playlists.Find(playlist) != null)
        {
            playlists.Remove(playlist);
            LinkedListNode<Playlist>? currentNode;
            LinkedListNode<Playlist>? locationNode = playlists.Find(location);
            if (playlists.First != null)
            {
                currentNode = playlists.First;
                while (currentNode != null)
                {
                    if (currentNode == locationNode)
                    {
                        playlists.AddAfter(locationNode, playlist);
                    }
                    currentNode = currentNode.Next;
                }
            }
        }
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("Library: ");
        if (playlists.First != null)
        {
            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine(playlist.Name);
            }
        }
        else
        {
            Console.WriteLine("[]");
        }
    }
}