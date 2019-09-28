using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBSTicketing.Data;
using NBSTicketing.Models.ViewModels;

namespace NBSTicketing.Controllers
{
    public class ListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCompanies()
        {
            var companiesViewModel = new CompaniesViewModel()
            {
                Companies = _context.Company
                .Include(c => c.CompanyType).ToList()
            };
            return View(companiesViewModel);

        }

        public IActionResult ListPeople()
        {
            var peopleViewModel = new PeopleViewModel()
            {
                People = _context.Person
                .Include(p=>p.PersonType)
                .Include(p=>p.IdentityUser)
                .Include(p=>p.Company)
                .ToList()
            };
            return View(peopleViewModel);
        }

        public IActionResult ListSites()
        {
            var sitesViewModel = new SitesViewModel
            {
                Sites = _context.Site
                .Include(s => s.SiteType)
                .Include(s=>s.Company)
                .ToList()
            };
            return View(sitesViewModel);
        }
        

        public async Task<IActionResult> Companies()
        {
            var applicationDbContext = _context.Company.Include(c => c.CompanyType);
            return View(await applicationDbContext.ToListAsync());
        }
    }
}