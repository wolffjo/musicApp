using System.Diagnostics.Tracing;

public class TreeNode
{
    public Song NodeSong;
    public TreeNode? Left;
    public TreeNode? Right;
    public int Height;

    public TreeNode(Song song)
    {
        NodeSong = song;
        Left = null;
        Right = null;
        Height = 1;
    }

    public TreeNode InsertTitle(Song song)
    {
        int comparisonResult = string.Compare(song.Title, NodeSong.Title, StringComparison.OrdinalIgnoreCase);
        //Console.WriteLine($"Inserting: {song.Title}, Current Node: {NodeSong.Title}, Comparison: {comparisonResult}");

        if (comparisonResult == 0)
        {
            Console.WriteLine("Title already exists");
            return this;
        }

        if (comparisonResult < 0)
        {
            if (Left == null)
            {
                //Console.WriteLine($"Inserting {song.Title} to Left of {NodeSong.Title}");
                Left = new TreeNode(song);
            }
            else
            {
                Left = Left.InsertTitle(song);
            }
        }
        else
        {
            if (Right == null)
            {
                //Console.WriteLine($"Inserting {song.Title} to Right of {NodeSong.Title}");
                Right = new TreeNode(song);
            }
            else
            {
                Right = Right.InsertTitle(song);
            }
        }

        UpdateHeight();
        int balance = GetBalance();

        if (balance > 1)
        {
            if (string.Compare(song.Title, Left?.NodeSong.Title, StringComparison.OrdinalIgnoreCase) < 0)
                return RotateRight();
            else
            {
                Left = Left?.RotateLeft();
                return RotateRight();
            }
        }
        if (balance < -1)
        {
            if (string.Compare(song.Title, Right?.NodeSong.Title, StringComparison.OrdinalIgnoreCase) > 0)
                return RotateLeft();
            else
            {
                Right = Right?.RotateRight();
                return RotateLeft();
            }
        }

        return this;
    }

    public TreeNode InsertArtist(Song song)
    {
        int comparisonResult = string.Compare(song.Artist, NodeSong.Artist, StringComparison.OrdinalIgnoreCase);
        //Console.WriteLine($"Inserting: {song.Artist}, Current Node: {NodeSong.Artist}, Comparison: {comparisonResult}");

        if (comparisonResult == 0)
        {
            //Console.WriteLine("Artist already exists");
            return this;
        }

        if (comparisonResult < 0)
        {
            if (Left == null)
            {
                //Console.WriteLine($"Inserting {song.Artist} to Left of {NodeSong.Artist}");
                Left = new TreeNode(song);
            }
            else
            {
                Left = Left.InsertArtist(song);
            }
        }
        else
        {
            if (Right == null)
            {
                //Console.WriteLine($"Inserting {song.Artist} to Right of {NodeSong.Artist}");
                Right = new TreeNode(song);
            }
            else
            {
                Right = Right.InsertArtist(song);
            }
        }

        UpdateHeight();
        int balance = GetBalance();

        if (balance > 1)
        {
            if (string.Compare(song.Artist, Left?.NodeSong.Artist, StringComparison.OrdinalIgnoreCase) < 0)
                return RotateRight();
            else
            {
                Left = Left?.RotateLeft();
                return RotateRight();
            }
        }
        if (balance < -1)
        {
            if (string.Compare(song.Artist, Right?.NodeSong.Artist, StringComparison.OrdinalIgnoreCase) > 0)
                return RotateLeft();
            else
            {
                Right = Right?.RotateRight();
                return RotateLeft();
            }
        }

        return this;
    }


    public void UpdateHeight()
    {
        int leftHeight = Left?.Height ?? 0;
        int rightHeight = Right?.Height ?? 0;
        Height = 1 + Math.Max(leftHeight, rightHeight);
    }

    public int GetBalance()
    {
        int leftHeight = Left?.Height ?? 0;
        int rightHeight = Right?.Height ?? 0;
        return leftHeight - rightHeight;
    }

    private TreeNode RotateRight()
    {
        if (Left == null)
        {
            return this;
        }

        TreeNode newRoot = Left!;
        Left = newRoot.Right;
        newRoot.Right = this;

        UpdateHeight();
        newRoot.UpdateHeight();
        return newRoot;
    }

    private TreeNode RotateLeft()
    {
        if (Right == null)
        {
            return this;
        }

        TreeNode newRoot = Right!;

        Right = newRoot.Left;
        newRoot.Left = this;

        UpdateHeight();
        newRoot.UpdateHeight();
        return newRoot;
    }

    public void Display(string which)
    {
        if (Left != null)
        {
            Left.Display(which);
        }

        if (which.ToLower() == "title")
        {
            Console.WriteLine(NodeSong.Title + " ");
        }
        else if (which.ToLower() == "artist")
        {
            Console.WriteLine(NodeSong.Artist + " ");
        }
        else
        {
            Console.WriteLine(NodeSong);
        }

        if (Right != null)
        {
            Right.Display(which);
        }
    }

    public void Traverse()
    {
        if (Left != null)
        {
            Left.Traverse();
        }

        Console.WriteLine(NodeSong);

        if (Right != null)
        {
            Right.Traverse();
        }
    }


    public void SearchSongs(string input, List<Song> results)
    {
        if (NodeSong.Title != null && NodeSong.Artist != null)
        {
            if (NodeSong.Title.ToLower().Contains(input) || NodeSong.Artist.ToLower().Contains(input))
            {
                results.Add(NodeSong);
            }
        }
        
        if (Left != null)
        {
            Left.SearchSongs(input, results);
        }
        if (Right != null)
        {
            Right.SearchSongs(input, results);
        }
    }
}