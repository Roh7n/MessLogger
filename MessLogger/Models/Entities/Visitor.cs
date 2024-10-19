using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessLogger.Models.Entities
{
    public class Visitor : IdentityUser
    { 
        

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string? FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentStatus { get; set; }

    }
}