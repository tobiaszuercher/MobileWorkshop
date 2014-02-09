using ServiceStack;

namespace ZTG.Customer.ServiceModel
{
    [Route("/customer", Verbs = "DELETE")]
    [Route("/customer/{id}", Verbs = "DELETE")]
    public class DeleteCustomerById : IReturnVoid
    {
        public int Id { get; set; }
    }
}