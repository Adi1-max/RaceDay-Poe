namespace RaceDay222MVC.Models
{
    public class ParticipantViewModel
    {
        public int ParticipantID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string FullName =>
            $"{FirstName} {LastName}".Trim();
    }
}
