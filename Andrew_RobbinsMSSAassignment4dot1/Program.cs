namespace MSSAassignment4dot1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 4.1.1
            //Console.WriteLine(EvenNums());

            #region Assignment 4.1.2
            // Console.WriteLine("Please type a year and press enter");
            //int y = Convert.ToInt32(Console.ReadLine());
            // IfYearIsLeap(y);
            #region Assignment 4.1.3
            Console.WriteLine("Give me string?");
            #region Assignment 4.1.4
            //  string stng = Console.ReadLine();
            // Console.WriteLine(StringInReverseOrder(stng));
            CountSpaces();
        }

        static string EvenNums()
        {
            string s = "";
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    s += i + " ";
                }
            }
            return s;
        }
        #endregion


        static void IfYearIsLeap(int y)
        {
            bool result = false;
            if (y % 4 == 0 && y % 100 != 0 || y % 4 == 0 && y % 100 == 0 && y % 400 == 0)
            {
                result = true;
                Console.WriteLine(y + " is a leap year " + result);
            }
            else
            {
                result = false;
                Console.Write(y + " is not a leap year " + result);
            }

        }
        #endregion
        static string StringInReverseOrder(string s)
        {
            char[] reverseme = s.ToCharArray();
            string back = string.Empty;
            for (int i = reverseme.Length - 1; i > -1; i--)
            {
                back += reverseme[i];

            }
            return "Your string backwards is " + back;
        }
        #endregion
        static void CountSpaces()
        {
            Console.WriteLine("Lets see how many spaces your sentence has. Please type a sentence");
            string spaces = Console.ReadLine();
            char[] spac = spaces.ToCharArray();
            int j = 0;
            for (int i = 0; i < spac.Length; i++)
            {
                if (spac[i] == ' ')
                {
                    j++;
                    j += 0;
                }
            }
            Console.WriteLine("This is a test string. contains " + j + " spaces");
        }
        #endregion

    }
}