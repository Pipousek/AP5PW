using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Nagy.Web.Models.Entities;

namespace UTB.Eshop.Nagy.Web.Models.Database
{
    public static class DatabaseFake
    {
        public static List<CarouselItem> CarouselItems { get; set; }

        static DatabaseFake()
        {
            DatabaseInit dbInit = new DatabaseInit();
            CarouselItems = dbInit.CreateCarouselItems();
        }
    }
}
