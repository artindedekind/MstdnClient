using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new MstdnAPI.MstdnRequest
            {
                BaseUrl = new System.Uri(@"https://mstdn.jp")
            };

            var timeline = a.GetPublicTimelineAsync();

            System.Console.WriteLine($"{timeline}");
            System.Console.ReadKey();
        }
    }
}
