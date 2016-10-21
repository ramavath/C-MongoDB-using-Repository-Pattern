using Citi.Mongo.Data.Interface;
using Citi.Mongo.Data.Schema;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citi.Mongo.Data.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Citi.Mongo.Data.Interface.ICustomerCrudRepo" />
    internal sealed class CustomerCrudRepo : ICustomerCrudRepo

    {
        /// <summary>
        /// The customerrepo
        /// </summary>
        private MongoRepository<Customer> customerrepo;
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCrudRepo"/> class.
        /// </summary>
        /// <param name="customerrepo">The customerrepo.</param>
        public CustomerCrudRepo(MongoRepository<Customer> customerrepo)
        {
            this.customerrepo = customerrepo;
        }

        /// <summary>
        /// Deletes the customer.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public void DeleteCustomer(string Id)
        {
            this.customerrepo.Delete(Id);
        }

        /// <summary>
        /// Inserts the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void InsertCustomer(Customer customer)
        {
            customerrepo.Add(customer);
        }

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void UpdateCustomer(Customer customer)
        {
            customerrepo.Update(customer);
        }
        /// <summary>
        /// Gets all customer.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Customer> GetAllCustomer()
        {
            return this.customerrepo;
            
        }
       // Many more
    }
}
