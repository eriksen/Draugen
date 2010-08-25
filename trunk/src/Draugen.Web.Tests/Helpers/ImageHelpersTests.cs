using Draugen.Services.ViewData.Shared.Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Helpers
{
    [TestClass]
    public class ImageHelpersTests
    {
        [TestMethod]
        public void Image_MustReturnValidImageTaG()
        {
            var bilde = new BildeCard(){Alt = "alt", Navn = "navn.jpg"};
            var result = ImageHelpers.Image(null, bilde);
            Assert.AreEqual(@"<img alt=""alt"" src=""~/Content/Images/navn.jpg"" />", result.ToString());
        }
    }
}