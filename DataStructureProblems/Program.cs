using System;
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
                Console.WriteLine("\nChoose option to Perform \n1.Create Simple Linked List \n2.Exit ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                        case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}