using System;
using Microsoft.VisualBasic;

namespace task_2
{
    internal class Program
    {
        class Point
        {
            public int x;
            public int y;
        }
        static void Main()
        {

            #region problem_1
            ///* crate interger varible x = 10
            //     y =20 */
            //int x = 10;
            //int y = 20;
            //// add x to y and store them in the integer varible called sum
            //int sum = x + y;
            ////write the sum as output in the console
            //Console.WriteLine(sum); 
            #endregion


            #region Question_1
            /*the shortcut to comment and uncomment
                    ctrl + / 
                */
            #endregion


            #region problem_2
            ///* you can't sotre sting in integer var
            //y is not declared
            //*/
            ////int x = "10";
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y); 
            #endregion

            #region Q_2
            /*
                 runtime error happening during the program 
                 excution ex: invalid operation
                */
            //int x = 1 / 0;
            /*
             logical error a mistake in the logic of the code
             lead to incorrect output
            */
            //int l = 1;
            //int areaOfRec = 1 + 1 + 1 + 1; // it should be 1*1 
            #endregion

            #region P_3
            //string fullName = "Ayesh Mohammed";
            //int age = 25;
            //double monthlySalary = 000.0;
            //bool isStudent = true; 
            #endregion

            #region Q_3
            /*
                 it's make easy to read or debug the code and in general 
                 the team members should follow a standared and cetain naming convention
                */
            #endregion

            #region P_4
            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 1;
            p2.x = 2;
            p1.y = 3;
            p2.y = 4;
            p2 = p1;

            p2.x = 6;
            Console.WriteLine(p2.x);
            Console.WriteLine(p1.x);
            #endregion


            #region P_5
            //int x = 15;
            //int y = 4;
            //int sub = x - y;
            //int pro = x * y;
            //int div = x / y;
            //int rem = x % y; 
            #endregion


            #region Q_5
            //int a = 2, b = 7;
            //Console.WriteLine(a % b); // 2
            //// a < b  
            #endregion

            #region P_6
            //int x = 15;
            //if (x > 10 && x % 2 == 0) 
            //{
            //    Console.WriteLine("even");
            //} 
            #endregion

            #region Q_6
            //logical
            //if (3 > 0 && 4 < 10)
            //{
            //    Console.WriteLine("logical");
            //}

            //// bitwise
            //int u = 6 & 3; //2

            #endregion


            #region P_7

            //Console.Write("Enter a double value: ");
            //double doubleValue = double.Parse(Console.ReadLine());
            //int explicitCast = (int)doubleValue;
            //int implicitAlternative = Convert.ToInt32(doubleValue);
            //Console.WriteLine($"Original double value: {doubleValue}");
            //Console.WriteLine($"After explicit casting (truncates): {explicitCast}");
            //Console.WriteLine($"After Convert.ToInt32 (rounds): {implicitAlternative}"); 
            #endregion


            #region Q_7

            //because the conversion involves data loss

            #endregion


            #region P_8
            int x = 3;
            Console.WriteLine(x++); // 3
            Console.WriteLine(++x); // 5
            Console.WriteLine(--x); // 4
            Console.WriteLine(x--); // 4 
            #endregion


        }
    }
}
