using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Основные типы int | float | char | string | bool |
            //// Целочисленные типы 
            //byte b;  // 0 до 255
            //sbyte sb; // -128 до 127
            //short s; // -32768 до 32767
            //ushort us; // 0 до 65535
            //int i; // -2147483648 до 2147483647
            //uint ui; // 0 до 4294672295
            //long l;
            //ulong ul;

            ////числа с плавающей точкой 
            //float f = 5.7f;
            //double d = 5.7;

            //// символьный тип
            //char c = ' ';

            ////строковый тип
            //string str = "hello , how are you";

            //// логистический тип 
            //bool bl;






            // арифметические операции 
            // + - * / %
            //int timeMinets = 130;
            //int hour;
            //int minute;

            //hour = timeMinets / 60;
            //minute = timeMinets / 60;

            //Console.WriteLine("hours " + hour);
            //Console.WriteLine("minutes " + minute);

            //int age = 18;
            //age = age +1;
            //age++;
            //age--;
            //age += 1;
            //age -= 1;
            //age *= 2;
            //age /= 3;


            //float result;

            //int x, y;

            //x = 5;
            //y = 2;

            //result = Convert.ToSingle(x) / y;
            //Console.WriteLine(result);







            //логические операции то есть правда или не правда
            // == != > >= <= <
            // true or false !=
            //int age = 18;
            //bool accesIsAllowed;

            //accesIsAllowed = age > 18;
            //Console.WriteLine(accesIsAllowed);






            //Конкатенация в сишарп 



            // скобки в си шарпе имеют преоритет везде , если написать скобки перед значением "+" 
            //то оно с начала будет делать то что в скобках а потом будет то что плюсуется , 
            //или же если есть у нас строка 5+(5) то вывод покажет 55 так как скобки приоритет
            //также компилятор может определать в какой из сторон стои т число ,
            //если число находится перед словом или кавычками "" то он будет преоритетней ,
            //но скобки являются большим приоритетом 


            //string greeting = "hello";
            //string name = "Oleksii";
            //string massage = greeting + " " + name;

            //Console.WriteLine(massage + "glad to see you!");

            //int age = 5;
            ////                                  1) строка + число = строка 2) строка + число = строка
            //Console.WriteLine("hello , yerstuday you have " + age + 1);


            // есть два вида выввода текста на экран 
            //називается интерполяция

            //int age = 27;
            //string name = "oleksii";

            //Console.WriteLine("Your name: " + name + "you have" + age + " years old!");
            ////можно написать более легким доступом который предлагает даже сишарп
            //Console.WriteLine($"Your name: {name} you have {age} years old!");





            // конвертация в C#


            //int age;
            //string input = "15";
            //age = Convert.ToInt32(input);
            //Console.WriteLine(age);
            ////input  является строкой и не является числом 


            //float result;
            //int x = 5, y = 2;
            //result = Convert.ToSingle(x) / y;
            //Console.WriteLine(result);


            //обратная конвертация и конвертация в булиан
            //int trigger = 1;
            //bool triggerInBoolean = Convert.ToBoolean(trigger);
            //Console.WriteLine(triggerInBoolean);
            //int reconvert = Convert.ToInt32(triggerInBoolean);
            //Console.WriteLine(reconvert);




            //более подробная работа с консолью 
            //Console.WriteLine();// вывод команды 
            //Console.ReadLine();// ввод команды любых значений


            //// ввод кирилицы есть не всегда , зависит от региона или от версии вижуал студио
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //к примеру:
            //string name;
            //Console.Write("Enter your name:");
            //name = Console.ReadLine();
            //Console.WriteLine($"Your name: {name}");
            //int age;
            //Console.WriteLine($"Enter your age ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You have {age} years old");



            // в выводе можно не писать Line если не хочешь выводить это в консоль
            //то есть ещё один вид вывода только там не видно курсор
            // ввод строки Console.ReadLine()


            //Инкремент и дикремент
            //
            //у инеремента и дикремента всегда наивысший приоритет 

            //int i = 0;
            //i++;//инкремент 
            //i--;//дикремент

            //Console.WriteLine(i/*также можно инкремент или дикремент поставить тут*/);
            //если второй раз обратиться к элементу который был
            //дикримирован или инкримирован то будет значение на 1 больше или на 1 меньше 


            //        int i = 0;
            //        //                  0 + 2
            //        Console.WriteLine(i++ + ++i);



            //int A = 0;
            ////                  1   + 2 + 1 +   1   + "1" +   3   * 2 = 516
            //Console.WriteLine((++A) + 2 + 1 + (A++) + "1" + (++A) * 2);



            // небольшая программа на си шарп связаная с уроном дамагом и хп
            //float health;
            //int damage;
            //int armor;
            //int precentConvertor = 100;

            //Console.WriteLine("введите количество здоровья: ");
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите количество брони: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите количество урона: ");
            //damage = Convert.ToInt32(Console.ReadLine());
            //health -= Convert.ToSingle(damage) * armor / precentConvertor;

            //Console.WriteLine($"вам нанесли {damage} урона. у вас осталось {health} здоровья");


            //небольная программа про магазин
            //int money;
            //int food;
            //int foodUnitPrice;
            //bool isAbleToPay;

            //Console.WriteLine("добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет. ");
            //Console.WriteLine("сколько у вас золота?");
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.Write("сколько еды вам нужно?");
            //food = Convert.ToInt32(Console.ReadLine());

            //isAbleToPay = money >= food * foodUnitPrice;
            //food*= Convert.ToInt32(isAbleToPay);
            //money -= food + foodUnitPrice;
            //Console.WriteLine($"у вас в сумке {food} едениц еды, и {money} монет");






            //int age;
            //Console.Write("ile masz lat: ");
            //age = Convert.ToInt32(Console.Read());
            //if (age >= 18)
            //{
            //    Console.WriteLine("zapraszamy do naszego baru!");
            //    Console.WriteLine("Co będziesz pić?");
            //}
            //else
            //{
            //    Console.WriteLine("jesteś jeszcze za młody :(");
            //    Console.WriteLine("przyjdź przez: " + (18 - age) + "lat.");
            //}

            //string dayOfWeek;
            //Console.WriteLine("napisz dzień tygodnia: ");
            //dayOfWeek = Console.ReadLine();

            //if (dayOfWeek == "ponieziałek")
            //{
            //    Console.WriteLine("mamy lekcje");
            //}
            //else
            //{
            //    Console.WriteLine("robimy zadanie domowe");
            //}

            // операторы и/или 

            // логическое И &&
            // x | y | x && y   true -> 1   false -> 0
            // 1 | 1 |  1
            // 1 | 0 |  0
            // 0 | 1 |  0
            // 0 | 0 |  0

            // логическое ИЛИ ||
            // x | y | x || y   true -> 1   false -> 0
            // 1 | 1 |  1
            // 1 | 0 |  1
            // 0 | 1 |  1
            // 0 | 0 |  0

            //int money = 500;
            //int level = Convert.ToInt32(Console.ReadLine());

            //if (money >= 500 || level > 9)
            //{
            //    Console.WriteLine("welcome to the club body!");
            //}
            //else
            //{
            //    Console.WriteLine("shut up and get out of here!");
            //}

            // оператор switch (case + brake).
            // оператор switch взаимоисключающий , а if нет  
            // в основном свич применяется если много операторов сравнения
            //string dayOfWeek;
            //dayOfWeek = Console.ReadLine();

            //switch (dayOfWeek)
            //{
            //    case "понедельник ":
            //    case "суббота ":
            //    case "воскресенье ":
            //        Console.WriteLine("go to cinema");
            //        Console.WriteLine("eating popcorn");
            //        break;
            //    case "втроник ":
            //        Console.WriteLine("проходим курсы");
            //        break;
            //    case "среда ":
            //        Console.WriteLine("изучаем switch");
            //        break;
            //    case "четверг ":    
            //        Console.WriteLine("проэктируем приложение");
            //        Console.WriteLine();
            //        break;
            //    case "пятница ":
            //        Console.WriteLine("full chill day");
            //        Console.WriteLine();
            //        break;
            //        // пишем тут дефолт для того что бы при вписании кода могло высвечивать что что-то не так ввели 
            //    default :
            //        Console.WriteLine("i'm don't understand");
            //        break;

            //}




            // практика и повторение изученного 
            //string password = "12qwe";
            //string userinput;

            //Console.WriteLine("введите пароль");

            //userinput = Console.ReadLine();

            //if (userinput == password)
            //{
            //    Console.WriteLine("правельный пароль , доступ разрешен!");
            //}
            //else
            //{
            //    Console.WriteLine("неправельный пароль , доступ запрещён!");
            //}

            //float ukrinWallet;
            //float usdinWallet;

            //int ukrTousd = 40, usdToukr = 42;

            //float exchengeCurrencyCount;
            //string desiredOperation;

            //Console.WriteLine("добро пожаловать в обменник валют! ");

            //Console.WriteLine("введите свою сумму в гривнах. ");
            //ukrinWallet = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("введите свою сумму в доллорах. ");
            //usdinWallet = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("выберите необходимую операцию. ");
            //Console.WriteLine("1 - обменять гривны в доллары. ");
            //Console.WriteLine("2 - обменять доллары в гривны. ");
            //Console.WriteLine("Ваш выбор: ");
            //desiredOperation = Console.ReadLine();
            //switch (desiredOperation)
            //{
            //    case "1":
            //        Console.WriteLine("обмен гривны на доллары");
            //        Console.WriteLine("сколько хотите обменять?");
            //        exchengeCurrencyCount = Convert.ToInt32(Console.ReadLine());
            //        if (ukrinWallet >= exchengeCurrencyCount)
            //        {
            //            ukrinWallet -= exchengeCurrencyCount;
            //            usdinWallet += exchengeCurrencyCount / ukrTousd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("недопустимое количество гривны")
            //        }
            //        break;

            //    case "2":
            //        Console.WriteLine("обмен долларов на гривны");
            //        Console.WriteLine("сколько хотите обменять?");
            //                                exchengeCurrencyCount = Convert.ToInt32(Console.ReadLine());
            //        if (usdinWallet >= exchengeCurrencyCount)
            //        {
            //            usdinWallet -= exchengeCurrencyCount;
            //            ukrinWallet += exchengeCurrencyCount * usdToukr;
            //        }
            //        else
            //        {
            //            Console.WriteLine("недопустимое количество гривны")
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("неверная операция. ");
            //        break;

            //}
            //Console.WriteLine($"Ваш баланс: {ukrinWallet} " + $" {usdinWallet}");





            // тема циклы !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            //int age;
            //Console.WriteLine("add yor age: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //while (age-- > 0 )
            //{
            //    //итерация , то есть пропуск одного шага , при этом оно пропускает указаный шаг в if
            //    if(age == 8)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("Heppy Birthday!");
            //    //значение  break; делает до указоного числа , ограничевает бессконечность
            //    //if( age == 5)
            //    //{
            //    //    break;
            //    //}
            //}


            // цикл for 
            // for отличается от цикла while незначительно , они практически одинаковые 
            // цикл for это цикл с параметром а цикл while это цикл с условием 
            //для for задается начальное и конечное значение переменных и какие-то условия для её изменения 
            //int i = Convert.ToInt32(Console.ReadLine());

            //for( i = 0 ; i < 10 ; i++) 
            //{
            //    Console.WriteLine(i);
            //}







            // практика с циклами 

            //int triesCount = 5;
            //string password = "12345";
            //string userInput;

            //for (int i = 0; i < triesCount; i++)
            //{
            //    Console.WriteLine("введите пароль: ");
            //    userInput = Console.ReadLine();
            //    if (userInput == password)
            //    {
            //        Console.WriteLine("мои секретики;)");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("введен неверный пароль. ");
            //        Console.WriteLine("У вас осталось " + ( triesCount - ( i + 1 )) + "попыток. " );
            //    }
            //}







            //float money;
            //int years;
            //int precent;

            //Console.Write("Введите количество денег, внессеных на вклад: ");
            //money = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("на сколько лет открыть вклад? ");
            //years = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("под какой процент? ");
            //precent = Convert.ToInt32(Console.ReadLine());

            //for ( int i = 0; i < years; i++ )
            //{
            //    money =+ money / 100 * precent;
            //    Console.WriteLine("в этом году у вас " + money);
            //    Console.ReadKey();
            //}

            //int pleyerHelth = 100;
            //int playerDamage = 50;
            //int enemyHelth = 50;
            //int enemyDamage = 10;


            //while (pleyerHelth>0 && enemyHelth> 0)
            //{
            //    pleyerHelth -= enemyDamage;
            //    enemyHelth -= playerDamage;

            //    Console.WriteLine(pleyerHelth + "player.");
            //    Console.WriteLine(enemyHelth + "enemy.");
            //}

            //if (pleyerHelth <= 0 && enemyHelth <= 0)
            //{
            //    Console.WriteLine("Draw");
            //}
            //else if (pleyerHelth <= 0)
            //{
            //    Console.WriteLine("defeat");
            //}
            //else if (enemyHelth <= 0)
            //{
            //    Console.WriteLine("win");
            //}


            // учим значение Random 


            //Random rnd = new Random();
            //int value;
            //while (true)
            //{
            //    //рандом выводит от 0 до 9 в данном случае , вседа выводит значение на одно меньше
            //    value = rnd.Next(0 , 10);
            //    Console.WriteLine(value);
            //    Console.ReadKey();
            //}


            // рандом в цикле не будет работать поэтому надо его выносить за цикл
            // тут не правельный вариант 
            //for (int i = 0; i < 1; i++)
            //{
            //    Random rnd = new Random();
            //    Console.WriteLine(rnd.Next(0 , 5));
            //} 


            // примерно вот так будет правильно 
            //Random rnd = new Random();
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine(rnd.Next(0, 5));
            //}
            // закончил на 2х часах и 13 минутах 

            //Создаем игру "угадай число" оно работает через рандом


            //int number;
            //int lower, higher;
            //int triesCount = 5;
            //int userInput;
            //Random rand = new Random();

            //number = rand.Next(0, 101);
            //lower = rand.Next(number - 10, number);
            //higher = rand.Next(number + 1, number + 10);

            //Console.WriteLine($"мы загадали число которое больше чем : {lower}, но меньше черм : {higher}.");
            //Console.WriteLine($"что это за число? У вас {triesCount} попыток отгадать.");

            //while (triesCount-- > 0)
            //{

            //    Console.WriteLine("ваш ответ: ");
            //    userInput = Convert.ToInt32(Console.ReadLine());
            //    if (userInput == number)
            //    {
            //        Console.WriteLine("вы правы , это число : " + number + ".");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("не верно , попробуйте ещё раз. ");
            //    }

            //}

            //if (triesCount < 0)
            //{
            //    Console.WriteLine("вы проиграли , но повезет в след. раз! Загаданное число было: " + number + ".");
            //}




            //Random rand = new Random();
            //float health1 = rand.Next(90, 110);
            //int damage1 = rand.Next(7, 35);
            //int armor1 = rand.Next(45, 100);

            //float health2 = rand.Next(80, 120);
            //int damage2 = rand.Next(5, 40);
            //int armor2 = rand.Next(65, 100);

            //Console.WriteLine($"Гладиатор 1  - {health1} здоровья , {damage1} урон , {armor1} броня .");
            //Console.WriteLine($"Гладиатор 2  - {health2} здоровья , {damage2} урон , {armor2} броня .");

            //while (health1 > 0 && health2 > 0)
            //{
            //    health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
            //    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

            //    Console.WriteLine("здоровье гладиатора  1  - " + health1);
            //    Console.WriteLine("здоровье гладиатора  2  - " + health2);

            //}

            //if (health1 <= 0 && health2 <= 0)
            //{
            //    Console.WriteLine(" ничья , оба погибли. ");
            //}
            //else if (health1 <= 0)
            //{
            //    Console.WriteLine("гладиатор 1 пал");
            //}
            //else if (health2 <= 0)
            //{
            //    Console.WriteLine("гладиатор 2 пал");
            //}




            //Console.SetCursorPosition(5 , 10);
            //// ставит курсор в любое место которое укажешь 

            //Console.ForegroundColor = ConsoleColor.Yellow;// меняет цвет текст консоли на укразанный
            //Console.BackgroundColor = ConsoleColor.DarkGray;// меняет цыет фона консоли на указанный 
            //Console.Clear();//это вывели что бы покрасить полностью фон консоли в указаный цвет 

            //Console.WindowHeight = 10;//можно задать высоту консоли 
            //Console.WindowWidth = 20;// можно задать ширину консоли
            //Console.WriteLine("hello andrew , where are you? \n i'm right now ni the beach");
            ////обратный слеш и n ( \n ) переносят впереди строку на след ряд , в данном случае мне не пришлось писать 2 раза console writeline 
            ////Console.Clear(); // убираем все с консольной команды и выводит курсор в левый верхний угол 
            //Console.ReadKey();



            //создаем массив 


            //int[] cucumbers = new int[10];
            //Console.WriteLine(cucumbers[0]);

            //Console.WriteLine(cucumbers.Length);

            //cucumbers[7] = 13;
            //cucumbers[3] = 3;

            //Random rand = new Random();

            //int[] cucumbers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue };

            //int[] cucumbers = new int[4] { 4, 1, 6, 7 };

            //for (int i = 0; i < cucumbers.Length; i++)
            //{
            //    //cucumbers[i] = rand.Next(0 , 101);
            //    Console.WriteLine(cucumbers[i] + " ");
            //}

            //сокрашенный инициализатор , помогает заполнить массив теми данными которые мы хотим , 
            //при такой инициализации у нас выделяется память под одномерный массив , 
            // его размерность соответсвует количеству елементов в списке инициализации 
            // есть два формата записи о сокращенном инициалезиторе , 
            // 1 когда мы хотим указать размер массива 
            // 2 когда мы не знаемм точный размер массива 


            // практика с массивами 

            //int[] array = { 2, 3, 4, 7, 8 };
            //int sum = 0;

            //for (int i = 0;i < array.Length; i++)
            //{
            //    sum += array[i];
            //    Console.WriteLine(sum);
            //}


            //int[] array = { 1, 3, 5, 8, 12, 2, 25 };
            //int maxelement = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (maxelement < array[i])
            //    {
            //        maxelement = array[i];
            //    }
            //}
            //Console.WriteLine(maxelement);




            // программа по бронированию мест


            //int[] sectors = { 6, 28, 15, 15, 17 };
            //bool isopen = true;

            //while (isopen)
            //{
            //    Console.SetCursorPosition(0, 18);
            //    for (int i = 0; i < sectors.Length; i++)
            //    {
            //        Console.WriteLine($"в секторе {i + 1} свободно {sectors[i]} мест. ");

            //    }
            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine("регистрация рейса. ");
            //    Console.WriteLine("\n\n1 - забронировать места \n\n2 - выход из программы.\n\n");
            //    Console.WriteLine("введите номер команды: ");
            //    switch (Convert.ToInt32(Console.ReadLine()))
            //    {
            //        case 1:
            //            int usersector, userplaceamount;
            //            Console.WriteLine("в каком секторе вы хотите лететь? ");
            //            usersector = Convert.ToInt32(Console.ReadLine()) - 1;
            //            if (sectors.Length <= usersector || usersector < 0)
            //            {
            //                Console.WriteLine("такого места не существует. ");
            //                break;
            //            }
            //            Console.WriteLine("сколько мест вы хотите забронировать? ");
            //            userplaceamount = Convert.ToInt32(Console.ReadLine());
            //            if (userplaceamount < 0)
            //            {
            //                Console.WriteLine("неверное количество мест. ");
            //                break;
            //            }
            //            if (sectors[usersector] < userplaceamount)
            //            {
            //                Console.WriteLine($"в секторе{usersector} недостаточно мест. " +
            //                    $"Остаток {sectors[usersector]}");
            //                break;
            //            }

            //            sectors[usersector] -= userplaceamount;
            //            Console.WriteLine("бронирование успешно! ");
            //            break;
            //        case 2:
            //            isopen = false;
            //            break;

            //    }

            //    Console.ReadKey();
            //    Console.Clear();

            //}




            // многомерные массивы 
            // в примере мы будем использовать только двух менрый массив



            //int[,] array;
            //int[,] array2 = new int[2, 3];

            //int[,] array3 = {
            //    { 2, 3, 4 },
            //    { 4, 5, 1 },
            //    { 7, 8, 9 }
            //};

            //int[,] array4 = new int[2, 3] {
            //    {9, 8, 7 },
            //    {6, 5, 4 }
            //};

            //int[,] array3 = new int[4, 4];
            //Random rand = new Random();

            ////Console.WriteLine(array4[0 , 0]);

            ////Console.WriteLine(array3.Length);

            //for (int i = 0; i < array3.GetLength(1); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(0); j++)
            //    {
            //        array3[i, j] = rand.Next(0, 10);
            //        Console.Write(array3[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // это похоже на матрицу так что это можно использовать в дальнейшем

            //bool isOpen = true;
            //string[,] books =
            //{
            //    {"Тарас Шевченко","Леся Українка","Ліна Костенко"},
            //    {"Роберт Мартин","Джесси Шелл","Іван Франко"},
            //    {"Стивен Кинг","Говард Лавкрафт","Брем Стокер"}
            //};

            //while (true)
            //{
            //    Console.SetCursorPosition(0,20);
            //    Console.WriteLine("\nВесь список авторов:\n");
            //    for (int i = 0; i < books.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < books.GetLength(1); j++)
            //        {
            //            Console.Write(books[i,j] + " | ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine("Библиотека");
            //    Console.WriteLine("\n1 - узнать имя автора по индексу книги.\n\n2 - найти книгу по автору." +
            //        "\n\n3 - выход.");
            //    Console.Write("\nВыберите пункт меню: ");
            //    switch (Convert.ToInt32( Console.ReadLine()))
            //    {
            //        case 1:
            //            int line , column;
            //            Console.WriteLine("Введите номер полки: ");
            //            line = Convert.ToInt32( Console.ReadLine()) - 1;
            //            Console.WriteLine("Введите номмер столбца: ");
            //            column = Convert.ToInt32( Console.ReadLine()) - 1;
            //            Console.WriteLine("это автор:" + books[line, column]);
            //            break;
            //        case 2:
            //            string author;
            //           bool authorIsFound = false;
            //            Console.WriteLine("Введите автора: ");
            //            author = Console.ReadLine();
            //            for (int i = 0;i < books.GetLength(0); i++)
            //            {
            //                for(int j = 0;j < books.GetLength(1); j++)
            //                {
            //                    if (author.ToLower() == books[i , j].ToLower())
            //                    {
            //                        Console.Write($"Автор {books[i , j]} " +
            //                            $"находится по адресу: полка{i + 1} место {j + 1}");
            //                        authorIsFound = true;
            //                    }
            //                }
            //            }
            //            if (authorIsFound == false)
            //            {
            //                Console.WriteLine("Такого автора нет!");
            //            }
            //            break;
            //        case 3:
            //            isOpen = false;
            //            break;
            //        default:
            //            Console.WriteLine("Введена неверная команда.");
            //            break;

            //    }

            //    if (isOpen)
            //    {
            //        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}



            // массив это ссылочный тип 
            //мы можем назначить один массив другому 

            // приводим примеры 

            //int[] array = new int [3];
            //int[] temparray = new int [5];

            //array = temparray;

            //array[0] = 5;

            //Console.WriteLine(temparray[0]);

            //int[] petrovich = new int[3];
            //int[] ivanovich = new int[5];
            //int[] sidorovich;

            //petrovich = ivanovich;

            //petrovich[0] = 5;
            //petrovich[1] = 3;

            //sidorovich = petrovich;

            //sidorovich[2] = 7;
            //sidorovich[0] = 10;

            //Console.WriteLine(ivanovich[0]);
            //Console.WriteLine(ivanovich[1]);

            //petrovich = new int[10];





            // расширение массива 
            // пример 




            //int[] bag = new int[1];
            //int[] tempbag = new int[bag.Length + 1];
            //for (int i = 0; i < bag.Length; i++)
            //{
            //    tempbag[i] = bag [i];
            //    Console.WriteLine(bag[i] + " первый");
            //}
            ////Console.WriteLine(tempbag[tempbag.Length - 1] + "последнее значение временного хранилища"); 

            //tempbag[tempbag.Length - 1] = 56;

            //bag = tempbag;

            //for (int i = 0;i < bag.Length;i++)
            //{
            //    Console.WriteLine(bag [i] + " второй");
            //}






            //// игра прохождение карты и собирание сокровищ
            //// первым делом мы создали карту
            //Console.CursorVisible = false;
            //char[,] map =
            //{
            //    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            //    { '#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','X','#'},
            //    { '#',' ','#',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ',' ','#'},
            //    { '#',' ','#',' ','#','#',' ','#','X','#',' ',' ','#',' ','#','#'},
            //    { '#',' ',' ',' ','#',' ',' ','#','#','#','#',' ','#',' ','#','#'},
            //    { '#',' ','#',' ','#',' ','#','#',' ',' ','#',' ','#',' ','#','#'},
            //    { '#',' ','#',' ','#',' ',' ','#',' ','X','#',' ','#',' ',' ','#'},
            //    { '#',' ','#',' ','#','#',' ','#',' ','#','#',' ','#','#',' ','#'},
            //    { '#',' ','#',' ','#','X',' ','#',' ','#','#',' ',' ','#',' ','#'},
            //    { '#',' ','#',' ','#','#','#','#',' ',' ',' ',' ',' ','#',' ','#'},
            //    { '#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#','#','#',' ','#'},
            //    { '#',' ','#','#','#','#',' ','#',' ','#',' ','#','X','#',' ','#'},
            //    { '#',' ',' ','X',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#'},
            //    { '#',' ',' ',' ',' ','#',' ',' ',' ','#','X','#',' ',' ',' ','#'},
            //    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            //};

            //int userX = 6, userY = 6;
            //char[] bag = new char[1];



            //while (true)
            //{
            //    // отоброжение сумки
            //    Console.SetCursorPosition(0, 20);
            //    Console.Write("Сумка: ");
            //    for (int i = 0; i < bag.Length; i++)
            //    {
            //        Console.Write(bag[i] + " ");
            //    }
            //     // отоброжение карты которую сделали выше
            //    Console.SetCursorPosition(0, 0);
            //    for (int i = 0; i < map.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < map.GetLength(1); j++)
            //        {
            //            Console.Write(map[i, j]);
            //        }
            //        Console.WriteLine();
            //    }
            //    // отоброжение персонажа и его перемещение 
            //    Console.SetCursorPosition(userY, userX);
            //    Console.WriteLine('@');
            //    ConsoleKeyInfo charKey = Console.ReadKey();

            //    switch (charKey.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            if (map[userX - 1, userY] != '#')
            //            {
            //                userX--;
            //            }
            //            break;
            //        case ConsoleKey.DownArrow:
            //            if (map[userX + 1, userY] != '#')
            //            {
            //                userX++;
            //            }
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            if (map[userX, userY - 1] != '#')
            //            {
            //                userY--;
            //            }
            //            break;
            //        case ConsoleKey.RightArrow:
            //            if (map[userX, userY + 1] != '#')
            //            {
            //                userY++;
            //            }
            //            break;
            //    }
            //    // тображение сумки и её функционал 
            //    if (map[userX, userY] == 'X')
            //    {
            //        map[userX, userY] = 'o';
            //        char[] tempbag = new char[bag.Length + 1];
            //        for (int i = 0; i < bag.Length; i++)
            //        {
            //            tempbag[i] = bag[i];
            //        }
            //        tempbag[bag.Length - 1] = 'X'; 
            //        bag = tempbag;
            //    }

            //    Console.Clear();

            //}



            ////тип string этот тот же массив типа char
            //string line = " hello ";
            //Console.WriteLine(line);





            //int[] numbers = (0, 1, 2, 3, 4, , 5, 6, 7, 8,  9);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            //var это синтактический сахар C# , который автоматически присвоит тип нашей перменной 
            // в тех случаях когда тип нашей коллекции мы не знаем заранее 

            //в тех ситуациях ктогда нам индекс не нужен , мы импользуем foreach
            // а ктогда необходимо обращение к элементу по индексу то мы используем for





            //foreach (int number in numbers)
            ////для каждого целочисленного номера нашей коллекции мы делаем действие.
            //{
            //    Console.Write(number + " ");
            //}

            //аргумент это то что функция получает , а параментр это то что функция хочет получить
            //а целом про функцию можно сказать что этот какой-то код который получает данные 
            // их обрабатывает и может дать ответ







            //string userInput = "AAAAaaaAaaa";
            //userInput.ToLower();//это и есть наша встроенная функция 

            //Console.WriteLine("привет!");
            //Console.WriteLine("Ты здесь?");
            //ConsoleColor defaultColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Нет соединения с интернетом.");
            //Console.ForegroundColor = defaultColor;
            //Console.WriteLine("Странно");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Нет соединения с интернетом.");
            //Console.ForegroundColor = defaultColor;
            //// это и есть повторяющейся код , такой никто не делает и даже такое нельзя делать 



            //Console.WriteLine("привет!");
            //Console.WriteLine("Ты здесь?");
            //WriteEror("Нет соединения с интернетом.");
            //Console.WriteLine("Странно");
            //WriteEror("Интернет не оплачен.");

            // параментр это то что функия хочет получить а аргумент это то что получает по факту.

            //static void WriteEror(string text , ConsoleColor cololr = ConsoleColor.Red)// от написания ConsoleColor начинается необязательный параментр,
            // после необязательных параметров нельзя ставить обычный параметр.
            //{
            //    ConsoleColor defaultColor = Console.ForegroundColor;
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(text);
            //    Console.ForegroundColor = defaultColor;
            //}





            //int j = 3, y = 8, sum;

            //sum = Sum(j, y);
            //Console.WriteLine(sum);


            //static int Sum(int x , int y)
            //{
            //    int sum;
            //    sum = x * y;
            //    return sum;

            //}









            // когда мы что-то передаем в нашу функцию , то мы передаем на переменные ии передаем их значения.
            // Можно сказать , мы их копируем из места ввода в функцию. Поэтому у нас sum не может быть не 
            // проициализированной. Программа пытается скопировать то , чего нет - и в этом проблема.
            // То есть мы должны ее заранее проинциализировать.

            //И получается , что если наши переменные хранят какое-то значение , то эти значения копируются. 

            // но , если мы хотим передать значения по ссылке , и менять именно их
            //следует использовать можидификаторы. Эти ref и out.То есть мы передадим уже значение переменной , 
            //а ссылку на область памяти , где хранится эта переменная. С реф будут идти входные параментры ,
            //а с аут - выходные.
            // в данном случае нам надо проинициалезировать sum , потому что реф и аут
            // не будут работать без инициализатора.(добавить им = и какое-то число).
            //Если нельзя проинициализировать самому то мы можем ввести аут,
            // аут сам может это сделать , при это никакие числа добавлять не надо (к примеру , = 0)

            //int sum = 0, x = 1 , y = 5;
            //Add (ref sum, x, y);
            //Console.WriteLine(sum);

            //static void Add(ref int sum , int x , int y)
            //{

            //    sum = x + y;


            //}








            //int[] array = new int[5];
            //array = EditArray(array, 2, 5);
            //Console.WriteLine(array[2]);



            //static int[] EditArray(int[] array, int index, int value)
            //{
            //    array = new int[5];
            //    array[index] = value;
            //    return array;
            //}












            //новый материал
            // перегрузка  -------!!!!!!!







            //    int[] array1 = new int[5];
            //    int[,] array2 = new int[5 , 5];
            //    array1 = Resize(array1, 6);
            //    array2 = Resize(array2, 10 , 10);
            //    //array2 = Resize(array2 , 7);////ТАК ДЕЛАТЬ НЕЛЬЗЯ ТАК КАК МЫ ВОЗВРАЩАЕМ И ПРИНИМАЕМ ОДНОМЕРНЫЙ МАССИВ.
            //    Console.WriteLine(array1.Length);
            //    Console.WriteLine(array2.Length);



            //}
            //static int[] Resize(int[] array ,int size)
            //{
            //    int[] tempArray =new int[size];
            //    for (int i = 0; i < array.Length; i++)
            //    {

            //        tempArray[i] = array[i];
            //    } 
            //    array = tempArray;
            //    return array;


            //}
            //static int[,] Resize(int[,] array , int x , int y)
            //{
            //    int[,] tempArray = new int[y,x];
            //    for (int i = 0;i < array.GetLength(0);i++)
            //    {
            //        for (int j = 0;j < array.GetLength(1); j++)
            //        {
            //            tempArray[i,j] = array[i,j];

            //        }
            //    }
            //    array = tempArray ;
            //    return array;
            //}





            //    int health = 5, Maxhealth = 10;
            //    int mana = 7, maxman = 10;

            //    while (true)
            //    {
            //        DrawBar(health, Maxhealth, ConsoleColor.Green, 0, '|');
            //        DrawBar(mana, maxman, ConsoleColor.Blue, 1);

            //        Console.SetCursorPosition(0, 5);
            //        Console.Write("введите число на которое изменится жизни: ");
            //        health += Convert.ToInt32(Console.ReadLine());
            //        Console.Write("введите число на которое изменится мана: ");
            //        mana += Convert.ToInt32(Console.ReadLine());
            //        Console.ReadKey();
            //        Console.Clear();
            //    }

            //}
            //static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
            //{
            //    ConsoleColor defaultcolor = Console.BackgroundColor;
            //    string bar = "";
            //    for (int i = 0; i < value; i++)
            //    {
            //        bar += symbol;
            //    }


            //    Console.SetCursorPosition(0, 0);
            //    Console.Write('[');
            //    Console.BackgroundColor = color;
            //    Console.Write(bar);
            //    Console.BackgroundColor = defaultcolor;

            //    bar = "";

            //    for (int i = 0; i < maxValue; i++)
            //    {
            //        bar += " ";

            //    }

            //    Console.Write(bar + ']');




            // изучаем тип List<>


            //List<int> numbers = new List<int>(5);
            //numbers.Add(12);
            //numbers.Add(5);



            //numbers.Add(8);
            //numbers.Add(14);
            //numbers.Add(22);

            ////если хотим добавить какой-то диапазон то можно использовать это:
            //numbers.AddRange(new int[] {3,4,5,6});

            ////можем удалить элемент колекции под определенным индексом
            //numbers.RemoveAt(3);

            ////также можем удалять элемент колекции по совпадению 
            //numbers.Remove(5);

            ////можно его очистить
            //numbers.Clear();

            ////если хотим вывести число на какой позиции то можно ввести это(попробовать что бы понять)
            //Console.WriteLine("число 22 находится на позиции: " + numbers.IndexOf(22));

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //в этом примере мы можем вставлять елементы на любую позицию колекции 
            // те елементы которые идут за этой позицией будут смещены на 1
            //List<int> numbers = new List<int>(5);
            //numbers.Add(12);
            //numbers.Add(5);


            //numbers.Insert(1, 123);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Count - liczba elementów w kolekcji

            //IsReadOnly - zwraca true dla kolekcji przeznaczonych tylko do odczytu

            //Add - dodaje element do kolekcji

            //Clear - usuwa wszystkie elementy z kolekcji

            //Contains - testuje, czy kolekcja zawiera element

            //CopyTo - kopiuj kolekcję do tablicy począwszy od wskazanego indeksu

            //Remove - usuwa element z kolekcji



            ////будем изучать формулу queue(кю)

            //Queue<string> patients = new Queue<string>();
            //patients.Enqueue("");
            //patients.Enqueue("");
            //patients.Enqueue("");
            //patients.Enqueue("");
            ////так мы добавляем в очередь



            //Console.WriteLine("" + patients.Dequeue());
            //// так мы снимаем с очереди



            //Console.WriteLine("" + patients.Peek()); 
            ////если мы хотим не вычеркивать с очереди , просто кто идет следующим 

            //foreach(var patien  in patients)
            //{
            //    Console.WriteLine(patien);
            //}




            // сейчасс изучаем функцию stack FILO коллекция 






        }

    }
}
