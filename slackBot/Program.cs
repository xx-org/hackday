using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MargieBot;
using SlackAPI;
using SlackBot;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace AwesomeBot
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            const string TOKEN = "xoxb-975330989108-978001920342-1O8EiAr7DQuldMYrPnnsebf0";  // token from last step in section above
            var slackClient = new SlackTaskClient(TOKEN);

            var response = await slackClient.PostMessageAsync("#general", "hello world");
        }
    }
}