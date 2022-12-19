namespace CircularQueuesUsingSingleLinkedList
{
        class Node
        {
            private int data { get; set; }
            public Node previous { get; set; }
            public Node(int val)
            {
                data = val;
                previous = null;
            }
        }
        class Queue
        {
            private Node Reziq, Putera, Prev = null;
        private int val;

        public Queue()
            {
                Reziq = Putera = null;
            }
            public void Insert()
            {
                Node n = new Node(val);
                if (Prev == null)
                {
                    Reziq = Putera = n;
                }
                else if (Reziq == Putera)
                {
                    Putera.previous = n;
                    Reziq = Putera.previous;
                }
                else
                {
                    Reziq.previous = n;
                    Reziq = Reziq.previous;
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}