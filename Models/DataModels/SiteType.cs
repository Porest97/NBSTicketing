using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class SiteType
    {
        public int Id { get; set; }

        [Display(Name = "Site Type")]
        public string SiteTypeName { get; set; }
    }
}