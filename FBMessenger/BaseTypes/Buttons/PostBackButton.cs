using Newtonsoft.Json;

namespace Facebook.Messenger.Buttons
{
    public class PostBackButton : ButtonWithTitle
    {
        public PostBackButton() : base(ButtonType.postback)
        {

        }

        public PostBackButton(ButtonType type) : base(type)
        {

        }

        [JsonProperty(PropertyName = "payload", Required = Required.Always)]
        public string Payload { get; set; }
    }
}
