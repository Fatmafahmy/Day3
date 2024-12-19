using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    #region Q22 complete
    //public class Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}
    #endregion
    private static void Main(string[] args)
    {
        #region Q1 number can be divided by 3 and 4
        //Console.WriteLine("Emter the Number");
        //int Number = int.Parse(Console.ReadLine());
        //if (Number % 3 == 0 && Number % 4 == 0)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}

        #endregion

        #region Q2  print nom negtive or postive
        //Console.WriteLine("Enter the Number");
        //int Number =int.Parse(Console.ReadLine());
        //if (Number < 0)
        //{
        //    Console.WriteLine("Negtive");
        //}
        //else
        //{
        //    Console.WriteLine("Postive");
        //}
        #endregion

        #region Q3 print min, max number
        //Console.WriteLine("Enter the First Number");
        //int Number1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the Second Number");
        //int Number2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the Third Number");
        //int Number3 = int.Parse(Console.ReadLine());
        //int max = Math.Max(Number1, Math.Max(Number2, Number3));
        //int min = Math.Min(Number1, Math.Min(Number2, Number3));
        //Console.WriteLine($"Max element = {max}");
        //Console.WriteLine($"Min element = {min}");

        #endregion

        #region Q4 check the number is even or odd
        //Console.WriteLine("Enter the Number");
        //int Number = int.Parse(Console.ReadLine());
        //if (Number % 2 == 0)
        //{
        //    Console.WriteLine("Even");
        //}
        //else
        //{
        //    Console.WriteLine("Odd");
        //}
        #endregion

        #region Q5 check the char is Vowel or consonant

        //Console.WriteLine("Enter the Char");
        //char character = char.Parse(Console.ReadLine());
        //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
        //{
        //    Console.WriteLine("Vowel");
        //}
        //else
        //{
        //    Console.WriteLine("consonant");
        //}
        #endregion

        #region Q7 insert an integer then  print a multiplication table up to 12
        //Console.WriteLine("Enter the Number");
        //int Number =int.Parse(Console.ReadLine());
        //for (int i = 1; i <= 12; i++) {
        //    Console.WriteLine($"{Number * i}");
        //}
        #endregion

        #region Q9 9 takes two integers then prints the power
        //Console.WriteLine("Enter the Base Number");
        //int BaseNumber = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the Base Power  Number");
        //int powerNumber = int.Parse(Console.ReadLine());
        //int result=1;
        //for (int i = 0; i < powerNumber; i++)
        //{
        //    result *= BaseNumber;
        //}
        //Console.WriteLine($"Result: {result}");

        #endregion

        #region Q10 enter marks of five subjects and calculate total, average and percentage
        //int[] marks =new int[5];
        //int total=0;
        //Console.WriteLine("enter marks of five subjects");
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine($"subject{ i+1}:");
        //    marks[i] = int.Parse(Console.ReadLine());
        //    total=total+ marks[i];
        //}
        //double avarage = total / 5.0;
        //double presantage = (total / 500.0) * 100;
        //Console.WriteLine($"total marks= {total}");
        //Console.WriteLine($"avarage marks ={avarage}");
        //Console.WriteLine($"presantage marks ={presantage}");
        #endregion

        #region Q11 input the month number and print the number of days in that month.
        //Console.WriteLine("Enter the Month Number");
        //int Mont_Number =int.Parse(Console.ReadLine());
        //if (Mont_Number == 1 || Mont_Number == 3 || Mont_Number == 5 || Mont_Number == 7 || Mont_Number == 8 || Mont_Number == 10 || Mont_Number == 12 )
        //{
        //    Console.WriteLine("days =31");
        //}
        //else if (Mont_Number == 4 || Mont_Number == 6 || Mont_Number == 9 || Mont_Number == 11 )
        //{
        //    Console.WriteLine("days = 30");
        // }
        //else
        //{
        //    Console.WriteLine("days = 28");
        //}
        #endregion

        #region Q17 input 3points determines whether these points lie on a single straight line
        //Console.WriteLine("x1");
        //double x1 =double.Parse(Console.ReadLine());
        //Console.WriteLine("y1");
        //double y1 = double.Parse(Console.ReadLine());
        //Console.WriteLine("x2");
        //double x2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("y2");
        //double y2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("x3");
        //double x3 = double.Parse(Console.ReadLine());
        //Console.WriteLine("y3");
        //double y3 = double.Parse(Console.ReadLine());
        // if ((x2 - x1) * (y3 - y2) == (y2 - y1) * (x3 - x2))

        //    {
        //    Console.WriteLine("these points lie on a single straight line");
        //    }
        // else
        //{
        //    Console.WriteLine("these points is not lie on a single straight line");
        //}

        #endregion

        #region Q18 calculate the efficiency of a worker, the time taken for the task 
        //Console.WriteLine("Enter the Hours you Works");
        //double hours =double.Parse(Console.ReadLine());
        //if (hours>=2 && hours<=3)
        //{
        //    Console.WriteLine("they are considered highly efficient");
        //}
        //else if  (hours >3 && hours <= 4)
        //{
        //    Console.WriteLine("they are instructed to increase their speed. ");
        //}
        //else if (hours > 4 && hours <= 5)
        //{
        //    Console.WriteLine("they are provided with training to enhance their speed. ");
        //}
        //else if (hours > 5 )
        //{
        //    Console.WriteLine("they are required to leave the company. ");
        //}
        #endregion

        #region Q21 chage value type

        //int x = 4;
        //int y = 9;
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //y = x; 
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        // variable y will change  in y value about x will cpyied into y 
        #endregion

        #region Q22 Referance Type

        //Point P1;
        //P1 = new Point();
        //Point P2 = new Point();
        //P2 = P1;
        //P1.X = 10;
        //Console.WriteLine(P2.X);
        //P2=P1 and p1 ,p2 will have the same address 
        #endregion

        #region Q23 which is Correct
        //int d;
        //d = Convert.ToInt32(!(30 < 20));
        //Console.WriteLine(d);
        // b)	A value 1 will be assigned to d.

        #endregion

        #region Q24  Which is correct
        //Console.WriteLine(13 / 2 + " " + 13 % 2);
        //  d)	6 1
        #endregion

        #region Q25 25-	What will be the output of the C# code given below?

        //int num = 1, z = 5;

        //if (!(num <= 0))
        //    Console.WriteLine(++num + z++ + " " + ++z);
        //else
        //    Console.WriteLine(--num + z-- + " " + --z);
        // d)	7 7

        #endregion


    }
}
