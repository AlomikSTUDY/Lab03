// Main

Osoba o = new Osoba("jozek", "nowak", DateTime.Parse("1990-01-01") , DateTime ());
Console.WriteLine(o.ToString());

o.name = "Jan";
o.secondname = "Kowalski";
//o.dateOfBirthday = new DateTime(2000, 1, 1);

//Console.WriteLine(o);

//o.imie="jan;
o.setName = " jan";
o.Name = "Kozio ";
//o.FirstName = "kowalski";
//o.dateOfBirthday = DateTime new DateTime(1500 , 1 ,1);

Console.WriteLine(o);

Console.WriteLine(o.PlaceOfBirthday);
Console.WriteLine(o.CalculaateYearsOld());
Console.WriteLine(o.howToMuchUntilRetirement());
Console.WriteLine(o.howToMuchUntilRetirement(65));

Console.WriteLine("object ma do emerytury" );

//var ol1 = new Osoba ("Jan" , "Kowalski",
//    DateTime.Parse("2000-01-01") , "Krakow");
//Console.WriteLine(ol1);
////Osoba.PROG_RETIREMENT = 67;
////Osoba.YEARS_ISOFAGE = 21; 
 
//Console.WriteLine("object ma do emerytury");

//var ol2 = new Osoba("Jan", "Kowalski",
//    DateTime.Parse("2000-01-01"), "Krakow");
//Console.WriteLine(ol2);



