using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.DataModels
{
    public class Report
    {
        public int Id { get; set; }

        [Display(Name = "Report Type")]
        public int? ReportTypeId { get; set; }
        [Display(Name = "Report Type")]
        [ForeignKey("ReportTypeId")]
        public ReportType ReportType { get; set; }

        [Display(Name = "Status")]
        public int? ReportStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ReportStatusId")]
        public ReportStatus ReportStatus { get; set; }

        [Display(Name = "Report Name")]
        public string ReportName { get; set; }

        [Display(Name = "Report Description")]
        public string ReportDescription { get; set; }
    }
}
