using System;
using System.Threading;

class Print{

    public void PrintPairNumbers(){
        lock(this){
        for(int i =0; i<=10;i=i+2){
            Thread.Sleep(100);
            Console.WriteLine(i);
        }
        
    }
    }

    public void PrintImpairNumbers (){
        lock(this){
        for(int i =1; i<=10;i=i+2){
            Thread.Sleep(100);
            Console.WriteLine(i);
        }
    }
    }
}

namespace Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();

            Thread th1 = new Thread(new ThreadStart(print.PrintPairNumbers));
            Thread th2 = new Thread(new ThreadStart(print.PrintImpairNumbers));

            th1.Start();
            th2.Start();

        }
    }
}
