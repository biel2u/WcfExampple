using System;
using System.Collections.Generic;
using System.ServiceModel.Security;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf.Service;
using System.Web.UI;
using Wcf.Client.MyService;


namespace Wcf.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new MyServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "username";
                client.ClientCredentials.UserName.Password = "password";
                Console.WriteLine(client.GetMessage());
            }
            Console.ReadLine();
        }
    }
}
