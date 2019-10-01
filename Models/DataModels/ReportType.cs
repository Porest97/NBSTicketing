using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class ReportType
    {
        public int Id { get; set; }

        [Display(Name ="Report Type")]
        public string ReportTypeName { get; set; }
    }
}