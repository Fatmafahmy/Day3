using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
     static void Main(string[] args)
    {
        #region Value Type Casting
        #region Implicit Casting - Safe Casting
        //int x = 4; //4 Bytes
        //long y = /* (long)*/x;

        //int x = 88;
        //double y = x;
        //Console.WriteLine(y);
        #endregion
        #region Emplicit Casting - UnSafe Casting
        //long x = 101010101011011010; //8 Bytes
        //int y;
        //checked
        //{
        //     y = (int)x;
        //}
        //Console.WriteLine(y);
        //double x = 88.8; 
        //int y =(int) x; /*88*/
        //Console.WriteLine(y);
        #endregion
        #region Parce [Convert from String to any Datatype]
        //int Number = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter Data User");

        //Console.Write("Enter the Name: ");
        //string Name = Console.ReadLine();

        //Console.Write("Enter Age: ");
        //int Age = int.Parse(Console.ReadLine());

        //Console.Write("Enter Salary: ");
        //double Salary = double.Parse(Console.ReadLine());

        //Console.Clear();

        //Console.WriteLine("Name : " + Name + "Age : " + Age + "Salary : " + Salary );

        #endregion
        #region Convrt 
        //Console.Write("Enter Age: ");
        //int Age = Convert .ToInt32(Console.ReadLine());

        //Console.Write("Enter Salary: ");
        //double Salary = Convert.ToDouble(Console.ReadLine());

        #endregion
        #endregion

        #region Oprator
        #region Unary operator
        //int x = 5;
        //x++; // Post fix Increament After Print
        //++x; // Pre fix Increament before Print
        //Console.WriteLine(++x);
        //Console.WriteLine(x++);
        //Console.WriteLine(x--);
        //Console.WriteLine(--x);
        #endregion
        #region Binary Opreator
        //int Sum, Mul, Sub, Div, Mod;
        //int A = 10;
        //int B = 5;

        //Sum = A + B;//15
        //Sub = A - B; //5
        //Div = A / B;//2
        //Mul = A * B;//50
        //Mod = A % B;
        //Console.WriteLine(Sum);
        #endregion
        #region Assigment Operator
        //int x = 10;

        //x += 10;//x=x+10
        //x-= 10;
        //x *= 10;
        //x /= 10;
        //x %= 10;
        #endregion
        #region Relational Operator
        //int A = 5;
        //int B = 10;
        //Console.WriteLine(A < B);
        #endregion
        #region Logical Operator (short circut) // check to the first word
        //Console.WriteLine(!true);

        //Console.WriteLine(true &false);
        //true & true=> true
        //true & false => false
        //false & true => false
        //false & false => false

        //Console.WriteLine(true| false);
        //true | true=> true
        //true | false => true
        //false |true => true
        //false | false => false
        #endregion

        #region Bitwise  Operator (Long circut)
        //Console.WriteLine(true&&false);
        //true && true=> true
        //true && false => false
        //false && true => false
        //false && false => false

        //Console.WriteLine(true|| false);
        //true || true=> true
        //true || false => true
        //false ||true => true
        //false || false => false
        #endregion
        #region Ternary Operator [Condational Operator]
        //4
        //int x = 4;
        //string Message = x > 4 ? " x Greater Than 4" : "Less Than Or Equal 4";
        #endregion
        #endregion
        #region Operator Periorety
        /*
          1. Unary operator [Pre fix]
          2.()
        3. * / %
        4. + -
         */

        //int A = 20;
        //int B = 15;
        //int C = 10;
        //int D = 5;

        //int Result;

        //Result = (A + B) * C / D;
        //Result = A++ * C;
        //Console.WriteLine(Result);
        #endregion

        #region  String Formating
        // Equation = x+y = result
        // Equation  10+5 =15
        //int x = 5;
        //int y = 10; 
        //int Result = x + y;
        //Console.WriteLine( "Eqyation :"+x + " + " +y+" = "+Result);
        //// String => Imutable Data type
        //String Name = "Ahmed";
        //Name = "Ali";

        #region 1. Composite Format
        //string Message = string.Format("Equation = {0}+ {1} ={2}", x, y, Result);
        //Console.WriteLine(Message);
        //Console.WriteLine("Equation = {0}+ {1} ={2}", x, y, Result);
        #endregion

        #region 2.String Manipolition
        //String Interpolation => $

        //Console.WriteLine($"Equation = , {x}, { y}, { Result}");
        #endregion

        #endregion

        #region IF Else - Switch Case
        //Console.WriteLine("Enter Month Number");
        //int MonthNumber = int.Parse(Console.ReadLine());
        //1 => Month is Jan
        //2 => Month is Feb
        //3 => Month is Mar
        //Invaled  input

        #region if
        //if (NonthNumber == 1)
        //{
        //    Console.WriteLine("Month is Jan");
        //}
        //else if (NonthNumber == 2)
        //{
        //    Console.WriteLine("Month is Jan");
        //}
        //else if (NonthNumber == 3)
        //{
        //    Console.WriteLine("Month is Mar");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Input");
        //}
        #endregion
        #region Switch
        //switch (MonthNumber)
        //{ 
        //case 1:
        //        Console.WriteLine("Month is Jan");
        //        break;
        //        case 2:
        //        Console.WriteLine("Month is Fab");
        //        break;
        //        case 3:
        //        Console.WriteLine("Month is Mar");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Input");
        //        break;
        //}

        #endregion

        //Console.WriteLine("Enter Name");
        //string Name = Console.ReadLine();

        //if (Name == "Mostafa")
        //{
        //    Console.WriteLine("Hallow Mostafa");
        //}
        //else if (Name == "Aliaa")
        //{
        //    Console.WriteLine("Hallow Aliaa");
        //}
        //else if (Name == "Ahmed")
        //{
        //    Console.WriteLine("Hallow Ahmed");
        //}

        //switch(Name)
        //{
        //    case "Mostafa ":
        //        Console.WriteLine("Hallow Mostafa");
        //        break;
        //    case "Aliaa":
        //        Console.WriteLine("Hallow Aliaa");
        //        break;
        //    case "Ahmed":
        //        Console.WriteLine("Hallow Ahmed");
        //        break;
        //}
        #endregion

        #region GoTo
        // Console.WriteLine("Enter Option");
        // 3000 => option 01, option 2 , option 3
        //2000 => opyion 01, option 2
        //1000 => opyion 01

        // int opetion = int.Parse(Console.ReadLine());

        //switch (opetion)
        //{
        //    case 3000:
        //        Console.WriteLine("option 3");
        //        Console.WriteLine("option 2");
        //        Console.WriteLine("option 1");
        //        break;
        //    case 2000:
        //        Console.WriteLine("option 2");
        //        Console.WriteLine("option 1");
        //        break;
        //    case 1000:
        //        Console.WriteLine("option 1");
        //        break;
        //}

        //switch (opetion)
        //{
        //    case 3000:
        //        Console.WriteLine("option 3");
        //        goto case 2000;
        //    case 2000:
        //        Console.WriteLine("option 2");
        //        goto case 1000;
        //    case 1000:
        //        Console.WriteLine("option 1");
        //        break;
        //}

        #endregion

        #region evaluation off switch case

        #region c# 6
        //Console.WriteLine("Enter Age");
        //int Age = int.Parse(Console.ReadLine());

        //switch (Age)
        //{
        //    case > 22:
        //        Console.WriteLine("Age Greater Than 22");
        //        break;
        //    case < 22:
        //        Console.WriteLine("Age Is Less Than 22");
        //        break;
        //   default:
        //        Console.WriteLine("Age is 22");
        //        break;
        //}
        #endregion

        #region c#7
        // object obj = new object();
        //obj = "Mostfa";
        //obj = 10;
        //obj = true;

        //switch(obj)
        //{
        //    case int Number when Number >10 && Number<20:
        //        Console.WriteLine($"{Number} is int");
        //        break;
        //      case string Name:
        //        Console.WriteLine($"{Name} is string");
        //        break;
        //      case bool Flag:
        //        Console.WriteLine($"{Flag} is Bool");
        //        break;
        // }
        #endregion

        #region c#8
        //Console.WriteLine("Enter Option");
        //int Option = int.Parse(Console.ReadLine());
        //string Message = Option switch
        //{
        //    1 => "option 1",
        //    2 => "option 2",
        //    3 => "option 3",
        //    _ => "Invalid"
        //};

    #endregion
    #endregion
}
}