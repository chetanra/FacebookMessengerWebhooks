using Newtonsoft.Json;

namespace Facebook.Messenger
{
    public class Recipient
    {
        // Gets or sets the Id.  These IDs are page-scoped IDs (PSID). This means that the IDs are unique for a given page.
        [JsonProperty("id")]
        public string Id { get; set; }

        // Gets or sets the phone number.  Phone number of the recipient with the format +1(212)555-2368. Your bot must be approved for Customer Matching to send messages this way.
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }
}