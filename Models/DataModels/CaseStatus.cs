using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class CaseStatus
    {
        public int Id { get; set; }


        [Display(Name ="Status")]
        public string CaseStatusName { get; set; }
    }
}