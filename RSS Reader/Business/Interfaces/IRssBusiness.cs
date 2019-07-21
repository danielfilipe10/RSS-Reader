using RSS_Reader.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RSS_Reader.Business
{
    public interface IRssBusiness
    {
        Task<IList<RssItem>> GetListRssItems(string url);
    }
}
