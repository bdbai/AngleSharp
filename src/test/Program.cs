using AngleSharp.Html.Parser;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static async Task MainAsync ()
        {
            var content = "<!DOCTYPE html>\n<html>\n<head>\n<link href=\"/style.css\" rel=\"stylesheet\">\n\n</head></html>";
            var parser = new HtmlParser();
            var doc = await parser.ParseDocumentAsync(content);
        }
        static void Main (string[] args)
        {
            MainAsync().Wait();
        }
    }
}
