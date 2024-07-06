namespace Scheduler.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // This should be hashed
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPhoneConfirmed { get; set; }
        public bool IsAdmin { get; set; }                 
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public int Status { get; set; }
        public int TitleId { get; set; }
        public string Title { get; set; }
        public int MinutesWorked { get; set; }
        public int ConsecutiveDaysWorked { get; set; }
        // User image 
    }
}
