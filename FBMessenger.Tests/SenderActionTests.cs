using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facebook.Messenger.BaseTypes;
using Facebook.Messenger.Postbody;
using Newtonsoft.Json;

namespace FBMessenger.Tests
{
    [TestClass]
    public class SenderActionTests
    {
        [TestMethod]
        public void TypingOnTest()
        {
            var action = new SenderAction(SenderActionEnum.typing_on);
            action.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(action, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"sender_action\":\"typing_on\",\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }

        [TestMethod]
        public void TypingOffTest()
        {
            var action = new SenderAction(SenderActionEnum.typing_off);
            action.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(action, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"sender_action\":\"typing_off\",\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }
    }
}