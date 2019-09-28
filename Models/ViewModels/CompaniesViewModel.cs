using NBSTicketing.Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.ViewModels
{
    public class CompaniesViewModel
    {
        public List<Company> Companies { get; set; }
               
    }
}
