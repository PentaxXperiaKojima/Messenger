using System;
using System.Collections.Generic;

namespace chat.Models
{
    public partial class Chat
    {
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public string Talk { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
    }
}
