using Citi.Mongo.Data.Schema;
using Citi.Mongo.Data.Interface;
using Citi.Mongo.Data.Repository;
using Citi.Mongo.Data.Service;

namespace Citi.Mongo.Data.Adaptor
{

    //Datbase Level
    /// <summary>
    /// 
    /// </summary>
    public class RestaurantCrudAdap
    {
        //private MongoRepository<Customer> customerrepo;
        //  private DataService dataService;
        /// <summary>
        /// The customer crud
        /// </summary>
        private ICustomerCrudRepo customerCrud;
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantCrudAdap"/> class.
        /// </summary>
        public RestaurantCrudAdap()
        {
          //  dataService = new DataService();
            
        }

        /// <summary>
        /// Gets or sets the customer crud.
        /// </summary>
        /// <value>
        /// The customer crud.
        /// </value>
        public ICustomerCrudRepo CustomerCrud
        {
            get
            {
                if (this.customerCrud == null)
                {
                    return this.customerCrud  = new CustomerCrudRepo(DataService.CustomerModel);
                }
                else return this.customerCrud;
            }

            set
            {
                this.customerCrud = value;
            }
        }
    }
}
