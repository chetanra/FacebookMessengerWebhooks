using Newtonsoft.Json;

namespace Facebook.Messenger.Buttons
{
    public class LogInButton : Button
    {
        public LogInButton() : base(ButtonType.account_link)
        {
        }

        [JsonProperty( PropertyName = "url", Required = Required.Always)]
        public string Url { get; set; }
    }
}