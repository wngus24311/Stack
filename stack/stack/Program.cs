using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static Stack<int> numbers = new Stack<int>();

        static void Main(string[] args)
        {
            int x = 0;
            string str = "";
            int command = 0;
            int flag = 1;
            bool result = false;
            Program pgm = new Program();

            while(0 < flag && flag <= 10000 && result == false )
            {
                if (flag == 1)
                {
                    Console.WriteLine("Number of Command");
                    command = Convert.ToInt32(Console.ReadLine());

                    if(0 > command || command >= 10000)
                    {
                        result = true;
                        break;
                    }
                }

                Console.WriteLine("Choice one? Push or Pop or Size or Empty or Top ");
                str = Console.ReadLine();
                
                
                if(str == "Push")
                {
                    Console.WriteLine("Press Number");
                    x = Convert.ToInt32(Console.ReadLine());
                    pgm.DoPush(x);
                }
                else if(str == "Pop")
                {
                    pgm.DoPop();
                }
                else if(str == "Size")
                {
                    pgm.GetSize();
                }
                else if(str == "Empty")
                {
                    pgm.GetEmpty();
                }
                else
                {
                    pgm.GetTop();
                }

                if (flag == command)
                {
                    result = true;
                }
                flag++;
            }
            Console.ReadLine();
        }

        public  void DoPush(int x)
        {
            numbers.Push(x);
        }

        public  void DoPop()
        {
            int n;
            if (numbers.Contains(1) == true)
            {
                n = numbers.Pop();
                Console.WriteLine($"{n}");
            }
        }

         public  void GetSize()
         {
            Console.WriteLine(numbers.Count);
         }
 
         public  void GetEmpty()
         {
            Console.WriteLine(numbers.Contains(numbers.Count));
         }
 
         public  void GetTop()
         {
            Console.WriteLine(numbers.Peek());
         }
    }
}
