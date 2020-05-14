using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OrderAddress orderAddress { get; set; }

    }
}
