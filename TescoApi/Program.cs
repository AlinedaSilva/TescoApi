using System;
using System.Configuration;
using TescoApi.Request;

namespace TescoApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = ConfigurationManager.AppSettings["56ac439a92694577a2779f3d0ee0cd85"];
            Console.WriteLine("Enter your search query");

            var search = new SearchRequest() { apiKey = apiKey };
            search.query = Console.ReadLine();

            var searchResponse = ApiCall.Send<SearchResponse>(search);

            // var item1 = response.items[0];
            //var itemRequest = new ItemRequest() {apiKey = search.apiKey, itemId = item1.itemId};
            //var response2 = ApiCall.Send<ItemResponse>(itemRequest);

            var feedRequest = new FeedRequest()
            {
                apiKey = apiKey,
                feed = FeedType.bestsellers
            };
            var feedResponse = ApiCall.Send<FeedResponse>(feedRequest);

            Console.ReadLine();
        }
    }
}

