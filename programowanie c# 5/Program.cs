using System.Data;



class Osoba
{
    //dane 
    public string FirstName;
    public string SecondName;
    public DateTime dateOfBirthday;

    //gettersy, settersy - styl Java

    public string Name
    {
        get => this.Name;
        set => this.Name = value.Trim();
    }



    //public string getName()
    //{
    //    return this.Name;
    //}
    //public void setName(string NewName)
    //{
    //    this.Name = NewName.Trim();
    //}

    //konstructor
    public Osoba(string FirstName , string SecondName , DateTime DateOfBirthday)
    {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.dateOfBirthday = DateOfBirthday;
        //lub
        //if (dateOfBirthday.Year <1900)
        //{
        //    throw new ArgumentException("Za stary");
        //}
    }

    //metody (zachwanie)

    public override string ToString()
    {
        return $"{FirstName} {SecondName} ({dateOfBirthday})"; 
    }


}





