﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YouthSportsRegistration.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ApplicationUser Email { get; set; }

    }
}