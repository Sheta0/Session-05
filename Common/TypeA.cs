using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // Access Modifiers : C# Keyword Indicate the Accessibility Scope
    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    // 5. internal protected
    // 6. public

    // What Can We Write Inside the Namespace?
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    // Access Modifiers Can be used inside the Namespace: 
    // 1. internal => Inside the same project
    // 2. public   => Everywhere

    // Default Access Modifier inside Namespace is 'internal'

    // What Can we Write Inside The Class or Struct
    // 1. Attributes (Varibales)
    // 2. Methods (functions)
    // 3. Properties (Full Property - Automatic Property - Special Property [Indexer])
    // 4. Events

    // Access Modifiers Can be used inside a Class
    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    // 5. internal protected
    // 6. public

    // Access Modifiers Can be used inside a Struct
    // 1. private  => inside the same class
    // 2. internal => inside the same project
    // 3. public   => everywhere

    // Default Access Modifier inside Class and Struct is 'private'

    // What Can we write inside the interface?
    // 1. Signature of Methods (Name, Return Type, Parameter)
    // 2. Signature of Property
    // 3. Default Implemented Methods (C# 8.0 .NET Core 3.1)

    // Access Modifiers Can be used inside an Interface:
    // All Access Modifiers Except "private"

    // Default Access Modifier inside Interface is 'public'

    public class TypeA
    {
        private int X;
        internal int Y;
        public int Z;
        void Fun1()
        {
            TypeA typeA = new TypeA();
            typeA.X = X;
            typeA.Y = Y;
            typeA.Z = Z;
        }
    }
}
