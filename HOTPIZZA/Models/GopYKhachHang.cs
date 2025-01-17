﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOTPIZZA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class GopYKhachHang
    {
        public int IdKH { get; set; }
        [DisplayName("Nội Dung Góp Ý")]
        public string NoiDung { get; set; }
        [DisplayName("Email Khách Hàng")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string EmailKH { get; set; }
        public Nullable<System.DateTime> NgayGopY { get; set; }
        public int IdGopY { get; set; }
    }
}
