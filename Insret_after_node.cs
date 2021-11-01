using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// linked list program
    /// </summary> 
    public class LinkedList
    {
        //Creating head variable of node class
        internal Node head;
        public int place;
        //creating add method for adding
        internal void Add(int data)
        {
            //creating node object for Node class
            Node node = new Node(data);
            //This if condition for checking head is null or not
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                //linking nodes 
                temp.next = node;
            }
            //Display inserted element
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        //creating display method to show list
        internal void Display()
        {
            Node temp = this.head;
            //if condition for checking head is null or not
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                //for display linked list
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //Creating Add method to adding element to link list
        internal void AddFirst(int data)
        {
            //creating a node object of the Node class
            Node node = new Node(data);
            //if condition for checking head is null or not  
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;

            }
            //linking elements
            this.head = node;
            Console.WriteLine("{0} inserted into linked list", node.data);

        }
        //creating append method for adding element to llinked list
        internal void Append(int data)
        {
            //creating a node object of the Node class
            Node node = new Node(data);
            //if condition for checking head is null or not
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                //linking nodes
                temp.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        //this InsertAt method for insert at any position 
        internal void InsertAt(int position, int data)
        {
            //Creating object of node class
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid position");
            else
            {
                Node temp = head;
                while (position != 2)
                {
                    temp = temp.next;
                    position--;
                }
                //Linking nodes 
                node.next = temp.next;
                temp.next = node;
            }
        }
        //This method for delete first node
        internal void DeleteFirst()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty");
            //for show deleted node
            Console.WriteLine("Deleted node : " + this.head.data);
            //assigning next node address to the head node
            this.head = this.head.next;
        }
        //this method for delete last node from linked list
        internal void DeleteLast()
        {
            Node new_node = this.head;
            //checking last element is null or not using while loop
            {
                while (new_node.next.next != null)
                    new_node = new_node.next;
            }
            Console.WriteLine("The deleted node is: " + new_node.next.data);
            new_node.next = null;
        }
        //This search method for finding elements in list
        public Node Search(int data)
        {
            //while loop for checking element up to last element
            while (this.head != null)
            {
                //if condition for matching data value with element from list
                if (this.head.data == data)
                {
                    Console.WriteLine("Element is found");
                    return this.head;
                }
                //incrementing head value       
                this.head = this.head.next;
            }
            return null;
        }
        //This method for searching element and adding another element after that element 
        public void SearchAndInsertAfter(int data, int element)
        {
            Node temp = this.head;
            Node newNode = new Node(element);

            while (temp != null)
            {
                //if condition for finding element
                if (temp.data == data)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} Element Is Found", 30);
                    Console.WriteLine("Adding element {0} after {1}",40,30);
                    //inserting new element
                    Node temp1 = temp.next;
                    temp.next = newNode;
                    newNode.next = temp1;
                    break;
                }
                temp = temp.next;
            }
        }
    } 
}
