using System;
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

        public List<Child> Child_List { get; set; }

        public Parent()
        {
            Child_List = new List<Child>();
        }

    }
}