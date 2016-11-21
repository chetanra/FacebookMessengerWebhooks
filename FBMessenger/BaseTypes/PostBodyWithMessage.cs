using Newtonsoft.Json;

namespace Facebook.Messenger.BaseTypes
{
    public class PostBodyWithMessage<T> : PostBody where T : Message, new()
    {
        public PostBodyWithMessage() : base()
        {
            Message = new T();
        }

        [JsonProperty(PropertyName = "message", Required = Required.Always)]
        public T Message { get; set; }
    }
}