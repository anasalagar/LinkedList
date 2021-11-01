using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
 UC_9_Delete_Specific_Node
            //creating object object of LinkedList class
            LinkedList list = new LinkedList();
            //calling append method and provideing data         
            list.Append(56);
            list.Append(30);
            list.Append(70);
            //calling InsertAt method
            list.SearchAndInsertAfter(30, 40);
            list.Display();
            //calling search and delete method
            list.SearchAndDelete(40);
            //Display size of list
            Console.WriteLine("\nSize of list : "+list.Size());  
            Console.WriteLine();
            Console.ReadLine();

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


 main
        }
    }
}
