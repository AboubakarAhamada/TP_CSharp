using System;

namespace Generics
{
    class GenericClass<T>
    {
        //Constructor
        public GenericClass(T msg){
            Console.WriteLine(msg);
        }

        // Generic method :
        public void Show<U>(U msg){
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> str = new GenericClass<string>("I'm a string gay !");
            GenericClass<int> number = new GenericClass<int>(65);
            number.Show("Hello word");  // will print 'Hello word!'
            
        }
    }
}
