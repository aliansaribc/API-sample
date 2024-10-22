using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblPrice
    {
        public int Id { get; set; }
        public string Disc { get; set; }
        public string Lnk { get; set; }
        public int? Price { get; set; }
        public string ShortDisc { get; set; }
        public string Title { get; set; }
    }
}
