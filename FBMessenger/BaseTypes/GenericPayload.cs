using Newtonsoft.Json;
using System.Collections.Generic;

namespace Facebook.Messenger
{
    public class GenericPayload<T> : TemplatePayload where T : Button
    {
        public GenericPayload()
        {
            this.TemplateType = TemplateType.generic;
            Elements = new List<Element<T>>();
        }

        [JsonProperty(PropertyName = "elements", Required = Required.Always)]
        public List<Element<T>> Elements { get; set; }
    }
}