using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;
        public DocumentTests()
        {
            validDocument = new Document("28659170377");
            invalidDocument = new Document("1525565551");
        }
        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.AreEqual(false, invalidDocument.IsValid);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsValid()
        {
            Assert.AreEqual(true, validDocument.IsValid);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenNametIsValid()
        {
            var name = new Name("", "Vanessa");
            Assert.AreEqual(false, name.IsValid);
            Assert.AreEqual(1, name.Notifications.Count);
        }
    }
} 
