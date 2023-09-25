using System;
using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
	public class Khachhang
	{
        [Key]
        public byte ma_kh { get; set; }
		public string ma { get; set; }
		public string ten { get; set; }
		public string dia_chi { get; set; }
		public string ma_gtgt { get; set; }

	}
}

