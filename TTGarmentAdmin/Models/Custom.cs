using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTGarmentAdmin.Models
{
    public partial class MediaTypeList
    {
        public int Id { get; set; }
        public string MediaType { get; set; }
    }
    public partial class SchoolMedia
    {
        public int Id { get; set; }
        public string MediaType { get; set; }
        public string MediaUrl { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Extension { get; set; }
    }

    public partial class StandardDetail
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public partial class UserDetail
    {
        public decimal Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FathersName { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string Stndard { get; set; }
        public string Otp { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> IsTeacher { get; set; }
        public string Section { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
    }

    public partial class TeacherSchedule
    {
        public decimal Id { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Link { get; set; }
        public string Code { get; set; }
        public string PasswordDetail { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<decimal> TeacherId { get; set; }
        public string Subject { get; set; }
    }
}