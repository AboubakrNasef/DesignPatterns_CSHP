using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod.Creator.Loggers
{
    internal class WebLogger : ILogger
    {
        private readonly HttpClient client;

        public WebLogger(HttpClient client)
        {
            this.client = client;
        }
        public void Log(string message)
        {
            Console.WriteLine("console logger");
            //do some logic to log into web 
        }
    }
}
