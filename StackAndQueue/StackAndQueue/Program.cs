using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Stack Operations-------------");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("############Stack Operations################");
                Console.WriteLine("***1.Push operation***");
                Console.WriteLine("***2.Peak and Pop operation***");
                Console.WriteLine("3.************Queue Operations**************");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                Stack stack = new Stack();
                switch (num)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Show();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Pop();
                        stack.Show();
                        break;
                    case 3:
                        string flag1 = "Y";
                        while (flag1 == "Y" || flag1 == "y")
                        {
                            Console.WriteLine("***1.Queue Operation***");
                            Console.WriteLine("Enter the option");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Queue q = new Queue();
                            switch (num1)
                            {
                                case 1:
                                    q.Enqueue(56);
                                    q.Enqueue(30);
                                    q.Enqueue(70);
                                    q. Show();
                                    break;
                                case 2:
                                    q.Enqueue(56);
                                    q.Enqueue(30);
                                    q.Enqueue(70);
                                    q.Dequeue();
                                    q. Show();
                                    break;
                                default:
                                    Console.WriteLine("Enter a valid option");
                                    break;
                            }
                            Console.WriteLine("\nDo you want to continue?(Y/N)");
                            flag1 = Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
