using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [NotNull]
        [MaxLength(50)]
        public string Login { get; set; }

        [NotNull]
        [MaxLength(50)]
        public string Password { get; set; }

        [NotNull]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string EMail { get; set; }

        [NotNull]
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public Role Role { get; set; }

    }
}