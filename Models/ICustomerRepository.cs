using Microsoft.AspNetCore.Mvc;

namespace WebAppTASK.Models
{
    public interface ICustomerRepository
    {
        Task<Customer>? GetCustomer(int id);
        Task<ActionResult<IEnumerable<Customer>>> GetAllCustomer(); 

        Task<ActionResult<Customer>> Add(Customer customer);

        Task<Customer> Update(int id, Customer customer);

        Task<Customer> Delete(int id);
    }
}
