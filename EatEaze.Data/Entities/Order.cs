using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [AllowNull]
        public DateTime OrderDate { get; set; }

        [AllowNull]
        public DateTime DismissalDate { get; set; }

        [NotNull]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}