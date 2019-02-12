using System;

namespace SimpleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MstdnAPI.MstdnRequest
            {
                BaseUrl = new System.Uri(@"https://mstdn.jp")
            };

            var timeline = a.GetPublicTimelineAsync().GetAwaiter().GetResult();

            foreach (var status in timeline)
            {
                System.Console.WriteLine(status.ToString());
            }
            System.Console.ReadKey();
        }
    }
}
