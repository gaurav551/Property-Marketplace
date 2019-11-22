using System;
namespace Nepalists.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public int ListId { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}