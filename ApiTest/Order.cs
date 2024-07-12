using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiTest
{
    public class Order
    {
        [Key]
        public int WorkOrderID { get; set; }

        public string OrderNr { get; set; }

        public DateOnly? ProductionDate { get; set; }

        public DateOnly? BestBefore { get; set; }

        public string Factory { get; set; }

        public int? MaterialNr { get; set; }
    }
}
