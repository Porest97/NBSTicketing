using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.DataModels
{
    public class Case
    {
        public int Id { get; set; }

        [Display(Name = "Case Type")]
        public int? CaseTypeId { get; set; }
        [Display(Name = "Case Type")]
        [ForeignKey("CaseTypeId")]
        public CaseType CaseType { get; set; }

        [Display(Name ="Case Number")]
        public string CaseNumber { get; set; }

        [Display(Name = "Case Number")]
        public string CaseDescription { get; set; }

        //Tickets Ids !
        [Display(Name = "Ticket 1")]
        public int? TicketId { get; set; }
        [Display(Name = "Ticket 1")]
        [ForeignKey("TicketId")]
        public Ticket Ticket1 { get; set; }
       
        
        [Display(Name = "Ticket 2")]
        public int? TicketId1 { get; set; }
        [Display(Name = "Ticket 2")]
        [ForeignKey("TicketId1")]
        public Ticket Ticket2 { get; set; }

        
        [Display(Name = "Ticket 3")]
        public int? TicketId3 { get; set; }
        [Display(Name = "Ticket 3")]
        [ForeignKey("TicketId3")]
        public Ticket Ticket3 { get; set; }

        //Order Ids !

        [Display(Name = "Order 1")]
        public int? OrderId { get; set; }
        [Display(Name = "Order 1")]
        [ForeignKey("OrderId")]
        public Order Order1 { get; set; }

        [Display(Name = "Order 2")]
        public int? OrderId1 { get; set; }
        [Display(Name = "Order 2")]
        [ForeignKey("OrderId1")]
        public Order Order2 { get; set; }

        [Display(Name = "Order 3")]
        public int? OrderId2 { get; set; }
        [Display(Name = "Order 3")]
        [ForeignKey("OrderId2")]
        public Order Order3 { get; set; }
                                    
        //Status Prop !
        [Display(Name = "Status")]
        public int? CaseStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("CaseStatusId")]
        public CaseStatus CaseStatus { get; set; }



    }
}
