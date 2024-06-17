using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thulesson08CF.Models
{
    /// <summary>
    /// tao cau truc bang Book
    /// </summary>
    public class ThuBook
    {
        [Key]
        public int ThuBookId { get; set; }
        public string ThuTitle { get; set; }
        public string ThuAuthor { get; set; }
        public int ThuYear { get; set;}
        public string ThuPublisher { get; set; }
        public string ThuPicture { get; set; } 
        public int ThuCategoryId { get; set; }

        //thuoc tinh quan he
        public virtual ThuCategory ThuCategory { get; set; }

    }
}