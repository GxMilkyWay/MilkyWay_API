using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilkyWay_API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TimeZone { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int OrganizationId { get; set; }
        public bool? Delete_Flag { get; set; }
    }
}