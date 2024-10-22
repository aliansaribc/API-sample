using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblPost
    {
        public int Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public string MainImg { get; set; }
        public string ShortDisc { get; set; }
        public string Title { get; set; }
        public int? Type { get; set; }
        public string Disc { get; set; }
        public string DescriptionH { get; set; }
        public string Canonical { get; set; }
        public string PreDisc { get; set; }
        public string PostDisc { get; set; }
        public string VideoUrl { get; set; }
        public string VideoUrl1 { get; set; }
        public string VideoUrl2 { get; set; }
        public string VideoUrl3 { get; set; }
        public string VideoUrl4 { get; set; }
        public int? Level { get; set; }
    }
}
