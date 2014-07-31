using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3

    // Her starter monkey class
{
    public abstract class AbstractMonkey { 
    //Abstract monkey code here. An abstract class can not be instantiated and is used to implement polymorphism.
    }

    public class Monkey { // Non Abstract class. A class is only abstract when declared as abstract.
        public int age;
        public int height;
        public int weight;

        public Monkey() { }
        public Monkey(int age, int height, int weight){
            
            
            
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
 
      public void Write()
      {        
          System.Console.WriteLine("Hello ZOO I am "+ this.age + " years of age, and i am "+ this.height +" tall and I weigh " + this.weight);
      }
    }

    // Her starter ChimpMonkey

    public class Human : Monkey { // Inheritance
        public Monkey friend; // Composition
        public Human() { }
        public Human(int age, int height, int weight, string name) : base(age, height, weight) {
            this.name = name;

        }
        public string name;
        public void Write()
        {
            System.Console.WriteLine("Hello ZOO I am " + this.age + " years of age, and i am " + this.height + " tall and I weigh " + this.weight+" My name is " + this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monkey M1 = new Monkey(2, 300, 300);
            Human M2 = new Human(20, 15, 56, "Hans");
            M1.Write();
            M2.Write();
           // stopper vindue 
            System.Console.ReadLine();            
        }
    }
}



