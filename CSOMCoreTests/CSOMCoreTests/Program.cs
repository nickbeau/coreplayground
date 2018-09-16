using System;
using Microsoft.SharePoint.Client;

namespace CSOMCoreTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClientContext ctx = new ClientContext("https://hubone.sharepoint.com");
            ctx.Credentials = new SharePointOnlineCredentials("nick@hubone.com", "Tap0th0365");
            Web myweb = ctx.Web;
            ctx.ExecuteQueryAsync();
            Console.WriteLine("aha");
        }
    }
}
