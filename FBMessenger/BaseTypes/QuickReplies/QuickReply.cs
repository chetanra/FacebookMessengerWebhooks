using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.QuickReplies
{
    public class QuickReply
    {
        [JsonProperty(PropertyName ="content_type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentType ContentType { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}
