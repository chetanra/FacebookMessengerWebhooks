using MyCloudPiggy.FBMessenger.BaseTypes;
using Newtonsoft.Json;

namespace MyCloudPiggy.FBMessenger.ContentTypes
{
    public class Text : TextMessage
    {
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string TextString { get; set; }
    }
}