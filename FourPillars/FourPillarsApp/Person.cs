
namespace FourPillarsApp;

public class Person : IMoveable
{
    private string _firstName = "";
    private string _lastName = "";

    #region properties demo
    ////private backing field
    //private string _secret = "password123";

    ////getter, a method that returns that data
    //public string GetSecret(string key)
    //{
    //    if (key == "potatoes") return _secret;
    //    else return "Invalid Key";
    //}

    ////setter, a method that puts some new data into that data
    //private void SetSecret(string inputValue)
    //{
    //    _secret = inputValue;
    //}
    #endregion

    private int _age = 18;
    public int Age
    {
        get { return _age; }
        set { if (value >= 0) _age = value; }
    }

    public double Height { get; set; }

    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    public Person(string fName, string lName, int age) : this(fName, lName)
    {
        Age = age;
    }

    public Person() { }

    public virtual string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public virtual string GetFullName(string title)
    {
        return $"{title} {GetFullName()}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} _firstName: {_firstName}, _lastName: {_lastName}, Age: {Age}";
    }

    public string Move()
    {
        return "Walking along";
    }

    public string Move(int times)
    {
        return $"{Move()} {times} times";
    }
}