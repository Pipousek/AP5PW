using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Nagy.Domain.Implementation.Validations;

namespace UTB.Eshop.Nagy.Web.Models.Entities
{
    [Table(nameof(CarouselItem))]
    public class CarouselItem
    {
        [Key]
        public int ID { get; set; }

        [NotMapped]
        [FileContent("image")]
        public virtual IFormFile Image { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageSrc { get; set; }

        public string ImageAltCZ { get; set; }
        public string ImageAltEN { get; set; }
    }
}
