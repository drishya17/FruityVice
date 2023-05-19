using System.Runtime.ConstrainedExecution;

namespace FruityVice.Models
{
    /// <summary>
    /// FruitDto
    /// </summary>
    public class FruitDto
    {
        public string name { get; set; } = null!;
        public int id { get; set; }
        public string family { get; set; } = null!;
        public string order { get; set; } = null!;
        public string genus { get; set; } = null!;
        public NutritionsDto nutritions { get; set; } = null!;
    }
}
