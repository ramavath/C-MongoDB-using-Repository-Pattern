using System.Collections.Generic;
using MongoRepository;

namespace Citi.Mongo.Data.Schema
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MongoRepository.Entity" />
    public class Customer : Entity
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public List<Product> Products { get; set; }

        public Customer()
        {
            this.Products = new List<Product>();
        }
    }
}
