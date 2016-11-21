using Newtonsoft.Json;

namespace Facebook.Messenger.Buttons
{
    public class ButtonWithTitle : Button
    {
        public ButtonWithTitle(ButtonType type) : base(type)
        {
        }

        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
    }
}
