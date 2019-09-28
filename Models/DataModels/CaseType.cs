using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class CaseType
    {
        public int Id { get; set; }

        [Display(Name ="Case Type")]
        public string CaseTypeName { get; set; }
    }
}