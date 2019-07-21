using CodeHollow.FeedReader;
using RSS_Reader.Models;
using RSS_Reader.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RSS_Reader.Services
{
    public class RssReaderService : IRssReaderService
    {
        public async Task<IList<RssItem>> GetRssItems(string url)
        {
            try
            {
                var feed = await FeedReader.ReadAsync(url);

                var rssItems = new List<RssItem>();

                foreach(var item in feed.Items)
                {
                    var rssItem = new RssItem
                    {
                        Title = item.Title,
                        Url = item.Link
                    };

                    rssItems.Add(rssItem);
                }

                return rssItems;
            }
            catch(Exception e)
            {
                //Handle exception properly
                throw new Exception(e.Message);
            }
        }
    }
}