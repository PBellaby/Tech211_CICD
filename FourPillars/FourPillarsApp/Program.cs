namespace FourPillarsApp;

public class Program
{
    static void Main()
    {
        ////instantiation
        //var andrew = new Person("Andrew", "Ma");
        //andrew.Age = 22;

        //Console.WriteLine(andrew.Age);
        ////andrew._firstName = "Andy";

        //Console.WriteLine(andrew.GetFullName());

        //var talal = new Person("Talal", "Hassan", 22);
        //string title = "Mr";
        //Console.WriteLine(talal.GetFullName(title));

        ////object initialisers
        //var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };

        //var matthew = new Person("Matt", "Handley");
        //matthew.Age = 21;
        //matthew.Height = 150;

        //var array = new int[] { 1, 2, 3 };
        //var list = new List<int>() { 1, 4, 7 };

        //Park park = new Park() { Roundabouts = 1, Swings = 10, ParkManager = new Person("Dave", "Davidson")};

        //Point3D point = new Point3D(1, 2);
        //Point3D theresAlwaysABlankConstructor = new Point3D();
        //Point3D empty;

        //DoThis(point, matthew);

        //Hunter danielle = new Hunter("Danielle", "Massey", "Kodak");
        ////Console.WriteLine(danielle.Shoot());
        ////Console.WriteLine(danielle.GetFullName("Ms."));

        //Console.WriteLine(danielle);

        //Hunter idris = new("Idris", "Ahmed", "Cannon");

        //Console.WriteLine($"idris Equals danielle? {idris.Equals(danielle)}");
        //Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");
        //Console.WriteLine($"idris Type: {idris.GetType()}");
        //Console.WriteLine($"idris ToString: {idris}");

        //Console.WriteLine(idris.GetFullName());

        var myDog = new Dog();
        var myCat = new Cat();
        var myBird = new Bird();

        Console.WriteLine(myDog.Speak());
        Console.WriteLine(myCat.Speak());
        Console.WriteLine(myBird.Speak());

        Console.WriteLine("\nPolymorphism demo: \n");

        List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Speak());
        }

        //Console.WriteLine();

        //Animal? myAnimal;

        //string input = Console.ReadLine();

        //switch (input.ToLower())
        //{
        //    case "dog":
        //        myAnimal = new Dog();
        //        break;
        //    case "cat":
        //        myAnimal = new Cat();
        //        break;
        //    case "bird":
        //        myAnimal = new Bird();
        //        break;
        //    default:
        //        Console.WriteLine("Not an animal :(");
        //        myAnimal = null;
        //        break;
        //}

        //if (myAnimal is not null) Console.WriteLine(myAnimal.Speak());

        Console.WriteLine();

        List<Object> gameObjects = new List<Object>()
        {
            new Airplane(15),
            new Dog(),
            new Cat(),
            new Park(),
            new Person("Jacob", "Banyard"),
            new Hunter("Majid", "Laklouk", "Nikon"),
            new Vehicle()
        };

        foreach (var obj in gameObjects)
        {
            SpartaWrite(obj);
            if(obj is Animal)
            {
                Animal a = (Animal)obj;
                SpartaWrite(a.Speak());
            }
        }

        Console.WriteLine();

        List<IMoveable> moveables = new()
        {
            new Person("Jacob", "Banyard"),
            new Hunter("Majid", "Laklouk", "Nikon"),
            new Vehicle(),
            new Airplane(25)
        };

        foreach (var m in moveables)
        {
            SpartaWrite(m.Move(2));
        }
    }

    public static void DoThis(Point3D p, Person person)
    {
        p.x = 1000;
        person.Age = 99;
    }

    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine($"Sparta says: {obj}");
    }
}