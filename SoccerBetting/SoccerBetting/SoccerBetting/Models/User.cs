using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class User : BaseModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public int Point { get; set; }
        public bool AllowBetting { get; set; }
    }
}
