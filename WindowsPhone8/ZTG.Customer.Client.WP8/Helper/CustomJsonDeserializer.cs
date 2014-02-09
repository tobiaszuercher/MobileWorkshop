using System.Globalization;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace ZTG.Customer.Client.WP8.Helper
{
    public class CustomJsonDeserializer : IDeserializer
    {
        public CustomJsonDeserializer()
        {
            Culture = CultureInfo.InvariantCulture;
        }

        public string RootElement { get; set; }

        public string Namespace { get; set; }

        public string DateFormat { get; set; }

        public CultureInfo Culture { get; set; }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
