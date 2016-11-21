using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger
{
    public class TemplatePayload : Payload
    {
        [JsonProperty(PropertyName = "template_type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateType TemplateType { get; set; }
    }
}