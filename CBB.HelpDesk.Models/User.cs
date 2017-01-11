﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.HelpDesk.Models
{
    public class User : Base
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public User(string firstName, string lastName)
            : this(firstName, lastName, true)
        {

        }

        public User(string firstName, string lastName, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
        }
    }
}
