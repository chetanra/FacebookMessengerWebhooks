using Facebook.Messenger.BaseTypes;

namespace Facebook.Messenger.Postbody.ContentTypes
{
    public class Text : PostBodyWithMessage<TextMessage>
    {
        public Text(string text)
        {
            Message.Text = text;
        }
    }
}