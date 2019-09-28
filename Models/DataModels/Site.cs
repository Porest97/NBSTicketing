﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.DataModels
{
    public class Site
    {
        public int Id { get; set; }

        [Display(Name = "Site Number")]
        public string SiteNumber { get; set; }

        [Display(Name = "Site Name")]
        public string SiteName { get; set; }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string SiteAddress { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "CR Number")]
        public string CompanyRegNO { get; set; }

        [Display(Name = "Phonenumber1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Phonenumber2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }

        [Display(Name = "Phonenumber3")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber3 { get; set; }

        [Display(Name = "Phonenumbers")]
        public string PhoneNumbers { get { return string.Format("{0} {1} {2} ", PhoneNumber1, PhoneNumber2, PhoneNumber3); } }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }
        [Display(Name = "Company")]
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Display(Name = "Site Type")]
        public int? SiteTypeId { get; set; }
        [Display(Name = "SiteType")]
        [ForeignKey("SiteTypeId")]
        public SiteType SiteType { get; set; }
    }
}
