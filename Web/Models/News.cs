using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class News
    {
        public int Id { get; set; }

        public string _Date { get; set; }
        public string _News { get; set; }
        public string _Text { get; set; }
        public string _User { get; set; }
        public byte[] _Avatar_News { get; set; }
    }
}
