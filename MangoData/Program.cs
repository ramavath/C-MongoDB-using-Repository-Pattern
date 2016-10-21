using Citi.Mongo.Data.Adaptor;
using Citi.Mongo.Data.Schema;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoData
{
     class Program
    {
        /// <summary>
        /// The customeradap
        /// </summary>
        static RestaurantCrudAdap customeradap = new RestaurantCrudAdap();
        static void Main(string[] args)
        {
            //Add customers
            var john = new Customer() { FirstName = "Govind", LastName = "Ramavath" };
            john.Products.AddRange(new[] {
                new Product() { Name = "Chicken", Price = 5.99M },
                new Product() { Name = "Butternon", Price = 1.99M }

        });

            customeradap.CustomerCrud.InsertCustomer(john);

        }


    }
}
