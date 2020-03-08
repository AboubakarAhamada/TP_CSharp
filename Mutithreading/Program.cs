using System;
using System.Threading;

class ThreadClass{
    public void Thread1(){
        for( int i= 0; i<5; i++)
            Console.WriteLine("Thread1: "+i);
        
    }

    public static void Thread2(){
        for(int i= 0; i<5;i++)
            Console.WriteLine("Thread2 : Hello World !");
        //Thread.Sleep(200);
    }

    public void Thread3(){
        for( int i=0;i<5;i++)
            Console.WriteLine("Thread3 : Bonjour tout le monde");
    }
}

namespace Mutithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass threadObject = new ThreadClass(); 

            Thread th1 = new Thread(new ThreadStart(threadObject.Thread1));
            Thread th2 = new Thread(new ThreadStart(ThreadClass.Thread2)); // thread2() is a static method.
            Thread th3 = new Thread(new ThreadStart(threadObject.Thread3));


            th1.Start();
            th1.Join();     // Bloque tous les autres threads jusqu'à ce qu'il termine son execution.
            th2.Start();
            th3.Start(); 

        }
    }
}
