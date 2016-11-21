using Facebook.Messenger.BaseTypes;
using Newtonsoft.Json;

namespace Facebook.Messenger
{
    public class MessageWithAttachment<T> : Message where T : Payload, new()
    {
        public MessageWithAttachment()
        {
            Attachment = new Attachment<T>();
        }

        [JsonProperty(PropertyName = "attachment", Required = Required.Always)]
        public Attachment<T> Attachment { get; set; }
    }
}