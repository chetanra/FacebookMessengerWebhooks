namespace Facebook.Messenger.Buttons
{
    public class CallButton : PostBackButton
    {
        public CallButton() : base(ButtonType.phone_number)
        {
        }
    }
}