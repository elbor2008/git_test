using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class BlogPost
    {
        public int BlogId { get; set; }
        public int PostId { get; set; }

        public Blog Blog { get; set; }
        public Post Post { get; set; }
    }
}
