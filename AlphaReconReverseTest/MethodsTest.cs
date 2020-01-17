using AlphaReconReverse;
using AlphaReconReverse.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphaReconReverseTest
{
    [TestClass]
    public class MethodsTest
    {
        [TestMethod]
        public void MyWordReverseTrue()
        {
            IMethods method = new Methods();
            string result = "xuniL ro swodniW";
            string word = "Windows or Linux";

            var response = method.ReverseString(word);

            Assert.AreEqual(result, response);
        }


        [TestMethod]
        public void MyWordReverseFalse()
        {
            IMethods method = new Methods();
            string result = "xuniL ro swodniW";
            string word = "Linux or Linux";

            var response = method.ReverseString(word);

            Assert.AreNotEqual(result, response);
        }
    }
}
