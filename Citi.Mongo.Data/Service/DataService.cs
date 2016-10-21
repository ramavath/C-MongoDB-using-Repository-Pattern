using Citi.Mongo.Data.Schema;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citi.Mongo.Data.Service
{
    /// <summary>
    /// 
    /// </summary>
    public static class DataService
    {
        /// <summary>
        /// Gets the customer model.
        /// </summary>
        /// <value>
        /// The customer model.
        /// </value>
        public static MongoRepository<Customer> CustomerModel { get { return Singleton<MongoRepository<Customer>>.Instance; } }
    }   
}
