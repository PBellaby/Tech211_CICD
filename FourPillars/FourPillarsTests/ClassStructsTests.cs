using FourPillarsApp;

namespace FourPillarsTests;

public class ClassStructsTests
{
    Person _sut;

    [Test]
    public void Person_ConstructsSuccessfully()
    {
        //act
        _sut = new Person();

        Assert.Pass();
    }

    [Test]
    public void Person_ConstructsSuccessfully_GivenFNameLName()
    {
        //act
        _sut = new Person("John", "Smith");

        Assert.Pass();
    }

    [Test]
    public void Person_ConstructsSuccessfully_GivenFNameLNameAge()
    {
        //act
        _sut = new Person("John", "Smith", 33);

        Assert.Pass();
    }

    [Test]
    public void Person_ConstructsWithCorrectAge()
    {
        //act
        _sut = new Person("John", "Smith", 33);

        Assert.That(_sut.Age, Is.EqualTo(33));
    }

    [Test]
    public void Person_ConstructsWithNoAge_HasDefaultAge()
    {
        //act
        _sut = new Person("John", "Smith");

        Assert.That(_sut.Age, Is.EqualTo(18));
    }

    [TestCase(-1)]
    [TestCase(-101)]
    public void Person_SetAge_IgnoresNegativeValues(int value)
    {
        //arrange
        _sut = new Person("John", "Smith", 33);
        //act
        _sut.Age = value;

        Assert.That(_sut.Age, Is.EqualTo(33));
    }

    [TestCase("John", "Smith", "John Smith")]
    [TestCase("", "", " ")]
    [TestCase("John", "", "John ")]
    [TestCase("", "Smith", " Smith")]
    public void Person_GetFullName_ReturnsExpected(string f, string l, string exp)
    {
        //arrange
        _sut = new Person(f, l);
        //act
        string res = _sut.GetFullName();

        Assert.That(exp, Is.EqualTo(res));
    }

    [TestCase("Mr", "John", "Smith", "Mr John Smith")]
    [TestCase("", "", "", "  ")]
    public void Person_GetFullName_WithTitle_ReturnsExpected(string t, string f, string l, string exp)
    {
        //arrange
        _sut = new Person(f, l);
        //act
        string res = _sut.GetFullName(t);

        Assert.That(exp, Is.EqualTo(res));
    }
    [Test]
    public void SillyTest()
    {
        Assert.Fail();
    }
}