using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoApi.Request
{
    class TaxonomyResponse
    {         
        public Category[] categories { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public Child[] children { get; set; }
    }

    public class Child
    {
        public string id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public Child1[] children { get; set; }
    }

    public class Child1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }

}

