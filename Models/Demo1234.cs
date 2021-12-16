using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo1234.Models
{
    [Table("Demo")]
    public class Demo
    {
        [Key]
        [Display(Name="ID")]
        public String DemoID { get; set; }
        [Display(Name="Họ và tên")]
        public string DemoName { get; set; }
        public string DemoGender { get; set; }
    }
}