using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CustomLinkedList
    {
        public Node head;
        /// <summary>
        /// Inserts the node to the last.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            int key = new_node.data;
            if (this.head == null || key < this.head.data)
            {
                new_node.next = this.head;
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null && temp.next.data < key)
                {
                    temp = temp.next;
                }
                new_node.next = temp.next;
                temp.next = new_node;

            }
            Console.WriteLine("Node is Inserted in List" + new_node.data);
        }

        /// <summary>
        /// Gets the last node.
        /// </summary>
        /// <returns></returns>
       /* public Node getLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }*/

        /// <summary>
        /// Inserts the node to the first.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        /// <returns></returns>
        public void InsertFirst(int new_data)
        {

            Node new_node = new Node(new_data);

            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted into list" + new_node.data);


        }
        /// <summary>
        /// Appends the specified new data.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        /// <returns></returns>
        public void Append(int new_data)
        {

            InsertLast(new_data);
            Console.WriteLine("inserted into list" + new_data);
        }
        /// <summary>
        /// Specifics the postition.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public void specificPostition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("invalid position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                this.head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }

                }
                if (position != 1)
                {
                    Console.WriteLine("position is out of range");
                }

            }



        }

        /// <summary>
        /// Deletes the first node.
        /// </summary>
        public void deleteFirstNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");

            }
            if (this.head.next == null)
            {
                this.head = null;

            }
            else
            {

                this.head = head.next;


            }
        }

        /// <summary>
        /// Deletes the last node.
        /// </summary>
        /// <returns></returns>
        public int deleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;

            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;

            }
            int lastnode = newNode.next.data;
            newNode.next = null;
            return lastnode;

        }

        /// <summary>
        /// Searches the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public int Search(int value)
        {
            Node temp = this.head;
            int flag = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("{0} Node is present", value);
                    flag = 1;
                }

                temp = temp.next;
            }
            if (flag == 0)
            {
                Console.WriteLine("{0} Node is not present", value);
            }
            return value;

        }

        /// <summary>
        /// Inserts the node afetr specific node.
        /// 
        /// </summary>
        /// <param name="data">The previous node data.</param>
        /// <param name="newData">The new data.</param>
        public void insertAfterNode(int data, int newData)
        {
            Node temp = this.head;
            Node newNode = new Node(newData);

            while (temp != null)
            {
                if (temp.data == data)
                {
                    Node temp1 = temp.next;
                    temp.next = newNode;
                    newNode.next = temp1;
                    break;
                }
                temp = temp.next;
            }
        }

        /// <summary>
        /// Deletes the specific node.
        /// </summary>
        /// <param name="specificData">The specific data.</param>
        public void deleteSpecificNode(int specificData)
        {
            Node temp = this.head;

            while (temp != null)
            {
                if (temp.next.data == specificData)
                {
                    temp.next = temp.next.next;
                    break;
                }
                temp = temp.next;

            }

        }
        /// <summary>
        /// Display the all node in the list
        /// </summary>
        /// 
        public void size()
        {
            Node temp = this.head;
            int c = 0;
            while (temp != null)
            {
                //Console.WriteLine(" " + temp.data + " ");
                c++;
                temp = temp.next;

            }

            Console.WriteLine("size of linkedlist is: " + c);
        }
        public void display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {

                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;

                }

            }

        }

    }
}
