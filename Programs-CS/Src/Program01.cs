using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_CS.Src
{
    public class Program01
    {
        public Program01()
        {
            Console.WriteLine("\nOutput:");
            Console.WriteLine("\nCase 1:");
            A objA = new A();
            objA.Do();
            objA.Does();
            Console.WriteLine(objA.Name);

            Console.WriteLine("\nCase 2:");
            B objB = new B();
            objB.Do();
            objB.Does();
            Console.WriteLine(objB.Name);

            Console.WriteLine("\nCase 3:");
            A objAB = new B();
            objAB.Do();
            objAB.Does();
            Console.WriteLine(objAB.Name);

            // Console.WriteLine("Case 4:");
            // B ba = new A();  // Explicit Conversion

            Console.ReadLine();
        }
    }

    internal class A : IProperty
    {
        public A()
        {
            Console.WriteLine("A's constructor called");
        }

        public int id
        {
            get
            {
                return 1;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual string Name // inheritaed interface property that can be able to override in sub class and inheritaced by define as virtual
        {
            get
            {
                return "A's Name";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Do()
        {
            Console.WriteLine("A's Do() method called");
        }

        public virtual void Does()  // method that can be able to override in sub class
        {
            Console.WriteLine("A's Does() method called");
        }

        public void Dont() // hide A's Do() method inheritance
        {
            Console.WriteLine("B's Dont() method called");
        }
    }

    internal class B : A, IProperty // IProperty already defined in A class
    {
        public B()
        {
            Console.WriteLine("B's constructor called");
        }

        public override string Name
        {
            get
            {
                return "B's Name";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Do() // hide A's Do() method inheritance
        {
            base.Do(); // call A's Do() method
            Console.WriteLine("B's Do() method called");
        }

        public override void Does() // override A's Does()method
        {
            Console.WriteLine("B's Does() method called");
        }
    }

    internal interface IProperty : IRoot
    {
        int id { get; set; }
        string Name { get; set; }
        // virtual string Address { get; set; } // interface does not support virtual keyword
    }

    internal interface IRoot
    {
        void Do();
        void Dont();
    }
}
