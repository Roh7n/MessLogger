using System.ComponentModel.DataAnnotations;

namespace MessLogger.Models.Entities
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentStatus { get; set; }

    }
}
