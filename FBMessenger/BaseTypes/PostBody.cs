using Newtonsoft.Json;

namespace Facebook.Messenger.BaseTypes
{
    public class PostBody
    {
        public PostBody()
        {
            Recipient = new Recipient();
        }

        [JsonProperty(PropertyName = "recipient", Required = Required.Always)]
        public Recipient Recipient { get; set; }
    }
}