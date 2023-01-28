using System.Collections;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Enqueue("Lizi");
            queue.Enqueue("Andria");
            queue.Enqueue("Saba");
            queue.Enqueue("Gio");
            queue.Enqueue("Nini");
            queue.Enqueue("Elene");
            queue.Enqueue("Nika");

            foreach(object item in queue)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine();

            queue.Enqueue("Tekla");

            foreach (object item in queue)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
