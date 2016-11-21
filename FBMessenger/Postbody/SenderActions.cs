using Facebook.Messenger.BaseTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.Postbody
{
    public class SenderAction : PostBody
    {
        public SenderAction(SenderActionEnum type)
        {
            SenderActionType = type;
        }

        [JsonProperty("sender_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SenderActionEnum SenderActionType { get; set; }
    }
}