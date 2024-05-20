using WebApiUsingMySQL.Models;

namespace WebApiUsingMySQL.Repository
{
    public interface ICustomer
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAll();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
