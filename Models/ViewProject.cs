using System;
using System.Collections.Generic;

namespace reactAPI.Models
{
    public partial class ViewProject
    {
        public int Id { get; set; }
        public string ImgAddress { get; set; }
        public string Lnk { get; set; }
        public string MinDisc { get; set; }
        public string Title { get; set; }
        public string ProjectTypeTitle { get; set; }
        public int? Type { get; set; }
    }
}
