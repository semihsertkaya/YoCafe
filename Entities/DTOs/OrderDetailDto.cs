using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDetailDto : IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
