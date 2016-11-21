using Newtonsoft.Json;
using System.Collections.Generic;

namespace Facebook.Messenger
{
    public class Element<T> where T : Button
    {
        public Element()
        {
            Buttons = new List<T>();
        }

        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }

        [JsonProperty("item_url")]
        public string ItemUrl { get; set; }

        [JsonProperty("default_action")]
        public DefaultAction DefaultAction { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("buttons")]
        public List<T> Buttons { get; set; }
    }
}