using Newtonsoft.Json;

namespace Facebook.Messenger.QuickReplies
{
    public class Text : QuickReply
    {
        public Text()
        {
            ContentType = ContentType.text;
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
