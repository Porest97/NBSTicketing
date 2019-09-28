using System.ComponentModel.DataAnnotations;

namespace NBSTicketing.Models.DataModels
{
    public class TicketType
    {
        public int Id { get; set; }

        [Display(Name = "Ticket Type")]
        public string TicketTypeName { get; set; }


    }
}