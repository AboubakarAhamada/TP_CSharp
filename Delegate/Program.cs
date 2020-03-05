using System;

namespace Delegate
{
    class Program
    {
        //Declaration du delegate :
    public delegate void Print(int value);

    public static void  Main(string[] args){

        Print printDel = PrintNumber;
        printDel(10000);
        printDel(500000);

        printDel = PrintMoney;
        printDel(10000);
        printDel(500000);

        //Pass delegate as parameters :
        helpPrinter(PrintNumber,30);
        helpPrinter(PrintMoney,1500);

    }

    public static void PrintNumber(int number){
        Console.WriteLine("Number : {0, -12:N0} ",number);
    }

    public static void PrintMoney(int money){
        Console.WriteLine("Money : {0:C} ", money);
    }

    public static void helpPrinter(Print delegateFunc, int value){
        delegateFunc(value);
    }

    }
}
