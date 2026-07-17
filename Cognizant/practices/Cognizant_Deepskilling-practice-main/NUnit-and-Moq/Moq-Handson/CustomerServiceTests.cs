using Moq;
using NUnit.Framework;

[TestFixture]
public class CustomerServiceTests
{
    [Test]
    public void GetCustomer_ShouldReturnCustomerName()
    {
        var mockRepository = new Mock<ICustomerRepository>();

        mockRepository
            .Setup(repo => repo.GetCustomerName(1))
            .Returns("Hasan");

        var service = new CustomerService(mockRepository.Object);

        string result = service.GetCustomer(1);

        Assert.AreEqual("Hasan", result);
    }
}
