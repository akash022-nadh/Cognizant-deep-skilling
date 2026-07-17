public interface ICustomerRepository
{
    string GetCustomerName(int id);
}

public class CustomerService
{
    private readonly ICustomerRepository repository;

    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public string GetCustomer(int id)
    {
        return repository.GetCustomerName(id);
    }
}
