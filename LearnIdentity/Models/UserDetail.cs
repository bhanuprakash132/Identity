﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LearnIdentity.Models
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
