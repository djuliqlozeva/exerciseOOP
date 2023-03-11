using exerciseOOP.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exerciseOOP.People;

namespace exerciseOOP
{
    //public, internal, private, protected  - niva na dostup
    internal class Person //po podrazbirane klasa e internal
    {
        //poleta, elementi, po podrazbirane sa private(vidimo e samo v tozi klas
        //private string name="Iva";
        //string family="Kostadinova";

        string name;
        string family;
        int age;
        double height;

        //string name = Console.ReadLine();
        //string family = Console.ReadLine();
        //int age = int.Parse(Console.ReadLine());
        //double height = double.Parse(Console.ReadLine());

        //constructuri
        public Person() { }
        
        
         // public Person()
         //{
            //Console.WriteLine("Vuvedi ime:");
           //name = Console.ReadLine();
           //Console.WriteLine("Vuvedi family:");
           // family = Console.ReadLine();
           //Console.WriteLine("Vuvedi age:");
           // age = int.Parse(Console.ReadLine());
           //Console.WriteLine("Vuvedi visochina:");
           //height = double.Parse(Console.ReadLine());

       // }

        public Person(string name, string family, int age, double height)
        {
            this.name = name;
            this.family = family;
            this.age = age;
            this.height = height;
        }

       
        public Person(string name, string family, double height)
        {
            this.name = name;
            this.family = family;
            this.age = 18;
            this.height = height;
        }

        public Person(string name, string family)
        {
            this.name = name;
            this.family = family;
        }


        //properties, te sa public
        public string Name
        {
            get { return name; }
            set { name = value; } //pozvolqva zadavane na nova stoinost
        }

        public int Age
        {
            get { return this.age; }
            set { this.age= value;}
        }

        public double Height
        {
            get { return this.height; }
            //set { this.age = value; }
        }

        public string Pol
        {
            get; set;
        }

        //methods, po podrazbirane e internal
        internal static  void PrintMessage()
        {
            Console.WriteLine("Tova e obekt ot class Person");
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"{name} {family} e na {age} godini i e visok{height} m.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //Person.PrintMessage();  
            //p1.PrintPersonInfo();

            //Person p2 = new Person();   
            //p2.PrintPersonInfo();

            Student s1 = new Student();

            Worker w1 = new Worker(); //trqbva da dobavim namespace na classa gore v using

            Person p3 = new Person("Petar", "Mladenov", 12, 1.45);
            Person p4 = new Person("Ivan", "Kostov", 44);
            Person p5 = new Person("Genadi", "Tomov");

            //if (p1.name == p2.name)
            //{
            //    Console.WriteLine("suvpada");
            //}
            //else
            //{
            //    Console.WriteLine(" ne suvpada");
            //}

            if (p3.Name == p4.Name)
            {
                Console.WriteLine("Imenata suvpadat");
            }
            else
            {
                Console.WriteLine("Imenata ne suvpadat");
            }

            p3.Name = "Ivan";
            p3.PrintPersonInfo();
            p4.PrintPersonInfo();

            
           Console.ReadKey();
            
        }
    }

    
    
}
