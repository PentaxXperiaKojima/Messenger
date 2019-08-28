using System;
using System.Collections.Generic;

namespace chat.Models
{
    public partial class User
    {
        public User()
        {
            Chat = new HashSet<Chat>();
            Todo = new HashSet<Todo>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public bool DeleteFlg { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<Chat> Chat { get; set; }
        public virtual ICollection<Todo> Todo { get; set; }
    }
}
