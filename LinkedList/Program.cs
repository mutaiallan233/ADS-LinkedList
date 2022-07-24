namespace LinkedList
{
    class Program
    {               
        static void Main(string[] args)
        {
            MyList list = new MyList();

            /*myNode.next = new Node(11);
            myNode.next.next = new Node(12);
            myNode.next.next.next = new Node(5);
            myNode.print();*/

            /* Node myNode = new Node(7);            
             myNode.AddToEnd(11);
             myNode.AddToEnd(15);
             myNode.AddToEnd(12);
             myNode.AddToEnd(17);
             myNode.AddToEnd(13);
             myNode.print();*/

            /* list.AddToEnd(9);
             list.AddToEnd(10);
             list.AddToEnd(11);
             list.AddToEnd(34);
             list.Print();*/

           /* list.AddToBeginning(9);
            list.AddToBeginning(10);
            list.AddToBeginning(11);
            list.AddToBeginning(34);*/

            list.AddSorted(9);
            list.AddSorted(34);
            list.AddSorted(11);
            list.AddSorted(7);            
            list.AddSorted(6);
            list.Print();
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.print();
            }
            else
            {
                Console.Write("End||");
            }
        }
        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if(data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddToEnd(data);
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class MyList
    {
        //public int data;
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }
        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode= new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void AddSorted(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else if(data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void Print()
        {
            if(headNode != null)
            {
                headNode.print();
            }
        }
    }
}
