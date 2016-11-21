using Facebook.Messenger.BaseTypes;
using Newtonsoft.Json;

namespace Facebook.Messenger.QuickReplies
{
    public class QuickReplyMessage<T> : TextMessage where T : QuickReply
    {
        [JsonProperty(PropertyName ="quickreplies", Required = Required.Always)]
        public T[] QuickReplies { get; set; }
    }
}