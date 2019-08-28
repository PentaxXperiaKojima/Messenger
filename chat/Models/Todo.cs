using System;
using System.Collections.Generic;

namespace chat.Models
{
    public partial class Todo
    {
        public int UserId { get; set; }
        public int TodoId { get; set; }
        public string TodoContent { get; set; }
        public bool Complete { get; set; }
        public bool DeleteFlg { get; set; }
        public DateTime AddDate { get; set; }

        public virtual User User { get; set; }
    }
}
