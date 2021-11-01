using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object object of LinkedList class
            LinkedList list = new LinkedList();
            //calling add method and provideing data
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //calling display method
            list.Display();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            Console.ReadLine();
        }
    }
}
