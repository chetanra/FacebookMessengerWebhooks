using Facebook.Messenger.BaseTypes;

namespace Facebook.Messenger.Postbody.ContentTypes
{
    public class File : PostBodyWithMessage<MessageWithAttachment<ContentPayload>>
    {
        public File(string url)
        {
            this.Message.Attachment.Type = AttachmentType.file;

            this.Message.Attachment.Payload = new ContentPayload { Url = url };
        }
    }
}