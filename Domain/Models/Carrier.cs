using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TropsmartAPI.Domain.Models
{
    public class Carrier
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int calification { get; set; }
    }
}
