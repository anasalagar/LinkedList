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
            //calling InsertAt method
            list.InsertAt(2, 30);
            list.Display();
            Console.WriteLine();
            //calling delete method
            list.DeleteLast();
            list.Display();
            Console.ReadLine();
        }
    }
}
