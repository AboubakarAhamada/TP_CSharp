using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{

    [Serializable] // Indique que cette class est serializable
    class Person{
        public string fullName{get;set;}
        public string adress {get;set;}
        public string job {get;set;}
        public int age {get;set;}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.fullName = "Toni Kroos";
            person.adress = "Samewhere in Madrid";
            person.age= 29;
            person.job = "Football player";

            // Serialization :
            IFormatter f = new BinaryFormatter();
            Stream str = new FileStream(@"./resources/SerializableFile.txt", FileMode.Create, FileAccess.Write);
            f.Serialize(str,person);
            str.Close();

            // Deserialization :
            str = new FileStream(@"./resources/SerializableFile.txt", FileMode.Open, FileAccess.Read);
            
            Person p = (Person)f.Deserialize(str);

            Console.WriteLine("Person's fullname : "+p.fullName);
            Console.WriteLine("Person's adress : "+p.adress);
            Console.WriteLine("Person's age : "+p.age);
            Console.WriteLine("Person's job : "+p.job);

            
        }
    }
}
