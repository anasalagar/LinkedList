using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            list.InsertLast(50);
            list.InsertLast(30);
            list.InsertLast(70);

            Console.WriteLine("afete adding the new node list is");
            list.insertAfterNode(30, 40);
            list.display();
            list.size();
            Console.WriteLine("afete deleting specific node list is:");
            list.deleteSpecificNode(40);
            list.display();
            list.size();


        }
    }
}
