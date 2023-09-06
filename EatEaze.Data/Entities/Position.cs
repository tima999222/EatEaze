using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [NotNull]
        public string PositionName { get; set; }

        [ForeignKey("Restaraunt")]
        [NotNull]
        public int RestarauntId { get; set; }

        public Restaraunt Restaraunt { get; set; }
    }
}