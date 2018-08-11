using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UtilitiesConsoleApp
{
    class Threading
    {
      static void Task1()
        { 
          Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        static void Thread1()
        {
            while (true)
            {
                Console.WriteLine("Calling thread 1");
            }
            
        }

        static void Thread2()
        {
            while (true)
            {
                Console.WriteLine("Calling thread 2");
            }
            
        }
    }


}
