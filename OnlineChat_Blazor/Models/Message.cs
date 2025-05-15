namespace OnlineChat_Blazor.Models
{
    public class Message
    {
        public int Id { get; set; } = 0;
        public required User User { get; set; }

        public DateTime DateTime { get; set; }

        public required string Text { get; set; } 


    }
}
