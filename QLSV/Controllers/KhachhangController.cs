using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using QLSV.Models;
using X.PagedList;

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
        // public IActionResult Index()
        // {
        //     var _khachhang = _context._khang.ToList();
        //     return View(_khachhang);
        // }
        
        public IActionResult Index(int? page)
        {
            var sql = _context._khang
                .FromSql($"select * from _khang where ma<>''")
                .ToList();
            
            // Truy vấn dữ liệu từ cơ sở dữ liệu
            //var _khachhang = _context._khang.ToList();

            // Số mục trên mỗi trang
            int pageSize = 10;

            // Số trang hiện tại
            int pageNumber = (page ?? 1);

            // Tạo danh sách phân trang
            //var pagedData = _khachhang.ToPagedList(pageNumber, pageSize);
            var pagedData = sql.ToPagedList(pageNumber, pageSize);

            return View(pagedData);
        }
        
        [HttpPost]
        public IActionResult Search(string searchTerm, int? page)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Nếu searchTerm trống rỗng, hiển thị lại trang danh sách không lọc
                return RedirectToAction("Index");
            }

            // Số mục trên mỗi trang
            int pageSize = 10;

            // Số trang hiện tại
            int pageNumber = page ?? 1;

            var query = _context._khang
                .Where(kh => kh.ten.Contains(searchTerm) || kh.ma.Contains(searchTerm) 
                 || kh.dia_chi.Contains(searchTerm) || kh.ma_gtgt.Contains(searchTerm)).ToList();

            var searchResults = query.ToPagedList(pageNumber, pageSize);

            return View("Index", searchResults);
        }
    }
}

