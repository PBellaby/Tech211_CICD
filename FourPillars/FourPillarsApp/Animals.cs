namespace FourPillarsApp;

public abstract class Animal
{
    private string _name;
    public string Kingdom { get; set; }

    public int Legs { get; set; } = 0;

    public DateTime Age { get; set; }
    public bool hasTail { get; set; }

    //you have to have this method, but you have to also implement it in the way that makes sense to you
    public abstract string Speak();

    //default implementation
    public virtual double Move()
    {
        return 0d;
    }

    public Animal()
    {
        _name = "Bob";
    }
}

public class Dog : Animal
{
    public double Speed { get; set; } = 10;

    public Dog() : base()
    {

    }

    public override string Speak()
    {
        return "Bark";
    }

    public override sealed double Move()
    {
        return Speed;
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow";
    }
}

public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep";
    }
}

//public class Corgi : Dog 
//{
//    public int LegSize { get; set; } = 1;

//    public override double Move()
//    {
//        return 0.1d;
//    }

//}


