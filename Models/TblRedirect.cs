using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblRedirect
    {
        public int Id { get; set; }
        public string Dest { get; set; }
        public string Src { get; set; }
    }
}
