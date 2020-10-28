using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AZIPPYFITNESS.Models;
using Microsoft.EntityFrameworkCore;

namespace AZIPPYFITNESS.Controllers
{
    public class TestDBCreateController : Controller
    {
        private readonly MembershipContext _context;

        public TestDBCreateController(MembershipContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        public async Task<IActionResult> ListMembers()
        {
            var mems = _context.Members
                .Include(m => m.MembershipStatus)
                .Include(t => t.MembershipType);
            /* One option:
            // ViewBag.mems = await mems.ToListAsync();
            //return View();
            */
            // Another option:
            return View(await mems.ToListAsync());
        }
    }
}