using Newtonsoft.Json;

namespace Facebook.Messenger.BaseTypes
{
    public class TextMessage : Message
    {
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }
    }
}