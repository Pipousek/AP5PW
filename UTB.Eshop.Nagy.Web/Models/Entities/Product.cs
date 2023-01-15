using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using UTB.Eshop.Nagy.Domain.Implementation.Validations;

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

		[Range(0, double.MaxValue)]
		public double discountPrice { get; set; }

		[Required]
        [StringLength(500)]
        public string imageSrc { get; set; }

		[NotMapped]
		[FileContent("image")]
		public virtual IFormFile Image { get; set; }

		[Required]
		[StringLength(500)]
		public string DescriptionImageSrc { get; set; }

		[NotMapped]
		[FileContent("image")]
		public virtual IFormFile DescImage { get; set; }

		[Required]
		[StringLength(5000)]
        public string DescriptionCZ { get; set; }

		[Required]
		[StringLength(5000)]
		public string DescriptionEN { get; set; }

		[Required]
		[Range(0, 60)]
		public int Warranty { get; set; }
	}
}