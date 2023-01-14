using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    public partial class _110_Adding_products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionCZ",
                table: "Product",
                type: "varchar(5000)",
                maxLength: 5000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEN",
                table: "Product",
                type: "varchar(5000)",
                maxLength: 5000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionImageSrc",
                table: "Product",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameCZ",
                table: "Product",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "Product",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Varanty",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "imageSrc",
                table: "Product",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DescriptionCZ", "DescriptionEN", "DescriptionImageSrc", "NameCZ", "NameEN", "Price", "Varanty", "imageSrc" },
                values: new object[] { "Na tento telefon stačí pouze odkaz na video detailním popisem https://youtu.be/j5C6X9vOEkU.", "On this phone you just need a link to a video with a detailed description https://youtu.be/j5C6X9vOEkU.", "/img/product/descriptionImg/BananaPhone.jpg", "Banán Telefon (Žlutá)", "Banana Phone (Yellow)", 1999.9000000000001, 6, "/img/product/homeImg/BananaPhone.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DescriptionCZ", "DescriptionEN", "DescriptionImageSrc", "NameCZ", "NameEN", "Price", "Varanty", "imageSrc" },
                values: new object[] { "Apple iPhone 16GB je originální ve všech směrech. Obsahuje operační systém Mac OS X, který podporuje jeho multifunkčnost a zajišťuje uživatelsky příjemné prostředí. Celému přístroji dominuje rozměrný 3,5\" dotykový displej se špičkovým rozlišením 320 x 480 pixelů a schopností zobrazit až 16 milionů barev. K dotykovému ovládání potřebujete pouze Vaše prsty, pro které je celý operační systém přizpůsoben, nevyjímaje dotykovou QWERTY klávesnici.\r\n\r\nPro pořizování digitálních fotografií a ozvučených videozáznamů je připraven vestavěný 2 megapixelový fotoaparát. Apple iPhone 16GB má bohatou vestavěnou flash paměť o velikosti 16 GB. Jak se dalo očekávat, nechybí špičková aplikace iPod pro přehrávání hudby a videa. Hudební komfort podporuje i vstup pro konektor 3,5 mm.\r\n\r\nPro komunikaci slouží bezdrátová technologie Bluetooth a podpora USB datového kabelu, k dispozici je také flexibilní Wi-Fi. Datové možnosti doplňuje GPRS a EDGE. Apple iPhone 16GB obsahuje internetový HTML prohlížeč Safari a Push E-Mail, z dalších funkcí a aplikací je třeba zmínit Google Maps, Widgets či prohlížeč a editor fotografií.", "Apple iPhone 16GB is original in every way. It includes the Mac OS X operating system, which supports its multifunctionality and provides a user-friendly environment. The entire device is dominated by a large 3.5-inch touchscreen display with a superb 320 x 480 pixel resolution and the ability to display up to 16 million colours. You only need your fingers for touch control, for which the entire operating system is adapted, not excluding the QWERTY touch keyboard.\r\n\r\nA built-in 2 megapixel camera is provided for taking digital photos and sound video recordings. Apple iPhone 16GB has a generous 16GB of built-in flash memory. As expected, there's a top-notch iPod app for music and video playback. A 3.5mm jack input also supports the music experience.\r\n\r\nBluetooth wireless technology and USB data cable support are used for communication, and flexible Wi-Fi is also available. GPRS and EDGE round out the data options. The Apple iPhone 16GB includes the Safari HTML web browser and Push E-Mail, while other features and applications include Google Maps, Widgets and a photo viewer and editor.", "/img/product/descriptionImg/iPhone.jpg", "Apple Iphone 3G 8GB (Černá)", "Apple Iphone 3G 8GB (Black)", 3499.9000000000001, 24, "/img/product/homeImg/iPhone.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DescriptionCZ", "DescriptionEN", "DescriptionImageSrc", "NameCZ", "NameEN", "Price", "Varanty", "imageSrc" },
                values: new object[] { "Mobilní telefon - 7,8\" OLED 2480 × 2200, 120Hz, procesor Qualcomm Snapdragon 888 8jádrový, RAM 6,05 GB, interní paměť 512 GB, zadní fotoaparát s optickým zoomem a variabilní clonou 50 Mpx (f/1,8) + 8 Mpx (f/2,4) + 13 Mpx (f/2,2), přední fotoaparát 10,7 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, USB-C, čtečka otisků, hybridní slot, neblokovaný, rychlé nabíjení 66W, baterie 4600 mAh, Android 10", "Mobile phone - 7.8\" OLED 2480 × 2200, 120Hz, Qualcomm Snapdragon 888 8-core processor, RAM 6.05 GB, internal memory 512 GB, rear camera with optical zoom and variable aperture 50 Mpx (f/1, 8) + 8 Mpx (f/2.4) + 13 Mpx (f/2.2), 10.7 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, USB-C, fingerprint reader, hybrid slot, unblocked, 66W fast charging, 4600 mAh battery, Android 10", "/img/product/descriptionImg/MinnieMouseHappyHelpersToyPhone.jpg", "Minnie Mouse Štastný Pomocníčci Hračka Telefon (Růžová)", "Minnie Mouse Happy Helpers Toy Phone (Pink)", 499.89999999999998, 12, "/img/product/homeImg/MinnieMouseHappyHelpersToyPhone.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DescriptionCZ", "DescriptionEN", "DescriptionImageSrc", "NameCZ", "NameEN", "Price", "Varanty", "imageSrc" },
                values: new object[] { "Je potřeba něco psát o jedinečném, legendárním a ničím nezničitelným telefonu Nokia 3310. Tento legendární kousek se zapsal do dějin svou praktičností a jedinečností. Telefon byl testován mnoha způsoby, i těmi nejdrsnějšími, a všemi testy prošel na jedničku.", "It is necessary to write something about the unique, legendary and indestructible phone Nokia 3310. This legendary piece has made history with its practicality and uniqueness. The phone has been tested in many ways, even in the harshest ones, and it passed all tests with a perfect score.", "/img/product/descriptionImg/Nokkia3310.jpg", "Nokkia 3310 (Nezničitelná)", "Nokkia 3310 (Undestroyable)", 0.0, 60, "/img/product/homeImg/Nokkia3310.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DescriptionCZ", "DescriptionEN", "DescriptionImageSrc", "NameCZ", "NameEN", "Price", "Varanty", "imageSrc" },
                values: new object[] { "Mobilní telefon - 6,7\" AMOLED 2640 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB, interní paměť 128 GB, zadní fotoaparát s optickým zoomem 12 Mpx (f/1,8) + 12 Mpx (f/2,2), přední fotoaparát 10 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, USB-C, voděodolný dle IPX8, single SIM + eSIM, neblokovaný, rychlé nabíjení 25W, bezdrátové nabíjení 10W, reverzní nabíjení 4,5W, baterie 3700 mAh, Android 12", "Mobile phone - 6.7\" AMOLED 2640 × 1080, 120Hz, Qualcomm Snapdragon 8+ Gen 1 8-core processor, 8 GB RAM, 128 GB internal memory, 12 Mpx (f/1.8) + 12 Mpx (f/2.2) rear camera with optical zoom, 10 Mpx front camera, optical stabilization, GPS, Glonass, NFC, LTE, 5G, USB-C, IPX8 waterproof, single SIM + eSIM, unblocked, 25W fast charging, 10W wireless charging, 4.5W reverse charging, 3700 mAh battery, Android 12\n\nTranslated with www.DeepL.com/Translator (free version)", "/img/product/descriptionImg/SamsungGalaxyZFlip4.jpg", "Samsung Galaxy Z Flip4 128GB (Černá)", "Samsung Galaxy Z Flip4 128GB (Black)", 34949.900000000001, 36, "/img/product/homeImg/SamsungGalaxyZFlip4.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionCZ",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DescriptionEN",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DescriptionImageSrc",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NameCZ",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Varanty",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "imageSrc",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Chleba", 100.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Máslo", 75.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Perlivě neperlivá voda", 40.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Tácek", 10.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ubrousky", 50.0 });
        }
    }
}
