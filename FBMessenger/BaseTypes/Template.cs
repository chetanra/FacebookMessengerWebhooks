using Newtonsoft.Json;

namespace Facebook.Messenger.BaseTypes
{
    public class Template
    {
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}