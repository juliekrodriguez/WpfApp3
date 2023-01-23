using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class User
    {
        public string Name { get; set; }

        public List<Feed> Feeds = new List<Feed>();

        public User(string name)
        {
            this.Name = name;
        }

        public bool AddFeed(Feed feed)
        {
            if (this.Feeds.Contains(feed))
            {
                return false;
            }
            else
            {
                this.Feeds.Add(feed);
                return true;
            }
        }

    }
}
