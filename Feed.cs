using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Feed
    {
        public string URL { get; }

        public string? name { get; set; }

        public Feed(string url)
        {
            this.URL = url;
        }

        public Feed(string url, string name)
        {
            this.URL = url;

            this.name = name;
        }
    }
}
