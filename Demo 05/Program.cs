namespace Demo_05
{
    class Hamada
    {

    }

    enum Grades
    {
        A, B, C, D, E, F
    }

    enum Gender
    {
        Male = 1, Female, M = 1, F = 2
    }

    // Byte = 8 bit => 0 : 255
    enum Branches : byte
    {
        Dokki = 200, NasrCity, Maadi = 252 /* Max */, Alex, SmartVillage, Benisuef
    }

    [Flags] // Data Annotaion
    enum Permissions : byte
    {
        Delete = 1, Execute = 2, Read = 4, Write = 8
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing , Unboxing

            //Object O = new Object();
            //O = "Ahmed";
            //O = 20; // Boxing [Casting from value type to reference type]
            //O = 'A'; // Boxing [Casting from value type to reference type]
            //O = new DateTime();
            //O = new Hamada();

            //int X = 10;

            //Object O1 = X; // Boxing (Implicit) (safe casting)
            //// Animal = Dog

            //Object O2 = 5;
            //int y = (int) O2; // Unboxing (explicit)  (Unsafe casting)
            //// Dog = (Dog) Animal


            #endregion

            #region Nullable Types

            //int[] Arr = null; // Valid
            //string Word = null; // Valid
            ////int x = null; // Invalid

            //int X = 20; // X allows integer value only (no null)
            //int? Y = null; // Y allows Integer value and null

            //double Num1 = 33.2; // Num1 allows double value only (no null)
            //double? Num2 = null; // Num2 allows dpuble value and null
            //// Num1 = null // invalid

            //// Nullable Type => Value Type Allow Null

            //int x = 5;
            //int? y = x; // Implicit Casting (Safe)

            //int? L = 77;
            ////int M = L; // Invalid
            //int M = (int)L; // Explicit Casting (Unsafe)


            //if (L is not null)
            //    M = (int)L;
            //else
            //    M = 0;


            //if (L.HasValue)
            //    M = (int)L.Value;
            //else
            //    M = 0;


            //M = L.HasValue ? L.Value : 0; // Syntax Sugar

            //// Null-Coalescing Operator

            //M = L ?? 0; // Syntax Sugar



            //double X = default; // 0
            //Console.WriteLine(X);

            //int[] Arr = default; // Null

            //for (int i = 0;/*(Arr != null) &&*/ (i < Arr?.Length); i++) // Invalid // Null Reference Exception
            //    Console.WriteLine(Arr[i]);

            //if (Arr != null)
            //{
            //    for (int i = 0;/*(Arr != null) &&*/ (i < Arr.Length); i++) // Invalid // Null Reference Exception
            //        Console.WriteLine(Arr[i]);
            //}

            //// Arr?.Length
            //// Arr != null ? Arr.length : Null;

            ////int? length = Arr?.Length;

            //int length = Arr?.Length ?? 0; // ?. -> null-conditional operator // ?? null-coalescing operator

            //// Employee?.Department?.Name
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
            #endregion

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

            #endregion
            #endregion
        }
    }
}
