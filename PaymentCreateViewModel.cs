using System.ComponentModel.DataAnnotations;

namespace RaceDay222MVC.Models
{
    public class PaymentCreateViewModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "1000000")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; } = string.Empty;
    }
}