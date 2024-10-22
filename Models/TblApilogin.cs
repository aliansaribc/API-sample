using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblApilogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime? Expire { get; set; }
    }
}
