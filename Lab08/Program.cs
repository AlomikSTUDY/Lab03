//using System;

////klasy
//public class GenericList<T>
//{
//    public void Add(T item) { }
//}

////interfejsy 
//public interface IBox<T>
//{
//    T? Content { get; set; }
//    bool isEmpty()
//    {
//        return Content != null;
//    }
//}


//public class MetalBox<T> : IBox<T>
//{
//    private T? _content;

//    public T? Content
//    {
//        get => _content;
//        set => _content = value;
//    }
//}



//public class ColorBoxForDouble : IBox<double>
//{
//    private double _value;
//    public double Content
//    {
//        get => _value;
//        set => _value = value;
//    }
//}
////



////metody
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int num = 1;
//        string str = "hello";
//        Animal obj = new Animal();
//        PrettyPrintMyClass(num);
//        PrettyPrintMyClass(str);
//        PrettyPrintMyClass(obj);
//    }

//    public static void PrettyPrintMyClass<T>(T item)
//    {
//        Console.WriteLine(">>>>>");
//        Console.WriteLine(item);
//        Console.WriteLine(">>>>>");
//    }
//}



//definicja tworzenia klasy 


namespace Lab08
{
    // class declaration
    public class Person
    {
        // fields
        public string firstName;
        public string lastName;
    }
}

