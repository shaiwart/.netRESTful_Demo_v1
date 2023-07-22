using Microsoft.AspNetCore.Mvc;

namespace WebAppTASK.Models
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        public readonly Appdbcontext context;

        public SQLCustomerRepository(Appdbcontext context)
        {
           
        }
        public async Task<ActionResult<Customer>> Add(Customer customer)
        {
          context.Customers.Add(customer);
          await context.SaveChangesAsync();
            return customer;

        }

        public async Task<Customer> Delete(int id)
        {
            Customer customer = context.Find<Customer>(id);
            {
                if(customer != null) 
                {
                    context.Customers.Remove(customer);
                    await context.SaveChangesAsync();
                }
                return customer;
            }
        }

        public Task<ActionResult<IEnumerable<Customer>>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<Customer>? GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Update(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
