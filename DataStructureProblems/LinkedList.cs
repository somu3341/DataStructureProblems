﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
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
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void InserAtParticularPosition(int position, int data)
        {
            Node newestnode = new Node(data);
            if (this.head == null)
            {
                this.head = newestnode;
            }
            if (position == 0)
            {
                newestnode.next = this.head;
                this.head = newestnode;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestnode.next = prev.next;
            prev.next = newestnode;
        }
    }
}
    