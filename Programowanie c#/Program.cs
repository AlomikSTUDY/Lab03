using System.Numerics;


Console.WriteLine($"max = {int.MaxValue};min = {int.MinValue}");


//Console.WriteLine($"max = {long.MaxValue};min = {long.MinValue}");

//Console.WriteLine($"max = {uint.MaxValue};min = {uint.MinValue}");

//Console.WriteLine($"max =  {System.Int128.MaxValue};");


//znaczenie słów informatyki 
//Value > wartość 

//var iloczyn = x * y;
//Console.WriteLine( iloczyn );

//jeżeli x albo y więcej niż możliwe znaczenie to będzie minus w znaczeniu (nie zmieśći w znaczniku)
//np
//int x = 1000_000_000
//int y = 2_000
//var il = x * y;
//Conssoe.WriteLine( il);
// wynik -1454759936

//jeżeli zapisać w taki sposób to wszystko może zmieszczić , bo ono wykona zdanie w dannej wartośći

//long iloczyn = (long)x * (long)y;
//Console.WriteLine(iloczyn);
// można włączyć cechy dla każdej wykonanej operacji w ustwieniach "check for aritmetic overflow"
//znajduje sie  > properties (alt+ enter) > build > advenced.

// każda wartość znacznika "int" " long " i t.d. jest jako w formie kola dlatego jeżeli jest wartość więcej 
//może być to będzie minus , jeżeli wartość więcej niż wartość znacznika w 2 razzy to może być plus
//bo ono zrobiło dokładznie jedne koło.

//int x = 1_000_000;
//int y = 2000;

//int iloczyn;
//checked
//{
//    iloczyn = x * y;
//}

//Console.WriteLine(iloczyn);

//dzielienie ciałkowite 

Console.WriteLine($"max = {int.MaxValue};min = {int.MinValue}");

int x = 7;
int y = 2;
int z = 3;
var suma = x + y + z;

double srednia = (double)suma / 3;

//jeżeli ten zapis nie zrbić to wynik będzie po prostu ciały bez kropki.

Console.WriteLine($"{srednia}");


Console.WriteLine($" {x} / {y} = {x / y} reszty {x % y}");

