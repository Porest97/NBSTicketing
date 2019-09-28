using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class TicketStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string TicketStatusName { get; set; }
    }
}