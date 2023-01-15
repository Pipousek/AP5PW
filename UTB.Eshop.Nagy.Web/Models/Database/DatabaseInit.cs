using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Nagy.Web.Models.Entities;
using UTB.Eshop.Nagy.Web.Models.Identity;

namespace UTB.Eshop.Nagy.Web.Models.Database
{
    public class DatabaseInit
    {
        public List<CarouselItem> CreateCarouselItems()
        {
            List<CarouselItem> carouselItems = new List<CarouselItem>();

            CarouselItem ci1 = new CarouselItem()
            {
                ID = 1,
                ImageSrc = "/img/carousel/Aligator.jpg",
                ImageAltEN = "First slide",
                ImageAltCZ = "První obrázek"
            };

            CarouselItem ci2 = new CarouselItem()
            {
                ID = 2,
                ImageSrc = "/img/carousel/Armadnitelefon.jpg",
                ImageAltEN = "Second slide",
                ImageAltCZ = "Druhý obrázek"
            };

            CarouselItem ci3 = new CarouselItem()
            {
                ID = 3,
                ImageSrc = "/img/carousel/Nokia3310.jpg",
                ImageAltEN = "Third slide",
                ImageAltCZ = "Třetí obrázek"
            };

            CarouselItem ci4 = new CarouselItem()
            {
                ID = 4,
                ImageSrc = "/img/carousel/Pevnalinka.jpeg",
                ImageAltEN = "Fourth slide",
                ImageAltCZ = "Čtvrtý obrázek"
            };


            carouselItems.Add(ci1);
            carouselItems.Add(ci2);
            carouselItems.Add(ci3);
            carouselItems.Add(ci4);

            return carouselItems;
        }

        public List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();


            Product cs1 = new Product()
            {
                ID = 1,
                NameEN = "Banana Phone (Yellow)",
                NameCZ = "Banán Telefon (Žlutá)",
                Price = 2899.90,
                discountPrice = 1999.90,
                imageSrc = "/img/product/homeImg/BananaPhone.jpg",
				DescriptionImageSrc = "/img/product/descriptionImg/BananaPhone.jpg",
				DescriptionCZ = "Na tento telefon stačí pouze odkaz na video detailním popisem https://youtu.be/j5C6X9vOEkU.",
                DescriptionEN = "On this phone you just need a link to a video with a detailed description https://youtu.be/j5C6X9vOEkU.",
                Warranty = 6
            };

            Product cs2 = new Product()
            {
				ID = 2,
				NameEN = "Apple Iphone 3G 8GB (Black)",
				NameCZ = "Apple Iphone 3G 8GB (Černá)",
				Price = 4999.90,
				discountPrice = 3499.90,
				imageSrc = "/img/product/homeImg/iPhone3G.jpg",
				DescriptionImageSrc = "/img/product/descriptionImg/iPhone3G.jpg",
				DescriptionCZ = "Apple iPhone 16GB je originální ve všech směrech. Obsahuje operační systém Mac OS X, který podporuje jeho multifunkčnost a zajišťuje uživatelsky příjemné prostředí. Celému přístroji dominuje rozměrný 3,5\" dotykový displej se špičkovým rozlišením 320 x 480 pixelů a schopností zobrazit až 16 milionů barev. K dotykovému ovládání potřebujete pouze Vaše prsty, pro které je celý operační systém přizpůsoben, nevyjímaje dotykovou QWERTY klávesnici.\r\n\r\nPro pořizování digitálních fotografií a ozvučených videozáznamů je připraven vestavěný 2 megapixelový fotoaparát. Apple iPhone 16GB má bohatou vestavěnou flash paměť o velikosti 16 GB. Jak se dalo očekávat, nechybí špičková aplikace iPod pro přehrávání hudby a videa. Hudební komfort podporuje i vstup pro konektor 3,5 mm.\r\n\r\nPro komunikaci slouží bezdrátová technologie Bluetooth a podpora USB datového kabelu, k dispozici je také flexibilní Wi-Fi. Datové možnosti doplňuje GPRS a EDGE. Apple iPhone 16GB obsahuje internetový HTML prohlížeč Safari a Push E-Mail, z dalších funkcí a aplikací je třeba zmínit Google Maps, Widgets či prohlížeč a editor fotografií.",
				DescriptionEN = "Apple iPhone 16GB is original in every way. It includes the Mac OS X operating system, which supports its multifunctionality and provides a user-friendly environment. The entire device is dominated by a large 3.5-inch touchscreen display with a superb 320 x 480 pixel resolution and the ability to display up to 16 million colours. You only need your fingers for touch control, for which the entire operating system is adapted, not excluding the QWERTY touch keyboard.\r\n\r\nA built-in 2 megapixel camera is provided for taking digital photos and sound video recordings. Apple iPhone 16GB has a generous 16GB of built-in flash memory. As expected, there's a top-notch iPod app for music and video playback. A 3.5mm jack input also supports the music experience.\r\n\r\nBluetooth wireless technology and USB data cable support are used for communication, and flexible Wi-Fi is also available. GPRS and EDGE round out the data options. The Apple iPhone 16GB includes the Safari HTML web browser and Push E-Mail, while other features and applications include Google Maps, Widgets and a photo viewer and editor.",
				Warranty = 24
			};

