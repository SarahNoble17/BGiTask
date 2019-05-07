using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGiGitHubApp.Models.Data
{
    public class Repos
    {
        public ICollection<Uri> Html_url { get; set; }
        public ICollection<int> Stargazers_count { get; set; }
    }
}
