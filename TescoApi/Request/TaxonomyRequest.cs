using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoApi.Request
{
    class TaxonomyRequest: IApiRequest
    {        
        public string apiKey { get; set; }
        public string GetUrl()
        {
            return string.Format("/v1/taxonomy?apiKey={0}", apiKey);
        }
    }
}
