using RSS_Reader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Reader.Services.Interfaces
{
    public interface IRssReaderService
    {
        Task<IList<RssItem>> GetRssItems(string url);
    }
}
