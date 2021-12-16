using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo1234.Models
{
    [Table("PersonDemo1234")]
    public class Person
    {
        [Key]
        [Display(Name="ID")]
        public String PersonID { get; set; }
        [Display(Name="Họ và tên")]
        public string PersonName { get; set; }
    }
}