using System;
using System.Linq;
using System.Web;

namespace TescoApi
{
    public static class Helpers
    {
        public static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());// to get the httputility needs to add the reference system web

            return String.Join("&", properties.ToArray());
        }
    }
}
