using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.DataModels
{
    public class Ticket
    {
        public int Id { get; set; }


        [Display(Name = "Created")]
        public DateTime TicketCreated { get; set; }

        [Display(Name = "Started")]
        public DateTime? TicketStartTime { get; set; }

        [Display(Name = "Ticket Solved")]
        public DateTime? TicketEndTime { get; set; }


        //Ordered By Prop !
        [Display(Name = "Order By")]
        public int? PersonId { get; set; }
        [Display(Name = "Order By")]
        [ForeignKey("PersonId")]
        public Person OrderBy { get; set; }

        [Display(Name = "Order Number")]
        public int? OrderId { get; set; }
        [Display(Name = "Order Number")]
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        //Assigned TechPersonal Props!
        [Display(Name = "Assigned FE ")]
        public int? PersonId1 { get; set; }
        [Display(Name = "Assigned FE")]
        [ForeignKey("PersonId1")]
        public Person AssignedFE { get; set; }

        [Display(Name = "FE Sceduled")]
        public DateTime? FESceduled { get; set; }

        [Display(Name = "FE On Site")]
        public DateTime? FEOnSite { get; set; }

        [Display(Name = "FE Leaving Site")]
        public DateTime? FELeavingSite { get; set; }

        //Type Prop!
        [Display(Name = "Ticket Type")]
        public int? TicketTypeId { get; set; }
        [Display(Name = "Ticket Type")]
        [ForeignKey("TicketTypeId")]
        public TicketType TicketType { get; set; }
        
        //Description Props !
        [Display(Name ="Description")]
        public string TicketDescription { get; set; }

        //Status Prop!
        [Display(Name = "Status")]
        public int? TicketStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("TicketStatusId")]
        public TicketStatus TicketStatus { get; set; }

        //Location Prop!
        [Display(Name = "Location")]
        public int? SiteId { get; set; }
        [Display(Name = "Location")]
        [ForeignKey("SiteId")]
        public Site Location { get; set; }



    }
}
