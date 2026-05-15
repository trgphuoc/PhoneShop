using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneShop.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? email { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? password { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? phone { get; set; }
        [Column(TypeName = "text")]
        public string? address { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Photo { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
