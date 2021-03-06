using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTGarmentAdmin.Models
{
    public class AdminMaster
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}