using Facebook.Messenger.BaseTypes;

namespace Facebook.Messenger.Postbody.ContentTypes
{
    public class Audio : PostBodyWithMessage<MessageWithAttachment<ContentPayload>>
    {
        public Audio(string url)
        {
            this.Message.Attachment.Type = AttachmentType.audio;

            this.Message.Attachment.Payload = new ContentPayload { Url = url };
        }
    }
}