using Newtonsoft.Json;

namespace Facebook.Messenger
{
    public class ContentPayload : Payload
    {
        [JsonProperty(PropertyName ="url", Required = Required.Always)]
        public string Url { get; set; }
    }
}