

//Console.WriteLine("Zmienne i typy danych");
//byte byteVariable = 50;
//int integralVariable = 300;
//long longVariable = 100000000;
//char charVariable1 = (char)87;
//char charVariable2 = 'a';
//double doubleVariable = 50.0005;
//float doubleVariable1 = 50e10F;
//string stringVariable = "How you doing?";


// tutaj wpisz rozwiązanie 
//Console.WriteLine(byteVariable);
//Console.WriteLine(integralVariable);
//Console.WriteLine(longVariable);
//Console.WriteLine(charVariable1);
//Console.WriteLine(charVariable2);
//Console.WriteLine(doubleVariable);
//Console.WriteLine(doubleVariable1);
//Console.WriteLine(stringVariable);




/* koniec zadania 1 */





/* zadanie 2 */

//int num = 2147483647;
//long bigNum = 88888888888;
//string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
//long longValue = num;
//Console.WriteLine(bigNum);
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
//int integerValue = (int)bigNum;
//Console.WriteLine(bigNum);
//Console.WriteLine(integerValue);
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
//int intFromString = int.Parse(stringNum);
//Console.WriteLine(intFromString);
// zbadaj zachowanie programu


/*koniec zdania 2*/


/* zadanie 3 */

//using System.ComponentModel.DataAnnotations;
//using System.Data;

//int a = 18;
//int b = 6;
//decimal price = 10.56m;
//double doubleVal = 10.56;
//double radius = 5.0;
//double time = 1234.45;
//int c;
//int d;
//int e;
//int f;
//int g;
// wypisz na ekran c,d,e,f,g
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//int h = (int)price;
//int i = (int)doubleVal;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
//c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
//d = a - b;
//zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
//e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
//f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
//g = a % b;
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
//price = h * h;
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
//doubleVal = i * i;
// zastanów się skąd się bieże różnica
//Console.WriteLine(price * price);
//Console.WriteLine(doubleVal* doubleVal);
// wypisz na ekran wynik pola koła o promieniu równym radius
//Console.WriteLine(radius * radius);
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time
//Console.WriteLine("czas w min : " + time);
//Console.WriteLine("czas w hours :" + time * 60);
//Console.WriteLine("czas w sekundach: " + time * 3600);

/* koniec zadania 3 */




/* zadanie 4 */


//int toIncrement = 3;
//int toDivide = 5;

// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
//toIncrement++;
//Console.WriteLine(toIncrement);
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
//toDivide /= toIncrement;
//Console.WriteLine(toDivide);


/* koniec zadania 4 */

/* zadanie 5 */
//double degree = 45;
//double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
//sinValue = Math.Sin(degree);



/* koniec zadania 5 */

/* zadanie 6 */
//using System.Runtime.CompilerServices;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//int year = 2024;
//int month = 5;
//int day = 3;
//int hour = 23;
//int minute = 30;
//stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
//DateTime dt = new DateTime(year, month, day, hour, minute, 0);
//Console.WriteLine(dt);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
//dt = new DateTime(year, month + 3, day, hour - 1, minute, 0);
//Console.WriteLine(dt);
// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
//DateTime date = new DateTime(year , month , day );
//string dayOfWeek = date.DayOfWeek.ToString();
//Console.WriteLine(dayOfWeek);


/* koniec zadania 6 */

/* zadanie 7 */
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Runtime.CompilerServices;
//using System.Threading.Tasks.Dataflow;

//string firstPart = "This is";
//string secondPart = "a string";
//string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
// pamiętaj o brakujących odstępach
//string combinate = firstPart + " " + secondPart + " " + thirdPart;
//Console.WriteLine(combinate);
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
//Console.WriteLine(combinate.ToUpper());
// oraz liczbę przedstawiającą długość tego ciągu znaków
//string fulltext = firstPart+secondPart+thirdPart;
//Console.WriteLine(fulltext.Length );
/* koniec zadania 7 */



/* zadanie 8 */

//double lengthA = 5;
//double lengthB = 1;
//double lengthC = 3;
//zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
//bool isTriangle = (lengthA < lengthB + lengthC);
//bool isRightTriagle = (lengthA + lengthA == lengthB * lengthB + lengthC * lengthC);
//Console.WriteLine(isTriangle);
//Console.WriteLine(isRightTriagle);

/* koniec zadania 8 */


/* zadanie 9 */
//string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
//if(conditionalString.Length > 10)
//{
//    Console.WriteLine(conditionalString);
//}

/* koniec zadania 9 */

/* zadanie 10 */
//using System.ComponentModel.Design;

//int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"

//if(temperature > 20 );
//{
//    Console.WriteLine("ciepło");
//}
//else
//{
//    Console.WriteLine("zimno");
//}
//Console.Writeline(temperature);
/* koniec zadania 10 */



/* zdanie 11 */

// w zadaniu 10 napisane wszytko czego potrzebuje.

/* koniec zdania 11 */



/* zadanie 12 */

//int code = 4;
//int quantity = 11;
//decimal productPrice = 3.5m;
//decimal sellPrice;
//if (code < 10)
//{
//    
//    sellPrice = productPrice;
//}
//else if (code >= 10 && code <= 15)
//{
//    
//    sellPrice = productPrice * 0.95m;
//}
//else 
//{
//    if (quantity <= 10)
//    {
//        
//        sellPrice = productPrice * 1.05m; 
//    }
//    else if (quantity <= 20)
//    {
//        
//        sellPrice = productPrice; 
//    }
//    else if (quantity < 100)
//    {
//        
//        int discountPercentage = (quantity / 10) - 2; 
//        sellPrice = productPrice * (1 - (discountPercentage * 0.01m)); 
//    }
//    else
//    {
//        
//        sellPrice = productPrice * 0.90m; // 10% zniżki
//    }
//}


//Console.WriteLine($"Price: {sellPrice}");


/* koniec zadania 12 */


