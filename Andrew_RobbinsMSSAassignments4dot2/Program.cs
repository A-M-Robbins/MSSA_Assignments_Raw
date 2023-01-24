

using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MSSAassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 4.2.1
            //MatrixArray(); 
            #endregion
            #region Assignment 4.2.2
            // MatricesAddition(); 
            #endregion
            #region Assignment 4.2.3
            // UserMenu(); 
            #endregion
            #region 4.2.4
            CircleCirc circ1 = new CircleCirc(60f); 
            CircleCirc circ2 = new CircleCirc(30f); 
            CircleCirc circ3 = circ1 + circ2;   // Not showing an error because of us overloading the addition operator
            CircleCirc circ4 = circ1 - circ2; // Not showing an error because of us overloading the subtraction operator
            Console.WriteLine("The area of the first circle is {0} \n" +
                "The area of the second circle is {1} \n" +
                "The sum of the area of the first circle and second circle is {2}\n" +
                "The difference between the area of first circle and the second circles is {3} \n",circ1.Show(),circ2.Show(),circ3.Show(),circ4.Show()); //Would probably make this section a method as it makes more sense
            #endregion
        }
        #region Assignment 4.2.1
        //static void MatrixArray()
        //{

        //    int[,] ar3 = new int[4, 3] { { 4, 1, 5 }, { 2, 2, 6 }, { 5, 3, 7 }, { 3, 2, 3 } };
        //    int rowHi = ar3.GetLength(0);
        //    int rowWi = ar3.GetLength(1);

        //    for (int i = 0; i < rowHi; i++)
        //    {
        //        for (int j = 0; j < rowWi; j++)
        //        {
        //            Console.Write(String.Format("| {0} ", ar3[i, j]));
        //            //Console.WriteLine();
        //        }
        //        Console.WriteLine("|");
        //    }
        //}
        //static void AddTheMatrices()
        //{
        //    Console.Write("Input the size of the square matrix (less than 5): ");
        //    int mSize = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.Write("element - [{0},{1}] : ", i, j);

        //        }
        //    }

        //}

        #endregion
        #region Assignment 4.2.2
        static void MatricesAddition()
        {
            int[,] ary1 = new int[10, 10];
            int a;
            Console.Write("Input the size of two identical square matrix's (less than 5): ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    ary1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a; i++)//Print a square Matrix
            {

                for (int j = 0; j < a; j++)//Print a square Matrix
                {
                    Console.Write(ary1[i, j] + "\t");  //Print a square Matrix
                }
                Console.WriteLine("\n");//Print a square Matrix
            }
            Console.ReadKey();//Print a square Matrix



            int[,] ary2 = new int[10, 10];

            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    ary2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a; i++)//Print the 2nd square Matrix
            {

                for (int j= 0; j< a; j++)//Print the 2nd square Matrix
                {
                    Console.Write(ary2[i, j] + "\t");  //Print the 2nd square Matrix
                }
                Console.WriteLine("\n");//Print the 2nd square Matrix
            }
            Console.ReadKey();//Print the 2nd square Matrix
            int[,] arrayAdd = new int[a, a];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arrayAdd[i, j] = ary1[i, j] + ary2[i, j];
                }
            }
            Console.WriteLine("The addition of two matrices is: ");
            for (int i = 0; i < a; i++)//Print the 2nd square Matrix
            {

                for (int j = 0; j < a; j++)//Print the 2nd square Matrix
                {
                    Console.Write(arrayAdd[i, j] + "\t");  //Print the 2nd square Matrix
                }
                Console.WriteLine("\n");//Print the 2nd square Matrix
            }



        }
        #endregion
        #region Assignment 4.2.3
        static void UserMenu()
        {
            Program pro = new Program();
            Console.WriteLine("What would you like to do today?" + "\n" +
                "1. Add Numbers \n" +
                "2. Multiply Numbers \n\n\n" +
                "Please press the cooresponding key and press enter ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the first number and press enter");
            int aa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the second number and press enter");
            int bb = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Would you like to include a 3rd number?" + "\n" +
                "Y or N");
            string ans = (Console.ReadLine());
            if (ans != "Y")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine(pro.Add(aa, bb));
                        break;
                    case 2:
                        Console.WriteLine(pro.Multiply(aa, bb));
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please type the second number and press enter");
                int cc = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 3:
                        Console.WriteLine(pro.Add(aa, bb, cc));
                        break;
                    case 4:
                       Console.WriteLine(pro.Multiply(aa, bb, cc));
                        break;
                }
            }



        }


        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Add(int a, int b, int c)
        {
            int d = a + b + c;
            return c;
        }
        public float Multiply(float a, float b)
        {
            float c = a * b;
            return (float)c;
        }
        public float Multiply(float a, float b, float c)
        {
            float d = a * b * c;
            return (float)d;
        }
        #endregion
    }
    #region Assignment 4.2.4

    class CircleCirc
    {

        private float _area;

        
        public CircleCirc( float area)
        {

            this._area = area;
        }
        public float Show()
        {
            return _area;
        }
        public static CircleCirc operator +(CircleCirc circ1, CircleCirc circ2)
        {
            CircleCirc addCircs = new CircleCirc(circ1._area + circ1._area);
            return addCircs;
        }
        public static CircleCirc operator -(CircleCirc circ1, CircleCirc circ2)
        {
            CircleCirc minusCircs = new CircleCirc(circ1._area - circ2._area);
            return minusCircs;
        }
        #endregion
    }

}




