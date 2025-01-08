//int num = 2147483647;
//long bigNum = 88888888888;
//string stringNum = "1024";


//long longValue = num;
//Console.WriteLine(bigNum);
//// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
//int integerValue = (int)bigNum;
//Console.WriteLine(bigNum);
//Console.WriteLine(integerValue);
//// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
//int intFromString = int.Parse(stringNum);
//Console.WriteLine(intFromString);
//// zbadaj zachowanie programu


//double firstValue, secondVAlue;

//Console.WriteLine("znaczenie 2");

//firstValue = double.Parse(Console.ReadLine());

//Console.WriteLine("znaczenie 1");

//secondVAlue = double.Parse(Console.ReadLine());

//double result = (firstValue + secondVAlue) / 2;
//Console.WriteLine("średnia " + result);



//int a = 4;
//int b = 5;

//bool result = a == b;



//bool isinfectedd  = false;

//if (isinfectedd)
//{
//    Console.WriteLine("you infected");
//}
//else
//{
//    Console.WriteLine("you not infected");






//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");

//        // Читаем ввод пользователя и преобразуем в целое число
//        string input = Console.ReadLine();

//        // Проверка, удалось ли преобразовать ввод в целое число
//        if (int.TryParse(input, out int number))
//        {
//            // Проверка на четность
//            if (number % 2 == 0)
//            {
//                Console.WriteLine($"{number} — четное число.");
//            }
//            else
//            {
//                Console.WriteLine($"{number} — нечетное число.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: введено не число.");
//        }
//    }
//}


//using System.Reflection.Metadata.Ecma335;

//static double QuadraticEquation(double x = 0, double a = 1, double b = 1, double c= 1)
//{
//    return x*x*a + x*b + c;
//}




//int n = 1;
//while (n >= 100)
//if ( n == 100)
//    {
//        Console.WriteLine("100");
//    }
//Console.ReadLine();

//using System;

//string[] numbers = [Console.ReadLine()];
// foreach (string number in numbers)
//{   
//    Console.Write($"{number} ");
//}


//using System;
//using System.Linq;
//public class Kata
//{
//    public static int FindSmallestInt(int[] args)
//    {
//        int min = args[0];
//        for (int i = 1; i < args.Length; i++)
//        {
//            if (min >= args[i])
//            {
//                min = args[i];
//            }
//        }
//        return min;
//    }
//}



