using ServiceStack;

namespace ZTG.Customer.ServiceModel
{
    [Route("/customer", Verbs = "GET")]
    [Route("/customer/{Id}", Verbs = "GET")]
    public class GetCustomerById : IReturn<Customer>
    {
        public int Id { get; set; }    
    }
}