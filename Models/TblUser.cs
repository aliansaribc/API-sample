using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Pass { get; set; }
        public bool? Status { get; set; }
        public string UserName { get; set; }
    }
}
