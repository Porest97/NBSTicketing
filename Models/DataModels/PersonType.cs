using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class PersonType
    {
        public int Id { get; set; }

        [Display(Name = "Person Type")]
        public string PersonTypeName { get; set; }
    }
}