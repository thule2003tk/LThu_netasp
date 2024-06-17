using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thulesson08CF.Models
{
    public class ThuCategory
    {
        /// <summary>
        ///tạo cấu trúc bảng dữ liệu
        /// </summary>
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }

        //thuoc tinh quan he
        public virtual ICollection<ThuBook> ThuBooks { get; set; } 

    }
}