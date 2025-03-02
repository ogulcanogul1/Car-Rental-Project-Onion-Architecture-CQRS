namespace App.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Subject { get; set; } = default!;
        public string Message { get; set; } = default!;
        public DateTime SendDate { get; set; }
    }
}
