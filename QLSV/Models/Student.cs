using System;
namespace QLSV.Models
{
	public class Student
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public enum gioitinh
        {
            Nam,
            Nữ,
            Khác
        }
        public gioitinh Gioitinh { get; set; }
        public string ThanhPho { get; set; }

    }
}

