using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoApi.Request
{
    class ItemRequest: IApiRequest
    {            
        public ItemRequest()
        {
            format = "json";
        }
        public long itemId { get; set; }
        public string format { get; set; }
        public string apiKey { get; set; }
        public string GetUrl()
        {
            return string.Format("/v1/items/{0}?format={1}&apiKey={2}", itemId, format, apiKey);
        }
    }
}
