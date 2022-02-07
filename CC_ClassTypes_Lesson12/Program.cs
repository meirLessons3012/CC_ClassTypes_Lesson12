using System;

namespace CC_ClassTypes_Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Abstract Class

            ShapeBase circle = new Circle("circle1");
            circle.Name = "";

            ShapeBase shapeBase = new Rectangle("rec2");
            shapeBase.DoWork();

            Circle c = new Circle("circle1");
            Rectangle r = new Rectangle("Rectangle");
            c.DoWork();

            ShapeBase[] shapes = new ShapeBase[2];
            shapes[0] = circle;
            shapes[1] = r;

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].CalcArea();
            }

            #endregion

            #region Static class

            NormalClass nc = new NormalClass();
            //nc.MyProperty = 13;
            NormalClass.MyProperty += 1;
            //Console.WriteLine(NormalClass.NAME);
            NormalClass nc2 = new NormalClass();
            
            UserManagment.Users = new User[10];
            if(UserManagment.ValidatePassword("912873qjdl"))
            {
                //
                //
                //
            }

            #endregion

            //[C]reate
            //[R]ead
            //[U]pdate
            //[D]elete


        }

        public static void CalcShape
    }
}
