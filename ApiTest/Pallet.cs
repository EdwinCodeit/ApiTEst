using System.ComponentModel.DataAnnotations;

namespace ApiTest
{
    public class Pallet
    {
     
        [Key] public int SSCC { get; set; }

        public decimal? Weight { get; set; }

        public int? Units { get; set; }

        public decimal? Tara { get; set; }
    }
}
