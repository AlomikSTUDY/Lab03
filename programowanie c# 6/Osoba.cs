 

//mutability / immutability ? 

using System.Data;

class Osoba
{

    public const int YEARS_ISOFAGE = 18;
    public const int PROG_RETIREMENT = 65;
    
    
    
    //dane 
    public static int NumOfPeople { get; private set; }



    private string name;
    private string secondname;
    private DateTime DayOfBirthday;
    public string PlaceOfBirthday { get; init; }



    //gettrsy , settersy - styl Java

    //public string getName()
    //{

    //}

    //public void setName(string value)
    //{
    //    return this.setName;
    //}



    // gettersy , settersy - styl c#
    public string Name
    {
        get => this.Name;
        set => this.Name = value.Trim();
    }

    public DateTime dayOfBirthday
    {

        get => this.dayOfBirthday
        {
            return this.dayOfBirthday;
        }

        set
        {
            if(value.Year < 1900)
            {
                throw new ArgumentException("za stary");
            }
            dayOfBirthday = value;
            PlaceOfBirthday =>   ;
        }



    }








    //public string getName()
    //{
    //    return this.Name;
    //}
    //public void setName(string NewName)
    //{
    //    this.Name = NewName.Trim();
    //}

    //konstruktor
    public Osoba(string name, string secondname, DateTime DayOfBirthday)
    {
        this.name = name.Trim();
        this.secondname = secondname.Trim();
        if(DayOfBirthday.Year < 1900)
        {
            throw new ArgumentException("za stary");
        }
        this.DayOfBirthday = DayOfBirthday;
    }




    //metody (zachowanie)

    public override string ToString()
    {
        return $"{name} {secondname} ({DayOfBirthday:yyyy-dd-MM ddd})";
    }


    public int CalculaateYearsOld() => DateTime.Now.Year - DayOfBirthday.Year; 

    public int YearsOld => DateTime.Now.Year - dayOfBirthday.Year;

    public int howToMuchUntilRetirement(int progRetirement = 65)
    {
        int result = progRetirement - YearsOld;
        return result;
    }
   

    public bool IsOfAge()
    {
        return YearsOld >= YEARS_ISOFAGE;
    }



}