// zdanie 1 //



//static double QuadraticEquation (double x = 0.0, double a = 1.0, double b = 1.0, double c= 1.0)
//{
//    return x*x*a + x*b + c ;
//}
//Console.WriteLine("funkcję zwracającą wartość równania kwadratowego (1.0,  2.0, 1.0)" + QuadraticEquation(1.0 , 2.0, 3.0,4.0));

// koniec zdania 1//


//zdanie 2//
//using System;

//class program
//{
//    static void Main()
//    {
//        void Swap(ref double a, ref double b)
//        {
//            double temp = a;
//            a = b;
//            b = temp;
//        }
//        double x = 10;
//        double y = 20;
//        Swap(ref x, ref y);
//        Console.WriteLine($"x = {x}, y = {y}");


//    }

//}

//koniec zdania 2//


//zdanie 3//

//using System;
//using System.Reflection.Metadata.Ecma335;

//class program
//{
//    static void Main(string[] args)
//    {
//        double Multiply(double x, double y)
//        {
//            return x * y;
//        }
//        double Multiply1(double x, double y, double z)
//        {
//            return x * y * z;
//        }


//       double Multiply2(params double[] a )
//        {
//            double result = 1.0;
//            foreach(double x in a)
//            { result *= x; }
//            return result;
//        }




//    }
//}





//koniec zdania 3//



//zdanie 4//


//static void PrintDayOfTheWeek(DayOfWeek day)
//{
//    Console.WriteLine(day);
//    if ((int)day >= 6)
//        Console.WriteLine("weekend!");
//    else
//        Console.WriteLine("workweek:-(");
//}


//string itemName = "eggplant";
//DateTime date = DateTime.Now;
//decimal price = 1.99m;
//Unit unit = Unit.item;
//Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");
//enum dayOfTheWeek
//{
//    Monday = 1,
//    Tuesday = 2,
//    Wednesday = 3,
//    Thursday = 4,
//    Friday = 5,
//    Saturday = 6,
//    Sunday = 7
//}
//enum Unit { item , kilogram , gram , dozen };



//koniec zdania 4//



// zdanie 5//
//using System;




//static void PrintDateTime(DateTime date)
//{
//    string customDateTime = $"{date.Day}...{date.Month}...{date.Year}...{date.Hour}...{date.Minute}";

//}






// koniec zdania 5//



//zdanie 6//


//using System;
//using System.Data;

//static void Main(string[] args)
//{
//    static double Divide(double a , double b)
//    {
//        if(b == 0.0)
//            throw new DivideByZeroException("b = 0.0 :(");
//    }

//    static double DivideSafe(double a, double b)
//    {

//        double result;
//        try
//        {
//            result = DivideSafe(a, b);

//        }

//        catch (DivideByZeroException ex)
//        {
//            result = 0.0;
//        }


//        return result;
//    }



//}




//koniec zdania 6//


// zdanie 7 //


static void SetYourNewPassword(string password)
{
    if (password == "" )
        throw new ArgumentNullException("Empty password");

    bool strongPassword = true;

    if (password.Contains())

        if (strongPassword)
            throw new FormatException("too weak password");
}









//koniec zdania 7//
