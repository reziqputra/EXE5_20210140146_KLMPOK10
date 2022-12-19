using System;

namespace Exercise
{
    class Node
    {
        public int number;
        public string name;
        public Node next;
    }

    class Queue
    {
        Node reziq, putera;

        public Queue()
        {
            reziq = null;
            putera = null;
        }

        public void addNumb()
        {
            int no;
            string nm;
            Console.Write("Enter a number: ");
            no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a name: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.number = no;
            newnode.name = nm;
            if (reziq == null || (no <= reziq.number))
            {
                if ((reziq != null) && (no == reziq.number))
                {
                    Console.WriteLine("Duplicate number is not allowed");
                    return;
                }
                newnode.next = reziq;
                newnode.next = putera;
                reziq = putera = newnode;
                return;
            }
            while ((reziq != null) && (no >= putera.number))
            {
                if (no == putera.number)
                {
                    Console.WriteLine("Duplicate number is not allowed");
                    return;
                }
                putera.next = newnode;
                putera = newnode;
                return;
            }
        }
        public bool listEmpty()
        {
            if (reziq == null)
                return true;
            else
                return false;
        }

        public void delNumb()
        {
            Console.WriteLine("The deleted node is: " + reziq.number + " " + reziq.name);
            reziq = reziq.next;
        }

        public void displayNumb()
        {
            if (listEmpty())
            {
                Console.WriteLine("List is empty. ");
            }
            else
            {
                Console.WriteLine("The records in the list are: ");
                Node currNode;
                for (currNode = reziq; currNode != null; currNode = currNode.next)
                    Console.WriteLine(" - " + currNode.number + "." + currNode.name);
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n Menu ");
                    Console.WriteLine("a. Insert Record");
                    Console.WriteLine("b. Delete Record");
                    Console.WriteLine("c. Display");
                    Console.WriteLine("d. Exit");
                    Console.Write("Choice a-d :");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case 'a':
                            {
                                q.addNumb();
                            }
                            break;
                        case 'b':
                            {
                                if (q.listEmpty())
                                {
                                    Console.WriteLine("List is empty. ");
                                    break;
                                }
                                q.delNumb();
                            }
                            break;
                        case 'c':
                            {
                                q.displayNumb();
                            }
                            break;
                        case 'd':
                            return;
                        default:
                            {
                                Console.WriteLine("\n Invalid Option");
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n Check again!.");
                }
            }
        }
    }

}