﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerDemo.Core.Models
{
    public class User:BaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
