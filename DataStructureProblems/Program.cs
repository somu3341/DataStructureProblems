using System;
using System.Collections.Generic;

namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                LinkedList linkedList = new LinkedList();
                Console.WriteLine("\nChoose option to Perform \n1.Create Simple Linked List \n2.Reverse in Order " +
                    "\n3.Insert At Particular Position \n4.Delete First Element \n5.Delete Last Element \n6.Exit ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                        case 2:
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display();
                        break;
                        case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InserAtParticularPosition(1, 30);
                        linkedList.Display();
                        break;
                        case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display();
                        break;
                        case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        linkedList.Display();
                        break;
                        case 6:
                        flag = false;
                        break;

                }
            }
        }
    }
}