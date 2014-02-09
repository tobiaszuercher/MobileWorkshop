using Customers.DataAccess;

using Funq;

using ServiceStack;
using ServiceStack.Api.Swagger;

using ZTG.Customer.Service;

namespace Customers.Service
{
    public class CustomerAppHost : AppHostBase
    {
        public CustomerAppHost()
            : base("FHWN wsc6 Customer Service", typeof(CustomerService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Plugins.Add(new SwaggerFeature());
            container.Register(new CustomerRepository());
        }
    }
}