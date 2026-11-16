using System.Net.Http.Headers;

namespace Assignment_13._2
{
    internal class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList
        {
            Node Head;
            Node Tail;
            int size;

            public LinkedList()
            {
                Head = Tail = null;
                size =0;
            }

            bool IsEmpty {  get { return size == 0; } }

            public void Add(int data)
            {
                Node newNode = new Node(data);

                if (IsEmpty)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }
                size++;
            }

            public void ReverseRemove(int data)
            {
                if (IsEmpty) return;

                if (size == 1 && data == 1) Head = null;

                int remove = (size - data);
                int count = 1;
                if (remove < 0) return;


                Node temp = Head;
                while (temp != null)
                {
                    if(count == remove)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    count++;
                    temp = temp.Next;
                }

            }

            public void Display()
            {
                Node temp = Head;

                while(temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine('\n');
            }
        }

        static void LLMethod()
        {
            LinkedList LL = new LinkedList();
            LinkedList LL2 = new LinkedList();
            LinkedList LL3 = new LinkedList();

            int remove = 2;

            LL.Add(1);
            LL.Add(2);
            LL.Add(3);
            LL.Add(4);
            LL.Add(5);

            LL2.Add(1);

            LL3.Add(1);
            LL3.Add(2);

            Console.WriteLine("This Program removes a items starting from the last item in a LinkedList");


            Console.Write("Start: ");
            LL.Display();
            LL.ReverseRemove(remove);
            Console.Write($"Result (Remove {remove} of Last): ");
            LL.Display();


            remove = 1;
            Console.Write("Start: ");
            LL2.Display();
            LL2.ReverseRemove(remove);
            Console.Write($"Result (Remove {remove} of Last): ");
            LL2.Display();

            remove = 1;
            Console.Write("Start: ");
            LL3.Display();
            LL3.ReverseRemove(remove);
            Console.Write($"Result (Remove {remove} of Last): ");
            LL3.Display();

        }



        static void Main(string[] args)
        {
            LLMethod();
        }
    }
}
