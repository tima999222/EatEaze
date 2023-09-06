using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class Restaraunt
    {
        [Key]
        public int RestarauntId { get; set; }

        [NotNull]
        [MaxLength(50)]
        public string RestarauntName { get; set; }

        public byte[]? RestarauntIcon { get; set; }
    }
}