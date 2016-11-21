using Facebook.Messenger.BaseTypes;

namespace Facebook.Messenger.Postbody.ContentTypes
{
    public class Video : PostBodyWithMessage<MessageWithAttachment<ContentPayload>>
    {
        public Video(string url)
        {
            this.Message.Attachment.Type = AttachmentType.video;

            this.Message.Attachment.Payload = new ContentPayload { Url = url };
        }
    }
}