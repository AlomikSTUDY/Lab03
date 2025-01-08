

using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;



//"struct" jest zbiórem typów wartościowych 


//Coords point1 = new Coords(1.0, 1.0);
//Console.WriteLine(point1);

//Coords point2 = new Coords(1.0, 1.0); ;

//if (point1.Equals(point2))
//    Console.WriteLine("Equal structs");
//else
//    Console.WriteLine("Different structs");


//point1 = new Coords(1.0, 1.0);
//point2 = new Coords(2.0, 2.0);
//Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");


//(double Sqrt, double Log)[] results = new (double Sqrt, double Log)[20];
//for (int i = 0; i < 20; i++)
//{
//    results[i] = (Math.Sqrt(i), Math.Log(i));
//}
//for (int i = 0; i < 20; i++)
//    Console.WriteLine($"int={i + 1} sqrt()={results[i].Sqrt} log()={results[i].Log}");



// zdanie 1

//List<Coords> points = new List<Coords>();

//int n = int.Parse($"wprowadz punkty: {Console.ReadLine()}");


//for (int i = 0;i < n; i++)
//{
//    Console.WriteLine($"wprowadz koordynaty punktu {i + 1}(X Y) : ");
//    string[] input = Console.ReadLine().Split();
//    double x = double.Parse(input[0]);
//    double y = double.Parse(input[1]);
//    points[i] = new Coords(x, y);  
//}


//double lenght = CalculatePolylineLength(points);
//Console.WriteLine($"dlugosc zlamanej linii: {lenght:F2}");




//static double GetDistance(Coords[] coords)
//{
//    double distance =0;

//    for (int i = 0;i < coords.Length; i++)
//    {
//        Coords a = coords[i];
//        Coords b = coords[i+1];
//        distance += Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
//    }

//    return distance;
//}

//koniec zdania 1

//zdanie 2

//(int min, int max) GetMinMax(int[] numbers)
//{
//    int min = 0;    
//    int max = 0;


//    //opcja 1
//    min = numbers.Min();
//    max = numbers.Max();

//    //opcja 2
//    foreach(int num in numbers)
//    {
//        if(num < min) min = num;
//        if(num > max) max = num;

//    }

//    return (min, max);
//}
//Console.WriteLine(GetMinMax(new int[] { -1, }));
//koniec zdania 2




//zdanie 3

//public class Person
//{
//    public Person(string firstName, string fastName, DateTime BirthDate)
//    {

//        FirstName = firstName;
//        LastName = fastName;
//        birthDate = BirthDate;

//    }



//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public DateTime birthDate { get; set; }
//    public string EmailAddress { get; set; }

//    public string GetFullName()
//    {
//        return $"{FirstName} {LastName}";
//    }



//    public int GetAge()
//    {
//        return (int)(DateTime.Now - this.birthDate).TotalDays / 365;
//    }
//    public bool IsAdult()
//    {
//        return GetAge() >= 18;
//    }
//}



//koniec zdania 3





