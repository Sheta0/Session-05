using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        void Fun1()
        {
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB();

            //TypeA.X = 12 // Invalid => X is private
            typeA.Y = 12;
            typeA.Z = 12;
        }
    }
}
