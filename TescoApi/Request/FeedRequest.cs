using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoApi.Request
{
    class FeedRequest: IApiRequest
    {
        public string apiKey { get; set; }
        public long? categoryId { get; set; }
        public FeedType feed { get; set; }

        public string GetUrl()
        {
            return string.Format("/v1/feeds/{0}?apiKey={1}&categoryId={2}", feed, apiKey, categoryId);
        }
    }
    public enum FeedType
    {
        items, // requires api key authorization
        preorder,
        bestsellers,
        rollback,
        clearance,
        specialbuy
    }
}

