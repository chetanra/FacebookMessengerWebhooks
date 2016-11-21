using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.Buttons
{
    public class UrlButton : ButtonWithTitle
    {
        public UrlButton() : base(ButtonType.web_url)
        {
        }

        [JsonProperty("webview_height_ratio")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebviewHeightRatioEnum WebviewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }

        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; set; }

        [JsonProperty(PropertyName = "url", Required = Required.Always)]
        public string Url { get; set; }
    }
}