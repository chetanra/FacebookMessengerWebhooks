using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facebook.Messenger;
using Facebook.Messenger.Buttons;
using Facebook.Messenger.Postbody.Buttons;
using Newtonsoft.Json;

namespace FBMessenger.Tests
{
    [TestClass]
    public class ButtonTests
    {
        [TestMethod]
        public void UrlButton()
        {
            var b = new UrlButtons();
            b.Recipient.Id = "USER_ID";
            b.Message.Attachment.Payload.Elements.Add(new Element<UrlButton> {Title="Classic White T-Shirt", ItemUrl="https://tshirt", ImageUrl="https://tshirt.png", Subtitle="soft white"});
            b.Message.Attachment.Payload.Elements[0].Buttons.Add(new UrlButton {Url="https://tshirt", Title="view item", WebviewHeightRatio=WebviewHeightRatioEnum.tall });
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore,   });
            var expected = "{\"message\":{\"attachment\":{\"type\":\"template\",\"payload\":{\"elements\":[{\"title\":\"Classic White T-Shirt\",\"item_url\":\"https://tshirt\",\"image_url\":\"https://tshirt.png\",\"subtitle\":\"soft white\",\"buttons\":[{\"webview_height_ratio\":\"tall\",\"url\":\"https://tshirt\",\"title\":\"view item\",\"type\":\"web_url\"}]}],\"template_type\":\"generic\"}}},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }
    }
}