using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LTHTBaiDanhGiaGiuaky.Models
{
    public class LTHTProduct
    {
        public int ID { get; set; }
        [DisplayName("thu ID")]
        [Required(ErrorMessage = "thu: Chưa nhập dữ liệu")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "thu: Họ tên chứa tối thiểu 2 ký tự tối đa 25")]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "thu: Họ tên chỉ chưa các ký tự hoặc khoảng trắng")]
        public string thuFullName { get; set; }
        [DisplayName("thu: Họ và tên")]
        [Required(ErrorMessage = "thu: Chưa nhập dữ liệu")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "thu: Họ tên chứa tối thiểu 2 ký tự tối đa 25")]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "thu: Họ tên chỉ chưa các ký tự hoặc khoảng trắng")]
        public string thuImage { get; set; }
        [DisplayName("thu: ảnh")]
        [Required(ErrorMessage = "thu: Chưa nhập dữ liệu")]

        [StringLength(50, MinimumLength = 8, ErrorMessage = "")]
        public int thuQuantity { get; set; }
        [DisplayName("thu: nhập số lượng")]
        [Required(ErrorMessage = "thu: Hãy nhập số lượng")]
        [RegularExpression(@"[1-100]{2}", ErrorMessage = "thu: Hãy nhập 2 ký tự từ số")]
        [Range(1, 100, ErrorMessage = "thu: Hãy nhập giá trị trong khoảng [1-100]")]
        public int thuPrice { get; set; }
        [DisplayName("thu: nhập giá")]
        [Required(ErrorMessage = "thu: Hãy nhập giá tiền")]
        [RegularExpression(@"\d+\.\d+", ErrorMessage = "thu: Hãy nhập giá tiền ")]
        [Range(1, 100, ErrorMessage = "thu: giá tiền của sản phẩm ")]
        public int thuisActive { get; set; }

    }
}