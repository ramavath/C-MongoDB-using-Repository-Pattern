using System.Linq;
using Citi.Mongo.Data.Schema;

namespace Citi.Mongo.Data.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICustomerCrudRepo
    {
        void DeleteCustomer(string Id);
        IQueryable<Customer> GetAllCustomer();
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}