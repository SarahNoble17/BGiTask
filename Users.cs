using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGiGitHubApp.Models.Data
{
    public class Users
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public string Node_id { get; set; }
        public Uri Avatar_url { get; set; }
        public Uri Gravatar_id { get; set; }
        public Uri Url { get; set; }
        public Uri Html_url { get; set; }
        public Uri Followers_url { get; set; }
        public Uri Following_url { get; set; }
        public Uri Gists_url { get; set; }
        public Uri Starred_url { get; set; }
        public Uri Subscriptions_url { get; set; }
        public Uri Organizations_url { get; set; }
        public Uri Events_url { get; set; }
        public Uri Received_events_url { get; set; }
        public string Type { get; set; }
        public bool Site_admin { get; set; }
        public string Repos_url { get; set; }
        public ICollection<Repos> Repos { get; set; }

        public Users()
        {
            Repos = new List<Repos>();
        }
    }
}
