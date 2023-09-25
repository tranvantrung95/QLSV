using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLSV.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLSV.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        private readonly List<Student> _students = new List<Student>
        {
        new Student { Id = 1, Name = "Alice", Gioitinh=Models.Student.gioitinh.Nam,ThanhPho="Ha Noi"},
        new Student { Id = 2, Name = "Bob", Gioitinh=Models.Student.gioitinh.Nữ,ThanhPho="Quang Ninh" },
        new Student { Id = 3, Name = "Trung", Gioitinh=Models.Student.gioitinh.Nam,ThanhPho="Tay Ninh"},
        new Student { Id = 4, Name = "Hieu",Gioitinh=Models.Student.gioitinh.Nam,ThanhPho="Hai Phong" },
        new Student { Id = 5, Name = "Trang" ,Gioitinh=Models.Student.gioitinh.Nữ,ThanhPho="Tuyen Quang"},
        new Student { Id = 6, Name = "Doan" ,Gioitinh=Models.Student.gioitinh.Khác,ThanhPho="Bac Can"}
    };

        public IActionResult Index()
        {
            return View(_students);
        }
    }
}

