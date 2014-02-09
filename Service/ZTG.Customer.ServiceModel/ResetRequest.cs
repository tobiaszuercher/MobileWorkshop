using System.Collections.Generic;

using ServiceStack;

namespace ZTG.Customer.ServiceModel
{
    [Route("/reset", Verbs = "GET")]
    public class ResetRequest : IReturn<List<Customer>>
    {
    }
}
