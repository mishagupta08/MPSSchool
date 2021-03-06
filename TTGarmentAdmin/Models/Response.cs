using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTGarmentAdmin.Models
{
    public class Response
    {
        /// <summary>
        /// gets or sets status
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// gets or sets response value
        /// </summary>
        public string ResponseValue { get; set; }

        /// <summary>
        /// gets or sets TotalRecords
        /// </summary>
        public decimal TotalRecords { get; set; }

        public List<StandardDetail> StandardDetailList { get; set; }

        public List<UserDetail> UsersList { get; set; }

        public List<TeacherSchedule> ScheduleList { get; set; }

        public List<SchoolMedia> MediaList { get; set; }

        public List<MediaTypeList> MediaTypeList { get; set; }

        public SchoolMedia MediaDetail { get; set; }

    }

    public class BarcodeDetail
    {
        public string Barcode { get; set; }

        public string RetailerId { get; set; }

        public string LocationX { get; set; }

        public string LocationY { get; set; }
    }
}