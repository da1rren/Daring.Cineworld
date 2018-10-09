using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;

namespace Daring.Cineworld
{
    public static class PollCineworld
    {
        private const string Endpoint = "https://www.cineworld.co.uk/syndication/all-performances.xml";
        private const string EdinburghId = "21";

        [FunctionName("PollCineworld")]
        public static async Task Run([TimerTrigger("0 */5 * * * *", RunOnStartup = true)]TimerInfo myTimer, ILogger log, ExecutionContext context)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            var storage = CloudStorageAccount.Parse(config.GetValue<string>("Storage"));

            var container = storage.CreateCloudBlobClient()
                .GetContainerReference("films");

            using (var web = new HttpClient())
            {
                var xml = await web.GetStringAsync(Endpoint);
                var doc = XDocument.Parse(xml);

                var cinema = doc.Root.Elements("cinema")
                    .Where(x => x.Attribute("id").Value == "21")
                    .Single();

                var root = cinema.Attribute("root").Value;

                var films = cinema.Descendants("film");

                foreach (var film in films)
                {
                    var reference = container.GetBlockBlobReference(film.Attribute("edi").Value);

                    if (await reference.ExistsAsync())
                    {
                        continue;
                    }

                    var title = film.Attribute("title").Value;
                    var synopsis = film.Attribute("synopsis").Value;
                    var img = film.Attribute("poster").Value;
                    var url = film.Attribute("url").Value;
                    var webhook = config.GetValue<string>("PushEndpoint");

                    await web.PostAsJsonAsync(webhook, new
                    {
                        text = "A movie has been released",
                        attachments = new object[]
                        {
                            new
                            {
                                title = title,
                                text = synopsis,
                                image_url = img,
                                actions = new object[]
                                {
                                    new {
                                        type = "button",
                                        text = "view",
                                        url = root + url,
                                        color = RandomColor()
                                    }
                                }
                            }
                        }
                    });

                    await reference.UploadTextAsync(film.ToString());
                }
            }
        }

        private static string RandomColor()
        {
            var random = new Random();
            return string.Format("#{0:X6}", random.Next(0x1000000));
        }
    }
}
