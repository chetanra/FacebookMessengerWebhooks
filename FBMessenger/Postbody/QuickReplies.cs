using Facebook.Messenger.BaseTypes;
using Facebook.Messenger.QuickReplies;
using Newtonsoft.Json;

namespace Facebook.Messenger.Postbody
{
    public class QuickReplies<T> : PostBody where T : QuickReply
    {
        [JsonProperty("message")]
        public QuickReplyMessage<T> Message { get; set; }
    }
}