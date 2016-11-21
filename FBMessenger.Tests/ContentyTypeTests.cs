using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facebook.Messenger.Postbody.ContentTypes;
using Newtonsoft.Json;

namespace FBMessenger.Tests
{
    [TestClass]
    public class ContentyTypeTests
    {
        [TestMethod]
        public void Audio()
        {
            var b = new Audio("http://audiocom");
            b.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore,   });
            var expected = "{\"message\":{\"attachment\":{\"type\":\"audio\",\"payload\":{\"url\":\"http://audiocom\"}}},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }

        [TestMethod]
        public void Video()
        {
            var b = new Video("http://audiocom");
            b.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"message\":{\"attachment\":{\"type\":\"video\",\"payload\":{\"url\":\"http://audiocom\"}}},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }

        [TestMethod]
        public void File()
        {
            var b = new File("http://audiocom");
            b.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"message\":{\"attachment\":{\"type\":\"file\",\"payload\":{\"url\":\"http://audiocom\"}}},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }

        [TestMethod]
        public void Image()
        {
            var b = new Image("http://audiocom");
            b.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"message\":{\"attachment\":{\"type\":\"image\",\"payload\":{\"url\":\"http://audiocom\"}}},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }

        [TestMethod]
        public void Text()
        {
            var b = new Text("super text");
            b.Recipient.Id = "USER_ID";
            var str = JsonConvert.SerializeObject(b, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
            var expected = "{\"message\":{\"text\":\"super text\"},\"recipient\":{\"id\":\"USER_ID\"}}";
            Assert.AreEqual(str, expected);
        }
    }
}