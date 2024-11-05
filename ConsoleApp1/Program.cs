/*zdanie 1*/

//using System.Security.Cryptography.X509Certificates;

//int n = 10;
//do
//{
//    Console.Write(n);
//    n-- ;
//}  while (n > -1);
/* koniec zdania 1*/



/*zdanie 2*/


//string hasło;

//do
//{
//    Console.Write("Prosze podać hasło: ");
//    hasło = Console.ReadLine();
//} while (hasło != "koniec");
/* koniec zdania 2*/




/*zdanie 3*/

//using System.Linq.Expressions;
//using System.Reflection.PortableExecutable;

//int n = 1;
//while (n <= 100)
//{
//    if (n % 1 == 0)
//    {
//        Console.WriteLine($"od 1 do 100: {n} ");
//
//    }
//    n++;
//}





//jak zrobli na zajeciu 
//t j = 1;
//Console.WriteLine("Liczby parzyste:");
//ile (j <= 100)
//{
//  if (j % 2 == 0)
//      Console.WriteLine(j);
//  j++;
//}







/* koniec zdania 3*/


/*zdanie 4*/

//int n = 0 ;
//for (int i = 0; i <= 15; i++)
//{
//    int potenga = i * i;
//    Console.WriteLine($"potenga :  { potenga}");
//}

/*koniec zdania 4*/




/* zdanie 5*/



//using System.Collections.Generic;
//using System.Linq.Expressions;

//List<int> numbers = new List<int>()  { 4, 25, 35, 42, 55, 78, 99, 101 };
//
//foreach (int element in numbers)
//{
//
//    Console.WriteLine(element % 7 == 0);
//      
//}
//

/*koniec zdania 5*/




/*zdanie 6*/
//List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
//
//foreach (int element in numbers)
//{
//    if (element % 7 == 0)
//    {
//        Console.WriteLine(element);
//        break;
//    }
//}
/*koniec zdania 6*/




/*zdanie 7*/


//double[] dArray = new double[20];
//for (int i = 0; i < 20; i++)
//{
//    dArray[i] = Math.Sqrt(i);
//    Console.WriteLine("i : " + dArray[i]);
//}


/*koniec zdania 7*/



/*zdanie 8*/

//int[,] macierz = new int[3, 4];
//wypełnienie danych
//int liczba = 1;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        macierz[i, j] = liczba++;
//
//    } 
//}

// ukazanie macierzy po transpozycji 

//for (int i = 0;i< 3; i++)
//{
//    for(int j = 0;j < 4; j++)
//    {
//        Console.WriteLine(macierz[i, j] +"\t");
//    }
//    Console.WriteLine();
//}


/*koniec zdania 8*/



/*zdanie 10*/


//void PrintUpperCase(string txt)
//{
//    Console.WriteLine(txt.ToUpper() );
//
//}


/*koniec zdania 10*/

/*zdanie 11*/




///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




/*koniec zdania 11*/

/*zdanie 12*/

//string EvenOrOdd1(int toCheck)
//{
//    string retStr = "";
//    if (toCheck % 2 == 0)
//    {
//        retStr = "even";
//    }
//    else
//    {
//        retStr = "Odd";
//    }
//    return retStr;
//}


//string EvenOrOdd2(int toCheck)
//{
//    if (toCheck % 2 == 0)
//        return "even";
//    else
//        return "Odd";
//}


//        string EvenOrOdd3(int toCheck)
//{
//    return toCheck % 2 == 0 ? "even" : "Odd";
//}

/* koniec zdania 12*/


/*zdanie 13*/

//void PrintConsoleSquare(int x , int y)
{
    //rysuj gorna krawedz 
    //    for (int i = 0; i < x; i++)
    //        Console.Write("$");

    //zejdz do nowej linii
    //    Console.WriteLine();

    //rysuj srodek (boki)
    //    for (int i = 0; i < y - 2; i++)
    //    {
    //        Console.Write("$");
    //teraz drukuj puste
    //        for(int j = 0; j < x - 2; j++)
    //        {
    //            Console.Write(" ");
    //        }
    //rysuj prawy bok
    //        Console.Write("$");
    //zjedz do nowej linii
    //        Console.WriteLine();
    //    }


    //rysuj dolna krawedz
    //    for (int i = 0; i < x; i++)
    //        Console.Write("$");
}
//PrintConsoleSquare(5, 5);
/*koniec zdania 13*/




/*zdanie 14*/








   // static double[] RozwiazanieKwadratowe(double a, double b, double c)
   // {
   //     double delta = b * b - 4 * a * c; // Obliczanie delty (b^2 - 4ac)
//
//        if (delta > 0)
//        {
//            // Dwa różne rozwiązania
//            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//            return new double[] { x1, x2 };
//        }
//        else if (delta == 0)
//        {
//            // Jedno podwójne rozwiązanie
//            double x = -b / (2 * a);
//            return new double[] { x };
//        }
//        else
//        {
            // Brak rozwiązań rzeczywistych
//            return new double[] { };
//        }
//    }

//    static void Main(string[] args)
//    {
//        // Przykład użycia:
//        double a = 1;
//        double b = -3;
//        double c = 2;

//        double[] wynik = RozwiazanieKwadratowe(a, b, c);

//        if (wynik.Length == 0)
//        {
//            Console.WriteLine("Brak rozwiązań rzeczywistych.");
//        }
//        else
//        {
//            Console.WriteLine("Rozwiązania:");
//            foreach (double x in wynik)
//            {
//                Console.WriteLine(x);
//            }
//        }
//    }


/*koniec zdania 14*/



