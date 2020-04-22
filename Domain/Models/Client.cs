using System;

namespace TropsmartAPI.Domain.Models
{
    public class Client
    {
        public int id { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }
        public String password { get; set; }
    }
}