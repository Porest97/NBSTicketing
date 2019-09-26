using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class CompanyType
    {
        public int Id { get; set; }

        [Display(Name = "Company Type")]
        public string CompanyTypeName { get; set; }
    }
}