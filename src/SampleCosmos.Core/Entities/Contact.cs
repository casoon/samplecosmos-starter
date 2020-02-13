using System;
using Newtonsoft.Json;

namespace SampleCosmos.Core.Entities
{
    public class Contact
    {
        public Contact()
        {
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public bool IsRegistered { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}