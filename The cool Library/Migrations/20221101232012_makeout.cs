using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_cool_Library.Migrations
{
    public partial class makeout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Book_author = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Book_publisher = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Book_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Book_price = table.Column<double>(type: "float", nullable: false),
                    Book_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_quantity = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Bill = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "ecc249e4-e8b6-4030-89c5-e38d219400bd", "Administrator", "Administrator" },
                    { "B", "2d17b94f-0891-4335-ac0c-b0637f142e01", "StoreOwner", "StoreOwner" },
                    { "C", "a5095727-52a2-4a48-b007-215b55135d1e", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "73a41a73-8c1c-4eac-ae8f-c60ebe925889", "admin@fpt.com", true, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEA3dV5waJKi53w1W7CTU4LK4m2FBwsmX7kvEA+wZKR61CxMvuMJ2Gm42wCNcTxIWRA==", null, false, "d3bac925-24ae-422f-898b-e49a427fbf06", false, "admin@fpt.com" },
                    { "2", 0, "67a87534-eb28-4682-b215-78fc4badbe09", "storeowner@fpt.com", true, false, null, null, "storeowner@fpt.com", "AQAAAAEAACcQAAAAEAlgYUznHwFQTPbxDk9l8WsERRrjJ+24MSvOHe8pFGxNewfWp63/3co69gTr2C4shQ==", null, false, "625b334f-0ddb-461a-9f30-1b35003dd468", false, "storeowner@fpt.com" },
                    { "3", 0, "99bf321d-f9d5-4e43-87a4-f5f103ec9d59", "customer@fpt.com", true, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAEHICrwFrzWpoCrdIDUXFxmFGjAVU9OFInVYcz+HY0a+p+lKwDclRX9tLYD3Tmz6DZg==", null, false, "ff85d52f-649b-4bc7-9e78-055d4434301d", false, "customer@fpt.com" },
                    { "4", 0, "91791b4d-9dc0-4158-b20b-4b1c22e08214", "cus2@fpt.com", true, false, null, null, "cus2@fpt.com", "AQAAAAEAACcQAAAAEMLUewoV9zGsiXOTFjQDIADS+OOxM9m5zWEVu8iVu8/xDVGpK5rRdu0R6euAKEUK6w==", null, false, "fa13f13b-9709-4b24-9921-f9a712de4551", false, "Cus2" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Genre_name" },
                values: new object[,]
                {
                    { 1, "Fiction Novel" },
                    { 2, "Literary Book" },
                    { 3, "Romance Novel" },
                    { 4, "Detective Book" },
                    { 5, "Comic" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A", "1" },
                    { "B", "2" },
                    { "C", "3" },
                    { "C", "4" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Book_author", "Book_date", "Book_description", "Book_image", "Book_language", "Book_name", "Book_price", "Book_publisher", "Book_quantity", "GenreId" },
                values: new object[,]
                {
                    { 27, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The world is at war and the prophesied savior is nowhere to be found. The Witcher, Geralt of Rivia, races to find her in the fourth novel of Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games. \r\nThe world has fallen into war. Ciri, the child of prophecy, has vanished. Hunted by friends and foes alike, she has taken on the guise of a petty bandit and lives free for the first time in her life.\r\nBut the net around her is closing. Geralt, the Witcher, has assembled a group of allies including Dandelion, Milva, Regis, and Cahir, to rescue her. Both sides of the war have sent brutal mercenaries to hunt her down. Her crimes have made her famous.\r\nThere is only one place left to run. The tower of the swallow is waiting. . .\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452960.jpg?fit=450%2C675", "German", "The Tower of Swallows", 17.989999999999998, "Orbit", 30, 1 },
                    { 28, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trapped in a world ruled by the Elves, separated from Geralt and her destiny, Ciri will need all her training as a fighter and sorceress to survive in the fifth novel of the Witcher, Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nAfter walking through the portal in the Tower of Swallows and narrowly escaping death, Ciri finds herself in a completely different world. . . an Elven world. Time does not seem to exist and there are no obvious borders or portals to cross back into her home world. She is trapped.\r\nBut this is the child of prophecy, and she will not be defeated. She knows she must escape to finally rejoin the Witcher and his companions—and also to conquer her worst nightmare. Leo Bonhart, the man who chased, wounded, and tortured Ciri, is still on her trail. And the world is still at war.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316453066.jpg?fit=450%2C673", "German", "The Lady of the Lake", 17.989999999999998, "Orbit", 30, 1 },
                    { 29, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Before he was the guardian of Ciri, the child of destiny, Geralt of Rivia was a legendary swordsman. Join the Witcher as he undertakes a deadly mission in this stand-alone adventure set in the Andrzej Sapkowki’s groundbreaking epic fantasy world that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt of Rivia is a Witcher, one of the few capable of hunting the monsters that prey on humanity. He uses magical signs, potions, and the pride of every Witcher—two swords, steel and silver.\r\nBut a contract has gone wrong, and Geralt finds himself without his signature weapons. Now he needs them back, because sorcerers are scheming, and across the world clouds are gathering.\r\nThe season of storms is coming. . .\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316453165.jpg?fit=450%2C675", "German", "Season of Storms", 17.989999999999998, "Orbit", 30, 1 },
                    { 30, "Harper Lee", new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it. \"To Kill A Mockingbird\" became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1553383690l/2657.jpg", "German", "To Kill a Mockingbird", 7.0, "Harper Perennial Modern Classics", 30, 2 },
                    { 31, "Charlotte Brontë", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orphaned as a child, Jane has felt an outcast her whole young life. Her courage is tested once again when she arrives at Thornfield Hall, where she has been hired by the brooding, proud Edward Rochester to care for his ward Adèle. Jane finds herself drawn to his troubled yet kind spirit. She falls in love. Hard.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1557343311l/10210._SY475_.jpg", "German", "Jane Eyre", 10.0, "Penguin", 30, 2 },
                    { 32, "Fyodor Dostoyevsky", new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1382846449l/7144.jpg", "German", "Crime and Punishment", 12.0, "Penguin", 30, 2 },
                    { 33, "J.D. Salinger", new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleeing the crooks at Pencey Prep, he pinballs around New York City seeking solace in fleeting encounters—shooting the bull with strangers in dive hotels, wandering alone round Central Park, getting beaten up by pimps and cut down by erstwhile girlfriends.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1398034300l/5107.jpg", "German", "The Catcher in the Rye", 5.0, "Back Bay Books", 30, 2 },
                    { 34, "F. Scott Fitzgerald", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1490528560l/4671._SY475_.jpg", "German", "The Great Gatsby", 15.0, "Scribner", 30, 2 },
                    { 35, "Jane Austen", new DateTime(2000, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\"", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1320399351l/1885.jpg", "German", "Pride and Prejudice", 7.0, "Modern Library", 30, 3 },
                    { 36, "E.L. James", new DateTime(2011, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1385207843l/10818853.jpg", "German", "Fifty Shades of Grey", 12.0, "Vintage", 30, 3 },
                    { 37, "Jamie McGuire", new DateTime(2011, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Abby Abernathy is a good girl. She doesn’t drink or swear, and she has the appropriate number of cardigans in her wardrobe. Abby believes she has enough distance from the darkness of her past, but when she arrives at college with her best friend, her path to a new beginning is quickly challenged by Eastern University's Walking One-Night Stand.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358259032l/11505797.jpg", "German", "Beautiful Disaster", 4.0, "Jamie McGuire", 30, 3 },
                    { 39, "Simone Elkeles", new DateTime(2008, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "When Brittany Ellis walks into chemistry class on the first day of senior year, she has no clue that her carefully created 'perfect' life is about to unravel before her eyes. She's forced to be lab partners with Alex Fuentes, a gang member from the other side of town, and he is about to threaten everything she…", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1439792475l/4268157.jpg", "German", "Perfect Chemistry", 10.0, "Walker Childrens", 30, 3 },
                    { 26, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A deadly coup within the Wizard’s Guild leaves the Witcher, Geralt of Rivia, gravely injured, and his ward Ciri missing in the third novel of Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games. \r\nThe Wizards Guild has been shattered by a coup, an uprising that has left Geralt seriously injured.\r\nThe Witcher is supposed to be a guardian of the innocent, a protector of those in need, a defender against powerful and dangerous monsters that prey on men in dark times. But now that dark times have fallen upon the world, Geralt is helpless until he has recovered.\r\nWhile war rages across the lands, the future of magic is under threat and those sorcerers who survive are determined to protect it. It’s an impossible situation in which to find one girl—Ciri, the heiress to the throne of Cintra—until a rumor places her in the Niflgaard court, preparing to marry the Emperor.\r\nInjured or not, Geralt has a rescue mission on his hands.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452861.jpg?fit=450%2C675", "German", "Baptism of Fire", 17.989999999999998, "Orbit", 30, 1 },
                    { 40, "Nicholas Sparks", new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set amid the austere beauty of the North Carolina coast begins the story of Noah Calhoun, a rural Southerner recently returned from the Second World War. Noah is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1483183484l/33648131._SY475_.jpg", "German", "The Notebook", 13.0, "Grand Central Publishing", 30, 3 },
                    { 41, "Arthur Conan Doyle", new DateTime(1887, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Referring to himself as a \"consulting detective\" in stories, Holmes is known for his excellent powers of observation, deduction, forensic science, and logical deduction, elements of which he applies when investigating. cases of a variety of clients, including Scotland Yard.", "https://www.nhasachminhthang.vn/UserFiles/files/sherlock%20t%E1%BA%ADp%203%20120k.png", "German", "Sherlock Holmes", 20.0, "Literary publishers", 30, 4 },
                    { 42, "Agatha Christie", new DateTime(1937, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The work is about a murder that happened on a cruise ship on the Nile while detective Hercule Poirot was on vacation in Egypt. This is one of Agatha Christie's most beloved novels, which has been adapted into plays and movies many times.", "https://agathachristie.imgix.net/image-store/Jacket_FilmTieInDOTN.jpg?auto=compress,format&fit=clip&q=65&w=400", "German", "Death on the Nile", 15.0, "Collins Crime Club", 30, 4 },
                    { 43, "Thomas Harris", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silence of the Lambs is the story of a tense mind battle between FBI police woman Clarice Starling and cannibal doctor Hannibal Lecter. In order to find clues to the case of kidnapping the senator's daughter, Starling has to go to the Tri Vien Nursing Home to get information about the case.", "https://salt.tikicdn.com/cache/w1200/media/catalog/product/s/u/su-im-lang-cua-bay-cuu.jpg", "German", "The Silence of the Lambs", 17.0, "ST. Martin’s Press", 30, 4 },
                    { 44, "Dan Brown", new DateTime(2013, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The opening story is a bit confusing when the professor wakes up in an unfamiliar hospital and has almost lost all memories of the past few days. And at that time, he also had to immediately run away from a series of pursuers without knowing the reason. Still a familiar motif in our previous works, but we never seem to get bored, but on the contrary, we always anxiously follow each cleverly deciphered puzzle, code, and symbol.", "https://cdn0.fahasa.com/media/catalog/product/i/m/image_195509_1_31875.jpg", "German", "Inferno", 18.0, "Doubleday", 30, 4 },
                    { 45, "Dan Brown", new DateTime(2003, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The plot of the novel tells about the conspiracy of the Catholic Church to hide the truth about Jesus. The story implies that the Holy See of Rome knew about this plot for two thousand years, but still kept it a secret to maintain its power. Upon its publication, the novel strongly aroused curiosity around the world to find out the truth about the Legend of the Holy Grail, and Mary Magdalene's role in the history of the Catholic Church.", "https://upload.wikimedia.org/wikipedia/vi/thumb/8/84/M%E1%BA%ADt_m%C3%A3_davinci.jpg/220px-M%E1%BA%ADt_m%C3%A3_davinci.jpg", "German", "The Da Vinci Code", 19.0, "Doubleday Fiction", 30, 4 },
                    { 46, "Aoyama Gōshō", new DateTime(1994, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The story revolves around a high school detective named Kudo Shinichi, while investigating a mysterious Black Organization, was forced to drink a deadly poison. Fortunately, he survived, but his body was shrunken like a 6-year-old child. In order to avoid revealing his true identity, he took the name Edogawa Conan and moved in with his childhood friend Ran Mori's house with her father, a private detective named Mori Kogoro. Hopefully one day he can defeat the Black Organization and regain his original form.", "http://cdn.shopify.com/s/files/1/0566/9650/4367/products/Conan99.webp?v=1662734369", "German", "Detective Conan", 3.0, "Shogakukan", 30, 5 },
                    { 47, "Usui Yoshito", new DateTime(2010, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The content revolves around the boy Shin with stories about daily life with his parents, younger sister, dog Snow White, friends, neighbors, close relatives and other characters.", "https://product.hstatic.net/200000122283/product/shin-cau-be-but-chi-tap-34-l3uhj_d78f2c3421d34d5e8aa1eda525e7a7f4_master.png", "German", "Crayon Shin-chan", 4.0, "Futabasha", 30, 5 },
                    { 48, "Fujiko F. Fujio", new DateTime(1996, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The series content tells about the unfortunate life of the boy Nobita and the robotic cat Doraemon from the future who come to help the boy's life become better.", "https://product.hstatic.net/200000122283/product/doraemon-truyen-ngan-tap-20-tai-ban-2019-22gqm_f734976610d24532b33df1af77bd0736_grande.png", "German", "Doraemon", 3.0, "Shogakukan", 30, 5 },
                    { 38, "Stephenie Meyer", new DateTime(2016, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "About three things I was absolutely positive.\r\nFirst, Edward was a vampire.\r\nSecond, there was a part of him—and I didn't know how dominant that part might be—that thirsted for my blood.\r\n\r\nAnd third, I was unconditionally and irrevocably in love with him.\r\nDeeply seductive and extraordinarily suspenseful, Twilight is a love story with bite.\r\n", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1361039443l/41865.jpg", "German", "Twilight", 15.0, "Little, Brown and Company", 30, 3 },
                    { 25, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "To protect his ward Ciri, Geralt of Rivia sends her to train with the sorceress Yennefer. But all is not well within the Wizard’s Guild in the second novel of the Witcher, Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt is a Witcher: guardian of the innocent; protector of those in need; a defender in dark times against some of the most frightening creatures of myth and legend.\r\nHis task now is to protect Ciri. A child of prophecy, she will have the power to change the world for good or for ill—but only if she lives to use it.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452762.jpg?fit=450%2C673", "German", "The Time of Contempt", 17.989999999999998, "Orbit", 30, 1 },
                    { 23, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrzej Sapkowski’s New York Times bestselling Witcher series has inspired the hit Netflix show and multiple blockbuster video games, and has transported millions of fans around the globe to an epic, unforgettable world of magic and adventure.\r\n\r\nFor over a century, humans, dwarves, gnomes, and elves have lived together in relative peace. But that peace has now come to an end.\r\n\r\nGeralt of Rivia, the hunter known as the Witcher, has been waiting for the birth of a prophesied child. The one who has the power to change the world for good—or for evil.\r\n\r\nAs the threat of war hangs over the land and the child is pursued for her extraordinary powers, it will become Geralt’s responsibility to protect them all. And the Witcher never accepts defeat.\r\n\r\nJoin Geralt of Rivia; his beloved ward and the child of prophecy, Ciri; and his ally and love, the powerful sorceress Yennefer as they battle monsters, demons, and prejudices alike in Blood of Elves, the first novel of The Witcher Saga.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/05/9780316452663-1.jpg?fit=450%2C675", "German", "Blood of Elves", 17.989999999999998, "Orbit", 30, 1 },
                    { 49, "Toriyama Akira", new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contrasting with the Chinese novel Journey to the West, the series depicts Son Goku's journey from childhood to adulthood, through his quests to learn martial arts and explore the world in search of the Dragon Balls. Wish from the sacred dragon. Throughout Son Goku's journey, he met many friends and fought off villains who plotted to use wishes from the sacred dragon to rule the world.", "https://product.hstatic.net/200000122283/product/1__50__wnkv-94_d160e68f191d47af90a92978c8bff32d_master.png", "German", "Dragon Ball", 3.0, "Shueisha", 30, 5 },
                    { 1, "Frank Herbert", new DateTime(1965, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SOON TO BE A MAJOR MOTION PICTURE directed by Denis Villeneuve, starring Timothée Chalamet, Josh Brolin, Jason Momoa, Oscar Isaac, Javier Bardem, Dave Bautista, Stellan Skarsgård, Rebecca Ferguson, Zendaya, and Charlotte Rampling.\r\n\r\nFrank Herbert’s classic masterpiece—a triumph of the imagination and one of the bestselling science fiction novels of all time.\r\n\r\nSet on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the “spice” melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for....\r\n\r\nWhen House Atreides is betrayed, the destruction of Paul’s family will set the boy on a journey toward a destiny greater than he could ever have imagined. And as he evolves into the mysterious man known as Muad’Dib, he will bring to fruition humankind’s most ancient and unattainable dream.\r\n\r\nA stunning blend of adventure and mysticism, environmentalism and politics, Dune won the first Nebula Award, shared the Hugo Award, and formed the basis of what is undoubtedly the grandest epic in science fiction.\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/Dune-Cover-1.jpg", "German", "Dune", 10.99, "Ace Books", 30, 1 },
                    { 2, "Frank Herbert", new DateTime(1969, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book Two in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nDune Messiah continues the story of Paul Atreides, better known—and feared—as the man christened Muad’Dib. As Emperor of the known universe, he possesses more power than a single man was ever meant to wield. Worshipped as a religious icon by the fanatical Fremen, Paul faces the enmity of the political houses he displaced when he assumed the throne—and a conspiracy conducted within his own sphere of influence.\r\n\r\nAnd even as House Atreides begins to crumble around him from the machinations of his enemies, the true threat to Paul comes to his lover, Chani, and the unborn heir to his family’s dynasty...\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/Dune-Messiah-Cover.jpg", "German", "Dune Messiah", 18.0, "Ace Books", 30, 1 },
                    { 3, "Frank Herbert", new DateTime(1976, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book Three in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nThe Children of Dune are twin siblings Leto and Ghanima Atreides, whose father, the Emperor Paul Muad’Dib, disappeared in the desert wastelands of Arrakis nine years ago. Like their father, the twins possess supernormal abilities—making them valuable to their manipulative aunt Alia, who rules the Empire in the name of House Atreides.\r\n\r\nFacing treason and rebellion on two fronts, Alia’s rule is not absolute. The displaced House Corrino is plotting to regain the throne while the fanatical Fremen are being provoked into open revolt by the enigmatic figure known only as The Preacher. Alia believes that by obtaining the secrets of the twins’ prophetic visions, she can maintain control over her dynasty.\r\n\r\nBut Leto and Ghanima have their own plans for their visions—and their destinies....\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/Children-of-Dune-Cover.jpg", "German", "Children of Dune", 18.0, "Ace Books", 30, 1 },
                    { 4, "Frank Herbert", new DateTime(1981, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book Four in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nMillennia have passed on Arrakis, and the once-desert planet is green with life. Leto Atreides, the son of the world’s savior, the Emperor Paul Muad’Dib, is still alive but far from human. To preserve humanity’s future, he sacrificed his own by merging with a sandworm, granting him near immortality as God Emperor of Dune for the past thirty-five hundred years.\r\n\r\nLeto’s rule is not a benevolent one. His transformation has made not only his appearance but his morality inhuman. A rebellion, led by Siona, a member of the Atreides family, has risen to oppose the despot’s rule. But Siona is unaware that Leto’s vision of a Golden Path for humanity requires her to fulfill a destiny she never wanted—or could possibly conceive....\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/God-Emperor-of-Dune.jpg", "German", "God Emperor of Dune", 18.0, "Ace Books", 30, 1 },
                    { 5, "Frank Herbert", new DateTime(1984, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book Five in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nLeto Atreides, the God Emperor of Dune, is dead. In the fifteen hundred years since his passing, the Empire has fallen into ruin. The great Scattering saw millions abandon the crumbling civilization and spread out beyond the reaches of known space. The planet Arrakis—now called Rakis—has reverted to its desert climate, and its great sandworms are dying.\r\n\r\nNow the Lost Ones are returning home in pursuit of power. And as these factions vie for control over the remnants of the Empire, a girl named Sheeana rises to prominence in the wastelands of Rakis, sending religious fervor throughout the galaxy. For she possesses the abilities of the Fremen sandriders—fulfilling a prophecy foretold by the late God Emperor....\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/Heretics-of-Dune-Cover.jpg", "German", "Heretics of Dune", 18.0, "Ace Books", 30, 1 },
                    { 6, "Frank Herbert", new DateTime(1985, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank Herbert's Final Novel in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nThe desert planet Arrakis, called Dune, has been destroyed. The remnants of the Old Empire have been consumed by the violent matriarchal cult known as the Honored Matres. Only one faction remains a viable threat to their total conquest—the Bene Gesserit, heirs to Dune’s power.\r\n\r\nUnder the leadership of Mother Superior Darwi Odrade, the Bene Gesserit have colonized a green world on the planet Chapterhouse and are turning it into a desert, mile by scorched mile. And once they’ve mastered breeding sandworms, the Sisterhood will control the production of the greatest commodity in the known galaxy—the spice melange. But their true weapon remains a man who has lived countless lifetimes—a man who served under the God Emperor Paul Muad’Dib....\r\n", "https://dunenovels.com/wp-content/uploads/2020/11/Chapterhouse-Dune-Cover.jpg", "German", "Chapterhouse: Dune", 18.0, "Ace Books", 30, 1 },
                    { 7, "Ian Fleming", new DateTime(1953, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'Surround yourself with human being, my dear James. They are easier to fight for than principles'\r\nIn Casino Royale, the first of Fleming's 007 adventures, a game of cards is James Bond's only chance to bring down the desperate SMERSH agent Le Chiffre. But Bond soon discovers that there is far more at stake than money.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/Casino_Royale_book_eef6989e-a77c-430c-9589-864b97146621_2048x.jpg?v=1633296784", "German", "Casino Royale", 12.0, "Penguin Books", 30, 1 },
                    { 8, "Ian Fleming", new DateTime(1954, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'You start to die the moment you are born'.\r\n\r\nLive and Let Die, Ian Fleming's second 007 novel, takes Bond from Harlem to Jamaica in a frenzied hunt for the brilliant deadly gangster Mr Big and his macabre network of associates.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/live_and_let_die_9624ced7-dcf5-493d-9a9d-6bee05a97a64_2048x.jpg?v=1633299044", "German", "Live and Let Die", 12.0, "Penguin Books", 30, 1 },
                    { 9, "Ian Fleming", new DateTime(1955, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'For several minutes he stood speechless, his eyes dazzled by the terrible beauty of the greatest weapon on earth.'\r\n\r\nHe's a self-made millionaire, head of the Moonraker rocket programme and loved by the press. So why is Sir Hugo Drax cheating at cards?\r\n\r\nBond has just five days to uncover the sinister truth behind a national hero, in Ian Fleming's third 007 adventure.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/moonraker_54bf89b4-c3e6-4ddd-b90b-8faf024a4d12_2048x.jpg?v=1633294922", "German", "Moonraker", 12.0, "Penguin Books", 30, 1 },
                    { 10, "Ian Fleming", new DateTime(1956, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'The twentieth century looked out at him from the piece of newsprint and bared its teeth in a sneer'\r\n\r\nFrom the diamond mines of Sierra Leone to the jewellers of Hatton Garden, from race track to casino...Bond must infiltrate and destroy the criminal network of the Spangled Mob in Fleming's fourth 007 adventure.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/diamonds_are_forever_8d7f0e8d-4fd5-442a-b47a-b87691abd1e6_2048x.jpg?v=1633298088", "German", "Diamonds Are Forever", 12.0, "Penguin Books", 30, 1 },
                    { 24, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrzej Sapkowski’s New York Times bestselling Witcher series has inspired the hit Netflix show and multiple blockbuster video games, and has transported millions of fans around the globe to an epic, unforgettable world of magic and adventure.\r\n\r\nFor over a century, humans, dwarves, gnomes, and elves have lived together in relative peace. But that peace has now come to an end.\r\n\r\nGeralt of Rivia, the hunter known as the Witcher, has been waiting for the birth of a prophesied child. The one who has the power to change the world for good—or for evil.\r\n\r\nAs the threat of war hangs over the land and the child is pursued for her extraordinary powers, it will become Geralt’s responsibility to protect them all. And the Witcher never accepts defeat.\r\n\r\nJoin Geralt of Rivia; his beloved ward and the child of prophecy, Ciri; and his ally and love, the powerful sorceress Yennefer as they battle monsters, demons, and prejudices alike in Blood of Elves, the first novel of The Witcher Saga.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/05/9780316452663-1.jpg?fit=450%2C675", "German", "Blood of Elves", 17.989999999999998, "Orbit", 30, 1 },
                    { 11, "Ian Fleming", new DateTime(1957, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'We are here to find a target who will fulfil our requirements. Someone who is admired and whose ignominious destruction would cause dismay'\r\n\r\nA beautiful Soviet spy. A brand-new Spektor cipher machine. Smersh has set an irresistible trap that threatens the entire Secret Service.\r\n\r\nIn Fleming's fifth 007 novel Bond finds himself enmeshed in a deadly game of cross and double cross.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/from_russia_with_love_b0b3041b-22d8-485d-b2c6-5075c3b5fabb_2048x.jpg?v=1633295094", "German", "From Russia, with Love", 11.0, "Penguin Books", 30, 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Book_author", "Book_date", "Book_description", "Book_image", "Book_language", "Book_name", "Book_price", "Book_publisher", "Book_quantity", "GenreId" },
                values: new object[,]
                {
                    { 13, "Ian Fleming", new DateTime(1959, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'You're stale, tired of having to be tough. You want a change. You've seen too much death'.\r\n\r\nIn Fleming's seventh 007 novel, a private assignment sets Bond on the trail of an enigmatic criminal mastermind - Auric Goldfinger. But greed and power have created a deadly opponent who will stop at nothing to get what he wants.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/gold_finger_02_2048x.jpg?v=1633298310", "German", "Goldfinger", 12.0, "Penguin Books", 30, 1 },
                    { 14, "Ian Fleming", new DateTime(1960, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "From a View to A Kill. For Your Eyes Only. Quantum of Solace. Risico. The Hildebrand Rarity.\r\n\r\n'Private armies, private wars. How much energy they siphoned off from the common cause, how much fire they directed away from the common enemy!'\r\n\r\nFive stories. Five missions. Five glimpses into the mind of a spy. From Jamaican estates to brooding French forests, Bond is tested to his limits by the world's most dangerous men and the dark secrets they keep.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/for_your_eyes_only_0f0a6fa4-d365-4902-87a4-d4cf8a167505_2048x.jpg?v=1633295180", "German", "For Your Eyes Only", 12.0, "Penguin Books", 30, 1 },
                    { 15, "Ian Fleming", new DateTime(1961, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'He was one of those men - one meets perhaps only two or three in a lifetime - who seem almost to suck the eyes out of your head. He was their Supreme Commander - almost their god'\r\n\r\nSpectre is a merciless new enemy - a group of the world's toughest criminals, headed by the brilliant Ernst Stavro Blofeld.\r\n\r\nWhen two NATO atom bombs go missing, Bond must unravel Spectre's intricate plans and prevent a global catastrophe, in Fleming's ninth 007 adventure.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/thunderball_db9ac272-acdb-4061-8458-ec14ec09f0b2_2048x.jpg?v=1633295006", "German", "Thunderball", 12.0, "Penguin Books", 30, 1 },
                    { 16, "Ian Fleming", new DateTime(1962, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'You take a wrong step, play the wrong card in Fate's game, and you're lost in a world you had never imagined, against which you have no weapons. No compass.'\r\n\r\nVivienne Michel is running away - from pain, from rejection, from humiliation. When she stumbles into a criminal plot, her life seems over...until a chance encounter with James Bond turns her world upside down.\r\n\r\nIan Fleming's tenth 007 novel is a unique view of Bond, through the eyes of a woman who loves him.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/the_spy_who_loved_me_baaeca59-cd8e-4280-b57b-258e1973f620_2048x.jpg?v=1633297129", "German", "The Spy Who Loved Me", 12.0, "Penguin Books", 30, 1 },
                    { 17, "Ian Fleming", new DateTime(1963, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'He was a man with years of dirty, dangerous memories - a spy.'\r\n\r\nJames Bond has had enough. Enough of Service life, of fruitless manhunts, of taking orders. But Blofeld is back - older, leaner and more dangerous than ever, with a deadly secret at the heart of his luxury ski resort.\r\n\r\nBond must rediscover his passion for what he does best, in Fleming's eleventh 007 novel.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/on_her_majestys_secret_service_2048x.jpg?v=1633296765", "German", "On Her Majesty’s Secret Service", 12.0, "Penguin Books", 30, 1 },
                    { 18, "Ian Fleming", new DateTime(1964, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'You only live twice: Once when you are born And once when you look death in the face'\r\n\r\nDoctor Guntram Shatterhand's \"Garden of Death\" is a magnet for suicides from all over Japan. James Bond - grief-stricken and erratic - must kill him to save his career in the Service.\r\n\r\nBut as Shatterhand's true identity is revealed, Bond is forced to confront his past, in Ian Fleming's twelfth 007 adventure.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/you_only_live_twice_2048x.jpg?v=1633297266", "German", "You Only Live Twice", 12.0, "Penguin Books", 30, 1 },
                    { 19, "Ian Fleming", new DateTime(1965, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'Mister, there's something quite extra about the smell of death. Care to try it?'\r\n\r\nAfter a year missing in action, Bond is back ...brainwashed by the KGB and on a mission to assassinate M. To prove his worth to the Service, he must hunt down and eliminate his fiercest opponent yet: \"Pistols\" Scaramanga - \"The Man With The Golden Gun\".\r\n\r\nIan Fleming's final \"007\" novel is a fitting tribute to a unique British hero.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/golden_gun_2048x.jpg?v=1633295166", "German", "The Man with the Golden Gun", 12.0, "Penguin Books", 30, 1 },
                    { 20, "Ian Fleming", new DateTime(1966, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Octopussy. The Property of a Lady. The Living Daylights. 007 in New York.\r\n\r\n'This was going to be bad news, dirty work. This was to be murder'.\r\n\r\nFour classic moments in the life of a spy. From avenging the wartime murder of a friend to sniper duty on the East-West Berlin border, James Bond's body, mind and spirit are tested to their limits.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/octopussy_37c61b2d-d25a-4a05-9fd0-a326655e4da8_2048x.jpg?v=1633296903", "German", "Octopussy and The Living Daylights", 12.0, "Penguin Books", 30, 1 },
                    { 21, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geralt the Witcher—revered and hated—holds the line against the monsters plaguing humanity in this collection of adventures, the first chapter in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt is a Witcher, a man whose magic powers, enhanced by long training and a mysterious elixir, have made him a brilliant fighter and a merciless hunter. Yet he is no ordinary killer. His sole purpose: to destroy the monsters that plague the world.\r\nBut not everything monstrous-looking is evil and not everything fair is good . . . and in every fairy tale there is a grain of truth.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452465.jpg?fit=450%2C672", "German", "The Last Wish", 17.989999999999998, "Orbit", 30, 1 },
                    { 22, "Andrzej  Sapkowski", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geralt the Witcher battles monsters, demons and prejudices alike in Sword of Destiny, the second collection of adventures in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the Netflix show and the hit video games.\r\nGeralt is a Witcher, a man whose magic powers, enhanced by long training and a mysterious elixir, have made him a brilliant fighter and a merciless hunter. Yet he is no ordinary killer: his targets are the multifarious monsters and vile fiends that ravage the land and attack the innocent.\r\nSword of Destiny is the follow up to The Last Wish, and together they are the perfect introduction to a one of a kind fantasy world.\r\n", "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452564.jpg?fit=450%2C675", "German", "Sword of Destiny", 17.989999999999998, "Orbit", 30, 1 },
                    { 12, "Ian Fleming", new DateTime(1958, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "'The first shot had been fired. There would be others. And whose finger was on the trigger? Who had got him so accurately in their sights?'\r\n\r\nCrab Key island is desolate and remote. So why is Dr No defending it so ruthlessly?\r\n\r\nOnly Bond can uncover the truth, in Fleming's sixth 007 adventure.\r\n", "https://cdn.shopify.com/s/files/1/1644/6687/products/dr_no_1e4779e6-be70-4b24-ad27-810f36c7bb0b_2048x.jpg?v=1633297178", "German", "Dr.No", 12.0, "Penguin Books", 30, 1 },
                    { 50, "Tadatoshi Fujimaki", new DateTime(2014, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It tells the story of a high school basketball team trying to make it to the national tournament.", "https://cf.shopee.vn/file/7391c83f1cd160abd380773f89b2cbbb", "German", "Kuroko's Basketball", 5.0, "Shueisha", 30, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GenreRequests");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
