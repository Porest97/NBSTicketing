using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class OrderType
    {
        public int Id { get; set; }

        [Display(Name ="Status")]
        public string OrderTypeName { get; set; }
    }
}