using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EatEaze.Data.Entites
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [NotNull]
        public string CityName { get; set; }
    }
}