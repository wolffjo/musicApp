public class BinarySearchTree
{
    private TreeNode? _titleRoot;
    private TreeNode? _artistRoot;

    public void InsertTitle(Song song)
    {
        if (_titleRoot == null)
        {
            _titleRoot = new TreeNode(song);
        }
        else
        {
            _titleRoot.InsertTitle(song);
        }
    }

    public void InsertArtist(Song song)
    {
        if (_artistRoot == null)
        {
            _artistRoot = new TreeNode(song);
        }
        else
        {
            _artistRoot.InsertArtist(song);
        }
    }

    public void Display(string which)
    {
        if (which == "artist")
        {
            if (_artistRoot == null)
            {
                Console.WriteLine("Nothing in Tree.");
            }
            else
            {
                _artistRoot.Display(which);
            }
        }
        else if (which == "title")
        {
            if (_titleRoot == null)
            {
                Console.WriteLine("Nothing in Tree.");
            }
            else
            {
                _titleRoot.Display(which);
            }
        }
        else
        {
            _titleRoot?.Display(which);
        }        
    }

    public void TitleTraverse()
    {
        if (_titleRoot == null)
        {
            Console.WriteLine("Nothing in Tree.");
        }
        else
        {
            _titleRoot.Traverse();
        }
    }

    public void ArtistTraverse()
    {
        if (_artistRoot == null)
        {
            Console.WriteLine("Nothing in Tree.");
        }
        else
        {
            _artistRoot.Traverse();
        }
    }

    public void SearchDatabase(string input)
    {
        List<Song> results = new List<Song>();

        if (input == "`")
        {
            return;
        }
        if (_titleRoot != null)
        {
            _titleRoot.SearchSongs(input.ToLower(), results);
            Console.WriteLine("Songs: ");
            foreach (Song song in results)
            {
                Console.WriteLine(song);
            }
            results.Clear();
        }

        if (_artistRoot != null)
        {
            _artistRoot.SearchSongs(input.ToLower(), results);
            Console.WriteLine("Artists: ");
            foreach (Song song in results)
            {
                Console.WriteLine(song.Artist);
            }
        }
    }
}