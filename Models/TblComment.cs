using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class TblComment
    {
        public int Id { get; set; }
        public int? ContentId { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool? IsAdminReply { get; set; }
        public int? LikeCount { get; set; }
        public string NameAndFamily { get; set; }
        public int? ReplyId { get; set; }
        public bool? Status { get; set; }
        public string Txt { get; set; }
    }
}
