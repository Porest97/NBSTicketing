using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class ReportStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ReportStatusName { get; set; }
    }
}