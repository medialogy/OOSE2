using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3

    // Her starter monkey class
{
    public class Monkey {
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

    public class ChimpMonkey : Monkey {

        public ChimpMonkey() { }
        public ChimpMonkey(int age, int height, int weight, string name) : base(age, height, weight) {
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
            ChimpMonkey M2 = new ChimpMonkey(20, 15, 56, "Hans");
            M1.Write();
            M2.Write();
           // stopper vindue 
            System.Console.ReadLine();            
        }
    }
}



