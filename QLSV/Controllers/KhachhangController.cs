using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLSV.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLSV.Controllers
{
    public class KhachhangController : Controller
    {
        private readonly ILogger<KhachhangController> _logger;

        //Creat dvContext variable
        private readonly MyDbContext _context;

        public KhachhangController(ILogger<KhachhangController> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var _khachhang = _context._khang.ToList();
            return View(_khachhang);
        }
    }
}

