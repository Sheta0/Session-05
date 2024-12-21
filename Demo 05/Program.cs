using Common;

namespace Demo_05
{
    #region Enum

    //class Hamada
    //{
    //}

    //enum Grades
    //{
    //    A, B, C, D, E, F
    //}

    //enum Gender
    //{
    //    Male = 1, Female, M = 1, F = 2
    //}

    //// Byte = 8 bit => 0 : 255
    //enum Branches : byte
    //{
    //    Dokki = 200, NasrCity, Maadi = 252 /* Max */, Alex, SmartVillage, Benisuef
    //}

    //[Flags] // Data Annotaion
    //enum Permissions : byte
    //{
    //    Delete = 1, Execute = 2, Read = 4, Write = 8
    //}

    #endregion Enum

    internal class Program
    {
        #region Error Handling And Protective Code

        //public static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;

        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y; // DividedByZero

        //        int[] Arr = { 1, 2, 3 };
        //        //Arr[99] = 20; // IndexOutOfRange
        //    }
        //    catch (Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");

        //        // Release | Deallocate | Diconnect | Dispose UnManaged Resource (File, DB)
        //    }
        //}

        //private static void DoSomeProtectedCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        do
        //        {
        //            Console.Write("Enter the first Number : ");
        //        }
        //        while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.Write("Enter the Second Number : ");
        //        }
        //        while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

        //        z = x / y;

        //        int[] Arr = { 1, 2, 3 };

        //        if (Arr is not null)
        //        {
        //            int Index;
        //            do
        //            {
        //                Console.Write("Enter Index : ");
        //            }
        //            while (!int.TryParse(Console.ReadLine(), out Index));

        //            Arr[Index] = 100;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        #endregion Error Handling

        private static void Main(string[] args)
        {
            #region Revision

            ////// 1. Array => Fixed Size
            ////int[] Numbers = new int[5];

            ////Numbers[0] = 12;
            ////Numbers[4] = 30;

            ////// 2D Array // Jagged Array

            ////// 2. Functions => Block of Code => Inside Class or struct or interface

            //static void PrintShape()
            //{
            //}

            ////PrintShape();

            #endregion Revision

            #region Boxing , Unboxing

            //// Boxing => Casting from Datatype [Value Type] to Datatype [Reference Type]
            //// UnBoxing => Casting from Datatype [Reference Type] to Datatype [Value Type]

            //object O1;
            //// O1 : Can refer to Instance from 'Object' or any instance from any datatype

            //// Boxing

            //O1 = /*(object)*/ 1; // Casting from int [Value Type] to object [Reference Type]
            //O1 = /*(object)*/ 1.5; // Casting from double [Value Type] to object [Reference Type]

            //O1 = 20;
            //O1 = 'A';
            //O1 = new DateTime();
            //O = new Hamada();

            //int X = 10;

            //object O1 = /*(object)*/ X; // Implicit Casting (Safe Casting)
            //// Parent => Child
            //// Animal => Dog

            ////Unboxing

            //Object O2 = 5;
            //int y = (int)O2; // Explicit Casting (UnSafe Casting) => May Throw Exception
            //// Child => Parent
            //// Dog => (Dog) Animal

            #endregion Boxing , Unboxing

            #region Nullable Types

            #region Nullable Value Types

            //// Value Types
            //// Reference Types

            //// Value Types
            //int X = 12;
            //Console.WriteLine(X);

            //int Age = 30;
            //Age = null; // Invalid => int don't allow null as a valid value
            //Console.WriteLine(Age);

            //// Nullable Value Types => Allow null as a Valid Value

            //int? Age = 30; // Nullable<int> : Age => allow int value + null as a valid value
            //Age = null;
            //Console.WriteLine(Age);

            //double? Salary = 20000; // Nullable<double> : Age => allow double value + null as a valid value
            ////Salary = null;
            //Console.WriteLine(Salary);

            //int X = 12;
            //int? Y = /*(int?)*/ X; // Nullable<int> : Y => allow int value + null as a valid value
            //Console.WriteLine(Y);

            //int? X = 12;
            ////X = null;
            //int Y = (int) X; // Allows int value only
            //Console.WriteLine(Y);

            //// Protective Code
            //int? X = 12;
            ////X = null;
            //int Y;

            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;
            //Console.WriteLine(Y);

            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;
            //Console.WriteLine(Y);

            //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);

            //// Null-Coalescing Operator

            //Y = X ?? 0; // Syntax Sugar => Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);

            #endregion Nullable Value Types

            #region Nullable Reference Types (C# 10.0 Dotnet 6.0)

            //// Reference type => Allow Null as Valid
            //string Message01 = null; // Required
            //string? Message02 = null; // Optional
            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02);

