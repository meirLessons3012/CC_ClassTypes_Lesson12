using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ClassTypes_Lesson12
{
    public abstract class SuperSHapeBase
    {
        public abstract void DoWork();
    }
    
    public abstract class ShapeBase : SuperSHapeBase
    {
        public double height;
        public string Name { get; set; }

        protected ShapeBase(string name)
        {
            Name = name;
        }

        public string GetShapeName()
        {
            return Name;
        }

        public override void DoWork()
        {
            Console.WriteLine("do work...");
        }

        public abstract void CalcArea();
    }

    public class Circle : ShapeBase
    {
        public Circle(string name) : base(name)
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine(" calc area from circle");
        }


    }


    public class Rectangle : ShapeBase
    {
        public Rectangle(string name) : base(name)
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine(" calc area from rectangle");
        }
    }
}
