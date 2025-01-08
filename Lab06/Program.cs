


using Lab07;

//Animal animal = new Animal();
//animal.PublicMember = "";
//animal.ProjectedMember = "";
//animal.Privatemamber = "";

//Animal animal = new Dog();
//Console.WriteLine(animal.Sound);
//animal.Move();

//Dog dog = new Dog();
//Console.WriteLine(dog.Sound);
//dog.Move();


public class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = { new Cat(), new Dog(), new Salmon() };

        foreach(Animal ani in animals)
        {
            if (ani is Mammal)
                (ani as Mammal).ProduceMilk();

            if (ani is Dog)
                (ani is Dog).Fetchball();

            if (ani is Cat)
                (ani as Cat).TrowOfTheTable();

            if (ani is IWalkable)
                (ani is IWalkable).Walk();
            if (ani is )
                (ani is ISwimmable).swim();
        }



    }
    public string PublicMember { get; set; }
    protected string ProtectedMember { get; set; }
    private string PrivateMember { get; set; }





    public const string Kingdom = "Animalia";
    public string Sound { get; }
    public void Move()
    {
        Console.WriteLine("Moving...");
    }

}
