using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object object of LinkedList class
            LinkedList list = new LinkedList();
            //calling append method and provideing data         
            list.Append(56);
            list.Append(70);
            //calling display method
            //list.Display();
            list.InsertAt(2, 30);
            list.Display();
            Console.ReadLine();
        }
    }
}
