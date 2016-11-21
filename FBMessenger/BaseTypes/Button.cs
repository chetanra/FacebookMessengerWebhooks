using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger
{
    public class Button
    {
        public Button()
        {

        }

        public Button(ButtonType type)
        {
            Type = type;
        }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ButtonType Type{ get; set; }
    }
}