using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core.DTOs
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public int Stock { get; set; }
    }
}
