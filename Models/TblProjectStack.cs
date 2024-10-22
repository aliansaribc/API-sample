using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblProjectStack
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string Title { get; set; }
    }
}
