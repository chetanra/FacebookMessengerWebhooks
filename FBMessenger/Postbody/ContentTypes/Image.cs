using Facebook.Messenger.BaseTypes;

namespace Facebook.Messenger.Postbody.ContentTypes
{
    public class Image : PostBodyWithMessage<MessageWithAttachment<ContentPayload>>
    {
        public Image(string url)
        {
            this.Message.Attachment.Type = AttachmentType.image;

            this.Message.Attachment.Payload = new ContentPayload { Url = url };
        }
    }
}