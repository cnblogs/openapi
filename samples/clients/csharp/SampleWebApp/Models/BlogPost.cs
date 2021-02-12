using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cnblogs.OpenAPI.Client.SampleWebApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public int ViewCount { get; set; }

        public int DiggCount { get; set; }

        public int CommentCount { get; set; }

        public string Author { get; set; }

        public int BlogId { get; set; } = -1;

        public string BlogUrl { get; set; }

        public string AvatarUrl { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
