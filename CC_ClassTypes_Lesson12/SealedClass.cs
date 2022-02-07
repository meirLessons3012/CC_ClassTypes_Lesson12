using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ClassTypes_Lesson12
{

    public sealed class SealedClass
    {

    }
    public class NotSealedClass //: SealedClass => Error
    {
        public string Name { get; set; }
        public string phone;

        public virtual void Foo()
        {
            Console.WriteLine("Foo From SealedClass");
        }
    }

    public class InheritFromSealedClass : NotSealedClass
    {
        public string UserName { get; set; }
        public sealed override void Foo()
        {
            Console.WriteLine("Foo From InheritFromSealedClass");
        }
    }

    public class C : InheritFromSealedClass
    {
        public new string UserName { get; set; }

        public new void Foo()
        {
            Console.WriteLine("Foo From InheritFromSealedClass");
        }
    }

    public class D : InheritFromSealedClass
    {
        public new void Foo()
        {
            Console.WriteLine(UserName);
        }
    }
}
