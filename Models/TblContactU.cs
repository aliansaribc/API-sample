using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblContactU
    {
        public int Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Email { get; set; }
        public string NameAndFamily { get; set; }
        public string Phone { get; set; }
        public bool? Seen { get; set; }
        public string Txt { get; set; }
    }
}
