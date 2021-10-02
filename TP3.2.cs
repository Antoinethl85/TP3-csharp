using System;
using System.Threading;

namespace TP3
{
    class Exo2
    {
        private static Mutex mut = new Mutex();
        private const int numThreads = 3;

        public static void ThreadProc(){
            for
        }

        public static void Main(){

            Thread thread1 = new Thread(new ThreadStart(ThreadProc()));
            thread1.Name = String.Format("_");
            thread1.start();
            thread1.sleep(50);
            thread1.join();

            Thread thread2 = new Thread(new ThreadStart(ThreadProc()));
            thread2.Name = String.Format("*");
            thread2.start();
            thread2.sleep(40);
            thread2.join();
            
            Thread thread3 = new Thread(new ThreadStart(ThreadProc()));
            thread3.Name = String.Format("°");
            thread3.start();
            thread3.sleep(20);
            thread3.join();
        }
    }
}