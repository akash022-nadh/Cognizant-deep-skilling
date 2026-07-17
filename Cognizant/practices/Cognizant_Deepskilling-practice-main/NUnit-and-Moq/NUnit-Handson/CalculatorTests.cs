using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.AreEqual(5, calculator.Add(2, 3));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.AreEqual(2, calculator.Subtract(5, 3));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.AreEqual(12, calculator.Multiply(3, 4));
    }
}
