using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class keyCountDto
    {
        public string Key { get; set; }
        public int Sum { get; set; }
        public ProductDto? Product { get; set; }
    }
}