            #endregion Nullable Reference Types (C# 10.0 Dotnet 6.0)

            #endregion Nullable Types

            #region Null Propagation Operator ?

            ////int[] Arr = default; // null
            //int[] Arr = { 1, 2, 3 };

            ////Console.WriteLine(Arr);

            ////// NullRefernceException

            ////for (int i = 0; (Arr is not null) i < Arr.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);
            ////}

            ////for (int i = 0; i < Arr?.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);
            ////}

            ////if(Arr is not null )
            ////{
            ////    for( int i = 0; i < Arr.Length; i++ )
            ////    {
            ////        Console.WriteLine(Arr[i]);
            ////    }
            ////}

            ////int Len = Arr is not null ? Arr.Length : 0;
            ////int? Len = Arr?.Length;
            ////int Len = Arr.Length is not null ? Arr.Length : 0;
            //int Len = Arr?.Length ?? 0;

            #endregion Null Propagition Operator ?

            #region Error Handling And Protective Code

            //// Exception Handling And Protective Code
            //// Exception => Runtime Error

            ////Console.WriteLine("Hello Before Exception");
            ////throw new Exception();
            ////Console.WriteLine("Hello after Exception");

            //DoSomeCode();
            //Console.WriteLine("Hello after exception");

            //// Exception:
            //// 1. SystemException
            //// 1.1. NullReferenceException
            //// 1.2. FormatException
            //// 1.3. ArthematicException
            //// 1.3.1 OverflowException
            //// 1.3.2 DivideByZeroException
            //// 1.4. IndexOutOfRangeException
            //// 2. ApplicationException

            //DoSomeProtectedCode();

            #endregion Error Handling

            #region Access Modifiers

            ////TypeA typeA = new TypeA(); // Invalid => not accessible => internal
            //TypeB typeB = new TypeB(); // Valid => accessible => punblic
            //TypeA typeA = new TypeA();
            //typeA.Y = 1; // Invalid X is private
            //typeA.Y = 12; // Invalid Y is internal
            //typeA.Z = 12;

            #endregion

            #region Enum

            #region EX01

            //Grades G = Grades.A;
            //Console.WriteLine(G);
            //if (G == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");

            //Gender G1 = Gender.Female;

            //G1 = (Gender)1;

            //Branches B = Branches.Maadi; // Maadi

            //Branches B = (Branches)233; // 233
            //Console.WriteLine(B);

            //Branches B2 = (Branches)280; // Invalid // Out of byte range

            #endregion EX01

            #region EX02

            //Permissions MyP = (Permissions) 6;
            ////MyP = (Permissions) 15;
            ////MyP = (Permissions) 16;
            //Console.WriteLine(MyP); // Read, Execute

            //// To Add Permission [Delete] => XOR Operation
            //MyP ^= Permissions.Delete; // 6 ^ 1 = 0110 ^ 0001 = 0111 = 7 => Read, Execute, Delete
            //Console.WriteLine(MyP);

            //// To Remove Permission [Read] => XOR Operation
            //MyP ^= Permissions.Read;  // 7 ^ 4 = 0111 ^ 0100 = 0011 = 3 => Execute, Delete
            //Console.WriteLine(MyP);

            //// To Check if a Permission [Delete] exists  or not => And Operation
            //if ((MyP & Permissions.Delete) == Permissions.Delete) // 3 & 1 = 0011 & 0001 = 0001  // (0001 == 0001) ==> true
            //    Console.WriteLine("Exists");
            //else
            //    Console.WriteLine("Doesn't Exist");

            //if ((MyP & Permissions.Write) == Permissions.Write) // 3 & 8 = 0011 & 1000 = 0000 // (0000 == 1000) => false
            //    Console.WriteLine("Exists");
            //else
            //    Console.WriteLine("Doesn't Exist");

            //// To Add Permission [Delete] => OR Operation
            //MyP |= Permissions.Write;
            //Console.WriteLine(MyP);

            //MyP |= Permissions.Write;
            //Console.WriteLine(MyP);
            //// XOR => Adds : if the permission doesn't exists
            ////        Removes : if the permission exists

            //// OR  => Adds : if the permission doesn't exists
            ////        Doesn't Change : if the permission exits

            #endregion EX02

            #endregion Enum

        }
    }
}