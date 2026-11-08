namespace RaceDay222MVC.Models
{
    public class PaymentViewModel
    {
        public int PaymentID { get; set; }

        public int EnrollmentID { get; set; }

        public decimal Amount { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}