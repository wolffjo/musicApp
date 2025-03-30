using System.Transactions;

public class People
{
    public string Name;
    public string Number;
    public LinkedList<string> Messages = new LinkedList<string>();

    public People(string name, string number)
    {
        Name = name;
        Number = number;
    }

    public void AddMessage(string message)
    {
        Messages.AddLast(message);
    }

    public void DeleteMessage(string message)
    {
        if (Messages.Find(message) != null)
        {
            Messages.Remove(message);
        }
    }

    public void MoveMessage(string message, string location)
    {
        if (Messages.First != null)
        {
            Messages.Remove(message);
            LinkedListNode<string>? current = Messages.First;

            while (current != null)
            {
                if (current.Value == location)
                {
                    Messages.AddAfter(current, message);
                    return;
                }
                current = current.Next;
            }
        }
    }

    public void EditMessage(string oldMessage, string newMessage)
    {
        LinkedListNode<string>? node = Messages.Find(oldMessage);
        if (node != null)
        {
            node.Value = newMessage;
        }
    }
}