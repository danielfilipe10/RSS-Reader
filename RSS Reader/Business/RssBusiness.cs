using RSS_Reader.Models;
using RSS_Reader.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RSS_Reader.Business
{
    public class RssBusiness : IRssBusiness
    {
        private readonly IRssReaderService _service;
        public RssBusiness(IRssReaderService service)
        {
            _service = service;
        }

        public async Task<IList<RssItem>> GetListRssItems(string url)
        {
            var rssList = await _service.GetRssItems(url);

            return rssList;
        }
    }
}