            Product cs3 = new Product()
            {
				ID = 3,
				NameEN = "Minnie Mouse Happy Helpers Toy Phone (Pink)",
				NameCZ = "Minnie Mouse Štastný Pomocníčci Hračka Telefon (Růžová)",
				Price = 649.90,
				discountPrice = 499.90,
				imageSrc = "/img/product/homeImg/MinnieMouseHappyHelpersToyPhone.jpg",
				DescriptionImageSrc = "/img/product/descriptionImg/MinnieMouseHappyHelpersToyPhone.jpg",
				DescriptionCZ = "Mobilní telefon - 7,8\" OLED 2480 × 2200, 120Hz, procesor Qualcomm Snapdragon 888 8jádrový, RAM 6,05 GB, interní paměť 512 GB, zadní fotoaparát s optickým zoomem a variabilní clonou 50 Mpx (f/1,8) + 8 Mpx (f/2,4) + 13 Mpx (f/2,2), přední fotoaparát 10,7 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, USB-C, čtečka otisků, hybridní slot, neblokovaný, rychlé nabíjení 66W, baterie 4600 mAh, Android 10",
				DescriptionEN = "Mobile phone - 7.8\" OLED 2480 × 2200, 120Hz, Qualcomm Snapdragon 888 8-core processor, RAM 6.05 GB, internal memory 512 GB, rear camera with optical zoom and variable aperture 50 Mpx (f/1, 8) + 8 Mpx (f/2.4) + 13 Mpx (f/2.2), 10.7 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, USB-C, fingerprint reader, hybrid slot, unblocked, 66W fast charging, 4600 mAh battery, Android 10",
				Warranty = 12
			};

            Product cs4 = new Product()
            {
                ID = 4,
                NameEN = "Nokkia 3310 (Undestroyable)",
                NameCZ = "Nokkia 3310 (Nezničitelná)",
                Price = 7999.90,
                discountPrice = 0.0,
				imageSrc = "/img/product/homeImg/Nokia3310.jpg",
				DescriptionImageSrc = "/img/product/descriptionImg/Nokia3310.jpg",
				DescriptionCZ = "Je potřeba něco psát o jedinečném, legendárním a ničím nezničitelným telefonu Nokia 3310. Tento legendární kousek se zapsal do dějin svou praktičností a jedinečností. Telefon byl testován mnoha způsoby, i těmi nejdrsnějšími, a všemi testy prošel na jedničku.",
				DescriptionEN = "It is necessary to write something about the unique, legendary and indestructible phone Nokia 3310. This legendary piece has made history with its practicality and uniqueness. The phone has been tested in many ways, even in the harshest ones, and it passed all tests with a perfect score.",
				Warranty = 60
			};

            Product cs5 = new Product()
            {
				ID = 5,
				NameEN = "Samsung Galaxy Z Flip4 128GB (Black)",
				NameCZ = "Samsung Galaxy Z Flip4 128GB (Černá)",
				Price = 54299.90,
				discountPrice = 34949.90,
				imageSrc = "/img/product/homeImg/SamsungGalaxyZFlip4.jpg",
				DescriptionImageSrc = "/img/product/descriptionImg/SamsungGalaxyZFlip4.jpg",
				DescriptionCZ = "Mobilní telefon - 6,7\" AMOLED 2640 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB, interní paměť 128 GB, zadní fotoaparát s optickým zoomem 12 Mpx (f/1,8) + 12 Mpx (f/2,2), přední fotoaparát 10 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, USB-C, voděodolný dle IPX8, single SIM + eSIM, neblokovaný, rychlé nabíjení 25W, bezdrátové nabíjení 10W, reverzní nabíjení 4,5W, baterie 3700 mAh, Android 12",
				DescriptionEN = "Mobile phone - 6.7\" AMOLED 2640 × 1080, 120Hz, Qualcomm Snapdragon 8+ Gen 1 8-core processor, 8 GB RAM, 128 GB internal memory, 12 Mpx (f/1.8) + 12 Mpx (f/2.2) rear camera with optical zoom, 10 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, 5G, USB-C, IPX8 waterproof, single SIM + eSIM, unblocked, 25W fast charging, 10W wireless charging, 4.5W reverse charging, 3700 mAh battery, Android 12\n\nTranslated with www.DeepL.com/Translator (free version)",
				Warranty = 36
			};

            products.Add(cs1);
            products.Add(cs2);
            products.Add(cs3);
            products.Add(cs4);
            products.Add(cs5);

            return products;
        }
        public List<Role> CreateRoles()
        {
            List<Role> roles = new List<Role>();

            Role roleAdmin = new Role()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "9cf14c2c-19e7-40d6-b744-8917505c3106"
            };

            Role roleManager = new Role()
            {
                Id = 2,
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "be0efcde-9d0a-461d-8eb6-444b043d6660"
            };

            Role roleCustomer = new Role()
            {
                Id = 3,
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee"
            };


            roles.Add(roleAdmin);
            roles.Add(roleManager);
            roles.Add(roleCustomer);

            return roles;
        }


        public (User, List<IdentityUserRole<int>>) CreateAdminWithRoles()
        {
            User admin = new User()
            {
                Id = 1,
                FirstName = "Adminek",
                LastName = "Adminovy",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.cz",
                NormalizedEmail = "ADMIN@ADMIN.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==",
                SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> adminUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 1
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 3
                }
            };

            return (admin, adminUserRoles);
        }


        public (User, List<IdentityUserRole<int>>) CreateManagerWithRoles()
        {
            User manager = new User()
            {
                Id = 2,
                FirstName = "Managerek",
                LastName = "Managerovy",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@manager.cz",
                NormalizedEmail = "MANAGER@MANAGER.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                ConcurrencyStamp = "7a8d96fd-5918-441b-b800-cbafa99de97b",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> managerUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 3
                }
            };

            return (manager, managerUserRoles);
        }
    }
}
