using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger
{
    public class Attachment<T> where T : Payload, new()
    {
        public Attachment()
        {
            Payload = new T();
            Type = AttachmentType.template;
        }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AttachmentType Type { get; set; }

        [JsonProperty(PropertyName = "payload", Required = Required.Always)]
        public T Payload { get; set; }
    }
}