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
        public IActionResult ListTickets()
        {
            var ticketsViewModel = new TicketsViewModel
            {
               Tickets = _context.Ticket
               .Include(t => t.TicketType)
               .Include(t => t.TicketStatus)
               .Include(t => t.AssignedFE)               
               .Include(t => t.Order)
               .Include(t => t.Location)
               .ToList()

            };
            return View(ticketsViewModel);
        }
        public IActionResult ListOrders()
        {
            var ordersViewModel = new OrdersViewModel
            {
                Orders = _context.Order
               .Include(o => o.OrderType)
               .Include(o => o.OrderBy)
               .Include(o => o.OrderStatus)
               .ToList()

            };
            return View(ordersViewModel);
        }

        public IActionResult ListReports()
        {
            var reportsViewModel = new ReportsViewModel
            {
                Reports = _context.Report
               .Include(r => r.ReportType)
               .Include(r => r.ReportStatus)
               .ToList()

            };
            return View(reportsViewModel);
        }

    }
}