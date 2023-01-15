﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTB.Eshop.Nagy.Web.Models.Database;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    [Migration("20230115105355_1.4.5")]
    partial class _145
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.CarouselItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageAltCZ")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageAltEN")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageSrc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("CarouselItem");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ImageAltCZ = "První obrázek",
                            ImageAltEN = "First slide",
                            ImageSrc = "/img/carousel/Aligator.jpg"
                        },
                        new
                        {
                            ID = 2,
                            ImageAltCZ = "Druhý obrázek",
                            ImageAltEN = "Second slide",
                            ImageSrc = "/img/carousel/Armadnitelefon.jpg"
                        },
                        new
                        {
                            ID = 3,
                            ImageAltCZ = "Třetí obrázek",
                            ImageAltEN = "Third slide",
                            ImageSrc = "/img/carousel/Nokia3310.jpg"
                        },
                        new
                        {
                            ID = 4,
                            ImageAltCZ = "Čtvrtý obrázek",
                            ImageAltEN = "Fourth slide",
                            ImageSrc = "/img/carousel/Pevnalinka.jpeg"
                        });
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("NOW(6)");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescriptionCZ")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("DescriptionEN")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("DescriptionImageSrc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("NameCZ")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NameEN")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<double>("discountPrice")
                        .HasColumnType("double");

                    b.Property<string>("imageSrc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DescriptionCZ = "Na tento telefon stačí pouze odkaz na video detailním popisem https://youtu.be/j5C6X9vOEkU.",
                            DescriptionEN = "On this phone you just need a link to a video with a detailed description https://youtu.be/j5C6X9vOEkU.",
                            DescriptionImageSrc = "/img/product/descriptionImg/BananaPhone.jpg",
                            NameCZ = "Banán Telefon (Žlutá)",
                            NameEN = "Banana Phone (Yellow)",
                            Price = 2899.9000000000001,
                            Warranty = 6,
                            discountPrice = 1999.9000000000001,
                            imageSrc = "/img/product/homeImg/BananaPhone.jpg"
                        },
                        new
                        {
                            ID = 2,
                            DescriptionCZ = "Apple iPhone 16GB je originální ve všech směrech. Obsahuje operační systém Mac OS X, který podporuje jeho multifunkčnost a zajišťuje uživatelsky příjemné prostředí. Celému přístroji dominuje rozměrný 3,5\" dotykový displej se špičkovým rozlišením 320 x 480 pixelů a schopností zobrazit až 16 milionů barev. K dotykovému ovládání potřebujete pouze Vaše prsty, pro které je celý operační systém přizpůsoben, nevyjímaje dotykovou QWERTY klávesnici.\r\n\r\nPro pořizování digitálních fotografií a ozvučených videozáznamů je připraven vestavěný 2 megapixelový fotoaparát. Apple iPhone 16GB má bohatou vestavěnou flash paměť o velikosti 16 GB. Jak se dalo očekávat, nechybí špičková aplikace iPod pro přehrávání hudby a videa. Hudební komfort podporuje i vstup pro konektor 3,5 mm.\r\n\r\nPro komunikaci slouží bezdrátová technologie Bluetooth a podpora USB datového kabelu, k dispozici je také flexibilní Wi-Fi. Datové možnosti doplňuje GPRS a EDGE. Apple iPhone 16GB obsahuje internetový HTML prohlížeč Safari a Push E-Mail, z dalších funkcí a aplikací je třeba zmínit Google Maps, Widgets či prohlížeč a editor fotografií.",
                            DescriptionEN = "Apple iPhone 16GB is original in every way. It includes the Mac OS X operating system, which supports its multifunctionality and provides a user-friendly environment. The entire device is dominated by a large 3.5-inch touchscreen display with a superb 320 x 480 pixel resolution and the ability to display up to 16 million colours. You only need your fingers for touch control, for which the entire operating system is adapted, not excluding the QWERTY touch keyboard.\r\n\r\nA built-in 2 megapixel camera is provided for taking digital photos and sound video recordings. Apple iPhone 16GB has a generous 16GB of built-in flash memory. As expected, there's a top-notch iPod app for music and video playback. A 3.5mm jack input also supports the music experience.\r\n\r\nBluetooth wireless technology and USB data cable support are used for communication, and flexible Wi-Fi is also available. GPRS and EDGE round out the data options. The Apple iPhone 16GB includes the Safari HTML web browser and Push E-Mail, while other features and applications include Google Maps, Widgets and a photo viewer and editor.",
                            DescriptionImageSrc = "/img/product/descriptionImg/iPhone3G.jpg",
                            NameCZ = "Apple Iphone 3G 8GB (Černá)",
                            NameEN = "Apple Iphone 3G 8GB (Black)",
                            Price = 4999.8999999999996,
                            Warranty = 24,
                            discountPrice = 3499.9000000000001,
                            imageSrc = "/img/product/homeImg/iPhone3G.jpg"
                        },
                        new
                        {
                            ID = 3,
                            DescriptionCZ = "Mobilní telefon - 7,8\" OLED 2480 × 2200, 120Hz, procesor Qualcomm Snapdragon 888 8jádrový, RAM 6,05 GB, interní paměť 512 GB, zadní fotoaparát s optickým zoomem a variabilní clonou 50 Mpx (f/1,8) + 8 Mpx (f/2,4) + 13 Mpx (f/2,2), přední fotoaparát 10,7 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, USB-C, čtečka otisků, hybridní slot, neblokovaný, rychlé nabíjení 66W, baterie 4600 mAh, Android 10",
                            DescriptionEN = "Mobile phone - 7.8\" OLED 2480 × 2200, 120Hz, Qualcomm Snapdragon 888 8-core processor, RAM 6.05 GB, internal memory 512 GB, rear camera with optical zoom and variable aperture 50 Mpx (f/1, 8) + 8 Mpx (f/2.4) + 13 Mpx (f/2.2), 10.7 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, USB-C, fingerprint reader, hybrid slot, unblocked, 66W fast charging, 4600 mAh battery, Android 10",
                            DescriptionImageSrc = "/img/product/descriptionImg/MinnieMouseHappyHelpersToyPhone.jpg",
                            NameCZ = "Minnie Mouse Štastný Pomocníčci Hračka Telefon (Růžová)",
                            NameEN = "Minnie Mouse Happy Helpers Toy Phone (Pink)",
                            Price = 649.89999999999998,
                            Warranty = 12,
                            discountPrice = 499.89999999999998,
                            imageSrc = "/img/product/homeImg/MinnieMouseHappyHelpersToyPhone.jpg"
                        },
                        new
                        {
                            ID = 4,
                            DescriptionCZ = "Je potřeba něco psát o jedinečném, legendárním a ničím nezničitelným telefonu Nokia 3310. Tento legendární kousek se zapsal do dějin svou praktičností a jedinečností. Telefon byl testován mnoha způsoby, i těmi nejdrsnějšími, a všemi testy prošel na jedničku.",
                            DescriptionEN = "It is necessary to write something about the unique, legendary and indestructible phone Nokia 3310. This legendary piece has made history with its practicality and uniqueness. The phone has been tested in many ways, even in the harshest ones, and it passed all tests with a perfect score.",
                            DescriptionImageSrc = "/img/product/descriptionImg/Nokia3310.jpg",
                            NameCZ = "Nokkia 3310 (Nezničitelná)",
                            NameEN = "Nokkia 3310 (Undestroyable)",
                            Price = 7999.8999999999996,
                            Warranty = 60,
                            discountPrice = 0.0,
                            imageSrc = "/img/product/homeImg/Nokia3310.jpg"
                        },
                        new
                        {
                            ID = 5,
                            DescriptionCZ = "Mobilní telefon - 6,7\" AMOLED 2640 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB, interní paměť 128 GB, zadní fotoaparát s optickým zoomem 12 Mpx (f/1,8) + 12 Mpx (f/2,2), přední fotoaparát 10 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, USB-C, voděodolný dle IPX8, single SIM + eSIM, neblokovaný, rychlé nabíjení 25W, bezdrátové nabíjení 10W, reverzní nabíjení 4,5W, baterie 3700 mAh, Android 12",
                            DescriptionEN = "Mobile phone - 6.7\" AMOLED 2640 × 1080, 120Hz, Qualcomm Snapdragon 8+ Gen 1 8-core processor, 8 GB RAM, 128 GB internal memory, 12 Mpx (f/1.8) + 12 Mpx (f/2.2) rear camera with optical zoom, 10 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, 5G, USB-C, IPX8 waterproof, single SIM + eSIM, unblocked, 25W fast charging, 10W wireless charging, 4.5W reverse charging, 3700 mAh battery, Android 12\n\nTranslated with www.DeepL.com/Translator (free version)",
                            DescriptionImageSrc = "/img/product/descriptionImg/SamsungGalaxyZFlip4.jpg",
                            NameCZ = "Samsung Galaxy Z Flip4 128GB (Černá)",
                            NameEN = "Samsung Galaxy Z Flip4 128GB (Black)",
                            Price = 54299.900000000001,
                            Warranty = 36,
                            discountPrice = 34949.900000000001,
                            imageSrc = "/img/product/homeImg/SamsungGalaxyZFlip4.jpg"
                        });
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "9cf14c2c-19e7-40d6-b744-8917505c3106",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "be0efcde-9d0a-461d-8eb6-444b043d6660",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c",
                            Email = "admin@admin.cz",
                            EmailConfirmed = true,
                            FirstName = "Adminek",
                            LastName = "Adminovy",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@ADMIN.CZ",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7a8d96fd-5918-441b-b800-cbafa99de97b",
                            Email = "manager@manager.cz",
                            EmailConfirmed = true,
                            FirstName = "Managerek",
                            LastName = "Managerovy",
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MANAGER.CZ",
                            NormalizedUserName = "MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                            TwoFactorEnabled = false,
                            UserName = "manager"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.Order", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.OrderItem", b =>
                {
                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTB.Eshop.Nagy.Web.Models.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UTB.Eshop.Nagy.Web.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
