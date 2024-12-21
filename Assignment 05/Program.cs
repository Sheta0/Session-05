
namespace Assignment_05
{

    #region Q1
    //enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //} 
    #endregion

    #region Q2

    //enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}

    #endregion

    #region Q4    
    //[Flags]
    //enum Permissions : byte
    //{
    //    delete = 1, execute = 2, read = 4, write = 8
    //} 
    #endregion

    #region Q5

    //enum Colors
    //{
    //    Red, Green, Blue
    //}

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //foreach (WeekDays Day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(Day);
            //}

            #endregion

            #region Q2

            //string SeasonInput;
            //Season SeasonOutput;
            //do
            //{
            //    Console.Write("Enter a season name : ");
            //    SeasonInput = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(SeasonInput) || !Enum.TryParse(SeasonInput, true, out SeasonOutput));


            //Console.WriteLine(SeasonOutput switch
            //{
            //    Season.Spring => "March to May",
            //    Season.Summer => "June to August",
            //    Season.Autumn => "September to November",
            //    Season.Winter => "December to February",
            //    _ => "Invalid Season Name"
            //});

            #endregion

            #region Q4
            //Permissions P1 = new Permissions();
            //P1 = (Permissions)3; // Giving Delete and execute permissions

            //Console.WriteLine(P1);

            //P1 ^= Permissions.write; // adding Write Permission

            //Console.WriteLine(P1);

            //P1 ^= Permissions.execute; // Removing Execute Permission

            //Console.WriteLine(P1);

            //// Checking if the Permission Execute exists
            //if ((P1 & Permissions.execute) == Permissions.execute) // 1001 & 0010 = 0000 // (0000 == 0010) // false
            //{
            //    Console.WriteLine("EXISTS");
            //}
            //else
            //    Console.WriteLine("DOESNT EXIST"); 
            #endregion

            #region Q5

            //string ColorInput;

            //do
            //{
            //    Console.Write("Enter a color name : ");
            //    ColorInput = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(ColorInput));

            //if (Enum.TryParse(ColorInput, true, out Colors ColorOutput))
            //{
            //    Console.WriteLine(ColorOutput switch
            //    {
            //        Colors.Red or Colors.Green or Colors.Blue => "This is a primary color.",
            //        _ => "Not a primary color."
            //    });
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input or Not a Primary Color");
            //}

            #endregion
        }
    }
}
