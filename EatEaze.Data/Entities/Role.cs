
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [NotNull]
        public string RoleName { get; set; }
    }
}