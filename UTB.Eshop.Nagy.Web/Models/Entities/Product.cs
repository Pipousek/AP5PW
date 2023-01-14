using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop.Nagy.Web.Models.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NameEN { get; set; }

		[Required]
		[StringLength(100)]
		public string NameCZ { get; set; }

		[Range(0.01, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [StringLength(500)]
        public string imageSrc { get; set; }

		[Required]
		[StringLength(500)]
		public string DescriptionImageSrc { get; set; }

		[StringLength(5000)]
        public string DescriptionCZ { get; set; }

		[StringLength(5000)]
		public string DescriptionEN { get; set; }

		[Required]
		[Range(0, 60)]
		public int Warranty { get; set; }
	}
}