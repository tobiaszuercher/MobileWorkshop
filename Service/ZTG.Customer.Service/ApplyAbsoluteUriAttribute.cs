using System.Collections.Generic;
using System.Reflection;

using ServiceStack;
using ServiceStack.Web;

namespace ZTG.Customer.Service
{
    public class ApplyAbsoluteUriAttribute : ResponseFilterAttribute
    {
        public override void Execute(IRequest req, IResponse res, object requestDto)
        {
            if (requestDto is List<ServiceModel.Customer>)
            {
                ((List<ServiceModel.Customer>)requestDto).ForEach(c => c.ApplyAbsoluteUri(req));
            }
            else if (requestDto is ServiceModel.Customer)
            {
                ((ServiceModel.Customer)requestDto).ApplyAbsoluteUri(req);
            }
        }
    }

    public static class CustomerExtensionMethods
    {
        public static void ApplyAbsoluteUri(this ServiceModel.Customer target, IRequest request)
        {
            if (!string.IsNullOrEmpty(target.ImageUri))
            {
                target.ImageUri = target.ImageUri.Replace("%host%", request.GetBaseUrl() + System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath.TrimEnd('/'));
            }
        }
    }
}