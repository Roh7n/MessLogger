using System.ComponentModel.DataAnnotations;

namespace MessLogger.Models.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentStatus { get; set; }

    }
}
