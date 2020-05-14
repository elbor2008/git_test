using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
    }
}
