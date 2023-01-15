using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Nagy.Web.Models.Entities;

namespace UTB.Eshop.Nagy.Web.Models.ViewModels
{
    public class ProductItemImageRequired : Product
    {
        [Required]
        public override IFormFile Image { get => base.Image; set => base.Image = value; }
    }
}
