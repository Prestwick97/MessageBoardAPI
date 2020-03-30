using System;
namespace MessageBoard.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
        public string Group { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}