using Microsoft.EntityFrameworkCore;
using WebApiUsingMySQL.Data;
using WebApiUsingMySQL.Models;
using WebApiUsingMySQL.Repository;

namespace WebApiUsingMySQL.Services
{
    public class CustomerServiceImpl : ICustomer
    {
        private readonly CustomerDbcontext _dbcontext;
        public CustomerServiceImpl(CustomerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public  void AddCustomer(Customer customer)
        {
            _dbcontext.Add(customer);
             _dbcontext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public  List<Customer> GetAll()
        {
           return _dbcontext.customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
