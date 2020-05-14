using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
