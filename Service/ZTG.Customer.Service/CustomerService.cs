using System.Linq;

using Customers.DataAccess;

using ServiceStack;

using ZTG.Customer.ServiceModel;

namespace ZTG.Customer.Service
{
    public class CustomerService : ServiceStack.Service
    {
        public CustomerRepository Repository { get; set; }

        [ApplyAbsoluteUriAttribute]
        public object Get(GetCustomerById request)
        {
            if (request.Id != default(int))
            {
                var foundCustomer = Repository.GetById(request.Id);

                if (foundCustomer == null)
                {
                    return HttpError.NotFound("Customer with id {0} not found".Fmt(request.Id));
                }

                return foundCustomer;
            }

            return Repository.GetAll();
        }

        public void Delete(DeleteCustomerById request)
        {
            Repository.DeleteById(request.Id);
        }

        public object Put(ServiceModel.Customer request)
        {
            return PutImpl(request);
        }

        public object Post(ServiceModel.Customer request)
        {
            if (Repository.Customers.Any(x => x.Id == request.Id))
            {
                return Put(request);
            }

            return Repository.Save(request);
        }

        [ApplyAbsoluteUriAttribute]
        public object Get(ResetRequest request)
        {
            Repository.InitializeData();

            return Repository.GetAll();
        }

        private ServiceModel.Customer PutImpl(ServiceModel.Customer customer)
        {
            Repository.DeleteById(customer.Id);
            Repository.Save(customer);
            return customer;
        }
    }
}