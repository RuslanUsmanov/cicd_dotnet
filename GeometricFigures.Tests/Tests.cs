namespace GeometricFigures.Tests;

[TestFixture]
public class Tests
{
    Square s;

    [OneTimeSetUp]
    public void Init()
    {
        s = new Square(10);
    }

    [TearDown]
    public void CleanUp()
    {
    }

    [Test]
    public void TestSquareArea()
    {
        Assert.AreEqual(100, s.GetArea());
    }

    [Test]
    public void TestSquarePerimeter()
    {
        Assert.AreEqual(40, s.GetPerimeter());
    }
}
