namespace calendar_events;
#pragma warning disable CS8602

public class EventList
{
    private class Node
    {
        public Event Value;
        public Node? Next;

        public Node(Event t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node? Head;

    public void GenericList()
    {
        Head = null;
    }

    public void Add(Event input) 
    {
        if (Head == null)
        {
            Head = new Node(input);            
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node? lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input);                        
        }
    }

    public void Print(string format)
    {
        Node? printNode = Head;
        while(printNode != null)
        {
            printNode.Value.PrintEvent(format);
            printNode = printNode.Next;
        }
        
    }

    public Event Index(int index)
    {
        Node? searchNode = Head;
        for(int i = 0; i < index; i++)
        {
            if(searchNode.Next != null)
            {
                searchNode = searchNode.Next;
                continue;
            }
            else
            {
                throw new InvalidOperationException("Não há elementos suficientes na lista");
            }
        }
        return searchNode.Value;
    }

    public int SearchByTitle(string title)
    {
        Node? printNode = Head;
        int i = 0;
        while(printNode != null)
        {
            if(printNode.Value.Title == title) return i;
            printNode = printNode.Next;
            i++;
        }
        return -1;     
    }

    public int SearchByDate(string dateSearch)
    {
        var dateArray = dateSearch.Split('-');
        var date = new DateTime(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[2]));
        Node? printNode = Head;
        int i = 0;
        while(printNode != null)
        {
            if(printNode.Value.EventDate == date) return i;
            printNode = printNode.Next;
            i++;
        }
        return -1;   
    }
    
}