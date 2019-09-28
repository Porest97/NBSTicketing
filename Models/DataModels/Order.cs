using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBSTicketing.Models.DataModels
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Created")]
        public DateTime OrderCreated { get; set; }

        //Description Props !
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }
        

        //Order By Prop !
        [Display(Name = "Order By")]
        public int? PersonId { get; set; }
        [Display(Name = "Order By")]
        [ForeignKey("PersonId")]
        public Person OrderBy { get; set; }

        //Description Props !
        [Display(Name = "Description")]
        public string OrderDescription { get; set; }

        //Type Prop!
        [Display(Name = "Order Type")]
        public int? OrderTypeId { get; set; }
        [Display(Name = "Order Type")]
        [ForeignKey("OrderTypeId")]
        public OrderType OrderType { get; set; }



        //Status Prop!
        [Display(Name = "Status")]
        public int? OrderStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("OrderStatusId")]
        public OrderStatus OrderStatus { get; set; }

    }
}