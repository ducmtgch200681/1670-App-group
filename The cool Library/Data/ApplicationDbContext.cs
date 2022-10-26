using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using The_cool_Library.Models;

namespace The_cool_Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityUser> IUs { get; set; }

        //public DbSet<Admin> Admins { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<StoreOwner> StoreOwners { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreRequest> GenreRequests { get; set; }
        public DbSet<Order> Orders { get; set; }
       
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Bonus form
            //Note: add dữ liệu cho bảng chứa PK trước (University)
            //rồi add dữ liệu cho bảng chứa FK sau (Student)

            //add dữ liệu khởi tạo cho bảng University
            //PopulateUniversity(builder);

            //add dữ liệu khởi tạo (initial data) cho bảng Student
            //SeedStudent(builder);
            //----------------------------------------------------

            //add dữ liệu cho bảng IdentityUser
            SeedUser(builder);

            //add dữ liệu cho bảng Role
            SeedRole(builder);

            //add dữ liệu cho bảng UserRole
            SeedUserRole(builder);

            //add genres
            SeedGerne(builder);

            //add books
            SeedBook(builder);
        }

        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com",
                EmailConfirmed = true
            };

            var storeOwner = new IdentityUser
            {
                Id = "2",
                UserName = "storeowner@fpt.com",
                Email = "storeowner@fpt.com",
                NormalizedUserName = "storeowner@fpt.com",
                EmailConfirmed = true
            };

            var customer = new IdentityUser
            {
                Id = "3",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com",
                EmailConfirmed = true
            };         

            var customer2 = new IdentityUser
            {
                Id = "4",
                UserName = "Cus2",
                Email = "cus2@fpt.com",
                NormalizedUserName = "cus2@fpt.com",
                EmailConfirmed = true
            };

            //Khai báo thư viện để mã hóa mk
            var hashed = new PasswordHasher<IdentityUser>();

            //Thiết lập để mã hóa từng tài khoản
            admin.PasswordHash = hashed.HashPassword(admin, "12345");
            storeOwner.PasswordHash = hashed.HashPassword(storeOwner, "12345");
            customer.PasswordHash = hashed.HashPassword(customer, "12345");
            customer2.PasswordHash = hashed.HashPassword(customer2, "12345");


            //Add tài khoản vào DB
            builder.Entity<IdentityUser>().HasData(admin, storeOwner, customer, customer2);
        }

        //Add Role
        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };

            var storeOwner = new IdentityRole
            {
                Id = "B",
                Name = "StoreOwner",
                NormalizedName = "StoreOwner"
            };

            var customer = new IdentityRole
            {
                Id = "C",
                Name = "Customer",
                NormalizedName = "Customer"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, storeOwner, customer);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "C"
                },
                new IdentityUserRole<string>
                {
                    UserId = "4",
                    RoleId = "C"
                }
             );
        }

        private void SeedGerne(ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Genre_name = "Fiction Novel"
                },
                new Genre
                {
                    Id = 2,
                    Genre_name = "Literary Book"
                },
                new Genre
                {
                    Id = 3,
                    Genre_name = "Romance Novel"
                },
                new Genre
                {
                    Id = 4,
                    Genre_name = "Detective Book"
                },
                new Genre
                {
                    Id = 5,
                    Genre_name = "Comic"
                }
            );
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                //bắt buộc phải nhập giá trị cho cột Id (PK)
                //những thuộc tính set là "Required" ở trong file Model thì bắt buộc phải nhập
                //còn lại không bắt buộc. Thứ tự khai báo các thuộc tính không quan trọng
                new Book
                {
                    Id = 1, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Dune",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1965-08-25"),
                    Book_price = 10.99,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/Dune-Cover-1.jpg",
                    Book_description = "SOON TO BE A MAJOR MOTION PICTURE directed by Denis Villeneuve, starring Timothée Chalamet, Josh Brolin, Jason Momoa, Oscar Isaac, Javier Bardem, Dave Bautista, Stellan Skarsgård, Rebecca Ferguson, Zendaya, and Charlotte Rampling.\r\n\r\nFrank Herbert’s classic masterpiece—a triumph of the imagination and one of the bestselling science fiction novels of all time.\r\n\r\nSet on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the “spice” melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for....\r\n\r\nWhen House Atreides is betrayed, the destruction of Paul’s family will set the boy on a journey toward a destiny greater than he could ever have imagined. And as he evolves into the mysterious man known as Muad’Dib, he will bring to fruition humankind’s most ancient and unattainable dream.\r\n\r\nA stunning blend of adventure and mysticism, environmentalism and politics, Dune won the first Nebula Award, shared the Hugo Award, and formed the basis of what is undoubtedly the grandest epic in science fiction.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 2, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Dune Messiah",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1969-08-25"),
                    Book_price = 18.00,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/Dune-Messiah-Cover.jpg",
                    Book_description = "Book Two in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nDune Messiah continues the story of Paul Atreides, better known—and feared—as the man christened Muad’Dib. As Emperor of the known universe, he possesses more power than a single man was ever meant to wield. Worshipped as a religious icon by the fanatical Fremen, Paul faces the enmity of the political houses he displaced when he assumed the throne—and a conspiracy conducted within his own sphere of influence.\r\n\r\nAnd even as House Atreides begins to crumble around him from the machinations of his enemies, the true threat to Paul comes to his lover, Chani, and the unborn heir to his family’s dynasty...\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 3, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Children of Dune",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1976-08-25"),
                    Book_price = 18.00,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/Children-of-Dune-Cover.jpg",
                    Book_description = "Book Three in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nThe Children of Dune are twin siblings Leto and Ghanima Atreides, whose father, the Emperor Paul Muad’Dib, disappeared in the desert wastelands of Arrakis nine years ago. Like their father, the twins possess supernormal abilities—making them valuable to their manipulative aunt Alia, who rules the Empire in the name of House Atreides.\r\n\r\nFacing treason and rebellion on two fronts, Alia’s rule is not absolute. The displaced House Corrino is plotting to regain the throne while the fanatical Fremen are being provoked into open revolt by the enigmatic figure known only as The Preacher. Alia believes that by obtaining the secrets of the twins’ prophetic visions, she can maintain control over her dynasty.\r\n\r\nBut Leto and Ghanima have their own plans for their visions—and their destinies....\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 4, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "God Emperor of Dune",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1981-08-25"),
                    Book_price = 18.00,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/God-Emperor-of-Dune.jpg",
                    Book_description = "Book Four in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nMillennia have passed on Arrakis, and the once-desert planet is green with life. Leto Atreides, the son of the world’s savior, the Emperor Paul Muad’Dib, is still alive but far from human. To preserve humanity’s future, he sacrificed his own by merging with a sandworm, granting him near immortality as God Emperor of Dune for the past thirty-five hundred years.\r\n\r\nLeto’s rule is not a benevolent one. His transformation has made not only his appearance but his morality inhuman. A rebellion, led by Siona, a member of the Atreides family, has risen to oppose the despot’s rule. But Siona is unaware that Leto’s vision of a Golden Path for humanity requires her to fulfill a destiny she never wanted—or could possibly conceive....\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 5, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Heretics of Dune",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1984-08-25"),
                    Book_price = 18.00,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/Heretics-of-Dune-Cover.jpg",
                    Book_description = "Book Five in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nLeto Atreides, the God Emperor of Dune, is dead. In the fifteen hundred years since his passing, the Empire has fallen into ruin. The great Scattering saw millions abandon the crumbling civilization and spread out beyond the reaches of known space. The planet Arrakis—now called Rakis—has reverted to its desert climate, and its great sandworms are dying.\r\n\r\nNow the Lost Ones are returning home in pursuit of power. And as these factions vie for control over the remnants of the Empire, a girl named Sheeana rises to prominence in the wastelands of Rakis, sending religious fervor throughout the galaxy. For she possesses the abilities of the Fremen sandriders—fulfilling a prophecy foretold by the late God Emperor....\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 6, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Chapterhouse: Dune",
                    Book_author = "Frank Herbert",
                    Book_publisher = "Ace Books",
                    Book_date = DateTime.Parse("1985-08-25"),
                    Book_price = 18.00,
                    Book_image = "https://dunenovels.com/wp-content/uploads/2020/11/Chapterhouse-Dune-Cover.jpg",
                    Book_description = "Frank Herbert's Final Novel in the Magnificent Dune Chronicles—the Bestselling Science Fiction Adventure of All Time\r\n\r\nThe desert planet Arrakis, called Dune, has been destroyed. The remnants of the Old Empire have been consumed by the violent matriarchal cult known as the Honored Matres. Only one faction remains a viable threat to their total conquest—the Bene Gesserit, heirs to Dune’s power.\r\n\r\nUnder the leadership of Mother Superior Darwi Odrade, the Bene Gesserit have colonized a green world on the planet Chapterhouse and are turning it into a desert, mile by scorched mile. And once they’ve mastered breeding sandworms, the Sisterhood will control the production of the greatest commodity in the known galaxy—the spice melange. But their true weapon remains a man who has lived countless lifetimes—a man who served under the God Emperor Paul Muad’Dib....\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 7, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Casino Royale",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1953-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/Casino_Royale_book_eef6989e-a77c-430c-9589-864b97146621_2048x.jpg?v=1633296784",
                    Book_description = "'Surround yourself with human being, my dear James. They are easier to fight for than principles'\r\nIn Casino Royale, the first of Fleming's 007 adventures, a game of cards is James Bond's only chance to bring down the desperate SMERSH agent Le Chiffre. But Bond soon discovers that there is far more at stake than money.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 8, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Live and Let Die",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1954-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/live_and_let_die_9624ced7-dcf5-493d-9a9d-6bee05a97a64_2048x.jpg?v=1633299044",
                    Book_description = "'You start to die the moment you are born'.\r\n\r\nLive and Let Die, Ian Fleming's second 007 novel, takes Bond from Harlem to Jamaica in a frenzied hunt for the brilliant deadly gangster Mr Big and his macabre network of associates.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 9, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Moonraker",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1955-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/moonraker_54bf89b4-c3e6-4ddd-b90b-8faf024a4d12_2048x.jpg?v=1633294922",
                    Book_description = "'For several minutes he stood speechless, his eyes dazzled by the terrible beauty of the greatest weapon on earth.'\r\n\r\nHe's a self-made millionaire, head of the Moonraker rocket programme and loved by the press. So why is Sir Hugo Drax cheating at cards?\r\n\r\nBond has just five days to uncover the sinister truth behind a national hero, in Ian Fleming's third 007 adventure.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 10, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Diamonds Are Forever",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1956-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/diamonds_are_forever_8d7f0e8d-4fd5-442a-b47a-b87691abd1e6_2048x.jpg?v=1633298088",
                    Book_description = "'The twentieth century looked out at him from the piece of newsprint and bared its teeth in a sneer'\r\n\r\nFrom the diamond mines of Sierra Leone to the jewellers of Hatton Garden, from race track to casino...Bond must infiltrate and destroy the criminal network of the Spangled Mob in Fleming's fourth 007 adventure.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 11, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "From Russia, with Love",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1957-08-25"),
                    Book_price = 11.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/from_russia_with_love_b0b3041b-22d8-485d-b2c6-5075c3b5fabb_2048x.jpg?v=1633295094",
                    Book_description = "'We are here to find a target who will fulfil our requirements. Someone who is admired and whose ignominious destruction would cause dismay'\r\n\r\nA beautiful Soviet spy. A brand-new Spektor cipher machine. Smersh has set an irresistible trap that threatens the entire Secret Service.\r\n\r\nIn Fleming's fifth 007 novel Bond finds himself enmeshed in a deadly game of cross and double cross.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 12, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Dr.No",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1958-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/dr_no_1e4779e6-be70-4b24-ad27-810f36c7bb0b_2048x.jpg?v=1633297178",
                    Book_description = "'The first shot had been fired. There would be others. And whose finger was on the trigger? Who had got him so accurately in their sights?'\r\n\r\nCrab Key island is desolate and remote. So why is Dr No defending it so ruthlessly?\r\n\r\nOnly Bond can uncover the truth, in Fleming's sixth 007 adventure.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 13, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Goldfinger",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1959-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/gold_finger_02_2048x.jpg?v=1633298310",
                    Book_description = "'You're stale, tired of having to be tough. You want a change. You've seen too much death'.\r\n\r\nIn Fleming's seventh 007 novel, a private assignment sets Bond on the trail of an enigmatic criminal mastermind - Auric Goldfinger. But greed and power have created a deadly opponent who will stop at nothing to get what he wants.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 14, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "For Your Eyes Only",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1960-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/for_your_eyes_only_0f0a6fa4-d365-4902-87a4-d4cf8a167505_2048x.jpg?v=1633295180",
                    Book_description = "From a View to A Kill. For Your Eyes Only. Quantum of Solace. Risico. The Hildebrand Rarity.\r\n\r\n'Private armies, private wars. How much energy they siphoned off from the common cause, how much fire they directed away from the common enemy!'\r\n\r\nFive stories. Five missions. Five glimpses into the mind of a spy. From Jamaican estates to brooding French forests, Bond is tested to his limits by the world's most dangerous men and the dark secrets they keep.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 15, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Thunderball",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1961-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/thunderball_db9ac272-acdb-4061-8458-ec14ec09f0b2_2048x.jpg?v=1633295006",
                    Book_description = "'He was one of those men - one meets perhaps only two or three in a lifetime - who seem almost to suck the eyes out of your head. He was their Supreme Commander - almost their god'\r\n\r\nSpectre is a merciless new enemy - a group of the world's toughest criminals, headed by the brilliant Ernst Stavro Blofeld.\r\n\r\nWhen two NATO atom bombs go missing, Bond must unravel Spectre's intricate plans and prevent a global catastrophe, in Fleming's ninth 007 adventure.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 16, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Spy Who Loved Me",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1962-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/the_spy_who_loved_me_baaeca59-cd8e-4280-b57b-258e1973f620_2048x.jpg?v=1633297129",
                    Book_description = "'You take a wrong step, play the wrong card in Fate's game, and you're lost in a world you had never imagined, against which you have no weapons. No compass.'\r\n\r\nVivienne Michel is running away - from pain, from rejection, from humiliation. When she stumbles into a criminal plot, her life seems over...until a chance encounter with James Bond turns her world upside down.\r\n\r\nIan Fleming's tenth 007 novel is a unique view of Bond, through the eyes of a woman who loves him.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 17, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "On Her Majesty’s Secret Service",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1963-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/on_her_majestys_secret_service_2048x.jpg?v=1633296765",
                    Book_description = "'He was a man with years of dirty, dangerous memories - a spy.'\r\n\r\nJames Bond has had enough. Enough of Service life, of fruitless manhunts, of taking orders. But Blofeld is back - older, leaner and more dangerous than ever, with a deadly secret at the heart of his luxury ski resort.\r\n\r\nBond must rediscover his passion for what he does best, in Fleming's eleventh 007 novel.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 18, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "You Only Live Twice",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1964-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/you_only_live_twice_2048x.jpg?v=1633297266",
                    Book_description = "'You only live twice: Once when you are born And once when you look death in the face'\r\n\r\nDoctor Guntram Shatterhand's \"Garden of Death\" is a magnet for suicides from all over Japan. James Bond - grief-stricken and erratic - must kill him to save his career in the Service.\r\n\r\nBut as Shatterhand's true identity is revealed, Bond is forced to confront his past, in Ian Fleming's twelfth 007 adventure.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 19, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Man with the Golden Gun",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1965-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/golden_gun_2048x.jpg?v=1633295166",
                    Book_description = "'Mister, there's something quite extra about the smell of death. Care to try it?'\r\n\r\nAfter a year missing in action, Bond is back ...brainwashed by the KGB and on a mission to assassinate M. To prove his worth to the Service, he must hunt down and eliminate his fiercest opponent yet: \"Pistols\" Scaramanga - \"The Man With The Golden Gun\".\r\n\r\nIan Fleming's final \"007\" novel is a fitting tribute to a unique British hero.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 20, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Octopussy and The Living Daylights",
                    Book_author = "Ian Fleming",
                    Book_publisher = "Penguin Books",
                    Book_date = DateTime.Parse("1966-08-25"),
                    Book_price = 12.00,
                    Book_image = "https://cdn.shopify.com/s/files/1/1644/6687/products/octopussy_37c61b2d-d25a-4a05-9fd0-a326655e4da8_2048x.jpg?v=1633296903",
                    Book_description = "Octopussy. The Property of a Lady. The Living Daylights. 007 in New York.\r\n\r\n'This was going to be bad news, dirty work. This was to be murder'.\r\n\r\nFour classic moments in the life of a spy. From avenging the wartime murder of a friend to sniper duty on the East-West Berlin border, James Bond's body, mind and spirit are tested to their limits.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 21, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Last Wish",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452465.jpg?fit=450%2C672",
                    Book_description = "Geralt the Witcher—revered and hated—holds the line against the monsters plaguing humanity in this collection of adventures, the first chapter in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt is a Witcher, a man whose magic powers, enhanced by long training and a mysterious elixir, have made him a brilliant fighter and a merciless hunter. Yet he is no ordinary killer. His sole purpose: to destroy the monsters that plague the world.\r\nBut not everything monstrous-looking is evil and not everything fair is good . . . and in every fairy tale there is a grain of truth.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 22, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Sword of Destiny",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452564.jpg?fit=450%2C675",
                    Book_description = "Geralt the Witcher battles monsters, demons and prejudices alike in Sword of Destiny, the second collection of adventures in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the Netflix show and the hit video games.\r\nGeralt is a Witcher, a man whose magic powers, enhanced by long training and a mysterious elixir, have made him a brilliant fighter and a merciless hunter. Yet he is no ordinary killer: his targets are the multifarious monsters and vile fiends that ravage the land and attack the innocent.\r\nSword of Destiny is the follow up to The Last Wish, and together they are the perfect introduction to a one of a kind fantasy world.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 23, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Blood of Elves",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/05/9780316452663-1.jpg?fit=450%2C675",
                    Book_description = "Andrzej Sapkowski’s New York Times bestselling Witcher series has inspired the hit Netflix show and multiple blockbuster video games, and has transported millions of fans around the globe to an epic, unforgettable world of magic and adventure.\r\n\r\nFor over a century, humans, dwarves, gnomes, and elves have lived together in relative peace. But that peace has now come to an end.\r\n\r\nGeralt of Rivia, the hunter known as the Witcher, has been waiting for the birth of a prophesied child. The one who has the power to change the world for good—or for evil.\r\n\r\nAs the threat of war hangs over the land and the child is pursued for her extraordinary powers, it will become Geralt’s responsibility to protect them all. And the Witcher never accepts defeat.\r\n\r\nJoin Geralt of Rivia; his beloved ward and the child of prophecy, Ciri; and his ally and love, the powerful sorceress Yennefer as they battle monsters, demons, and prejudices alike in Blood of Elves, the first novel of The Witcher Saga.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 24, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Blood of Elves",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/05/9780316452663-1.jpg?fit=450%2C675",
                    Book_description = "Andrzej Sapkowski’s New York Times bestselling Witcher series has inspired the hit Netflix show and multiple blockbuster video games, and has transported millions of fans around the globe to an epic, unforgettable world of magic and adventure.\r\n\r\nFor over a century, humans, dwarves, gnomes, and elves have lived together in relative peace. But that peace has now come to an end.\r\n\r\nGeralt of Rivia, the hunter known as the Witcher, has been waiting for the birth of a prophesied child. The one who has the power to change the world for good—or for evil.\r\n\r\nAs the threat of war hangs over the land and the child is pursued for her extraordinary powers, it will become Geralt’s responsibility to protect them all. And the Witcher never accepts defeat.\r\n\r\nJoin Geralt of Rivia; his beloved ward and the child of prophecy, Ciri; and his ally and love, the powerful sorceress Yennefer as they battle monsters, demons, and prejudices alike in Blood of Elves, the first novel of The Witcher Saga.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 25, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Time of Contempt",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452762.jpg?fit=450%2C673",
                    Book_description = "To protect his ward Ciri, Geralt of Rivia sends her to train with the sorceress Yennefer. But all is not well within the Wizard’s Guild in the second novel of the Witcher, Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt is a Witcher: guardian of the innocent; protector of those in need; a defender in dark times against some of the most frightening creatures of myth and legend.\r\nHis task now is to protect Ciri. A child of prophecy, she will have the power to change the world for good or for ill—but only if she lives to use it.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 26, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Baptism of Fire",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452861.jpg?fit=450%2C675",
                    Book_description = "A deadly coup within the Wizard’s Guild leaves the Witcher, Geralt of Rivia, gravely injured, and his ward Ciri missing in the third novel of Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games. \r\nThe Wizards Guild has been shattered by a coup, an uprising that has left Geralt seriously injured.\r\nThe Witcher is supposed to be a guardian of the innocent, a protector of those in need, a defender against powerful and dangerous monsters that prey on men in dark times. But now that dark times have fallen upon the world, Geralt is helpless until he has recovered.\r\nWhile war rages across the lands, the future of magic is under threat and those sorcerers who survive are determined to protect it. It’s an impossible situation in which to find one girl—Ciri, the heiress to the throne of Cintra—until a rumor places her in the Niflgaard court, preparing to marry the Emperor.\r\nInjured or not, Geralt has a rescue mission on his hands.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 27, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Tower of Swallows",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316452960.jpg?fit=450%2C675",
                    Book_description = "The world is at war and the prophesied savior is nowhere to be found. The Witcher, Geralt of Rivia, races to find her in the fourth novel of Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games. \r\nThe world has fallen into war. Ciri, the child of prophecy, has vanished. Hunted by friends and foes alike, she has taken on the guise of a petty bandit and lives free for the first time in her life.\r\nBut the net around her is closing. Geralt, the Witcher, has assembled a group of allies including Dandelion, Milva, Regis, and Cahir, to rescue her. Both sides of the war have sent brutal mercenaries to hunt her down. Her crimes have made her famous.\r\nThere is only one place left to run. The tower of the swallow is waiting. . .\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 28, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Lady of the Lake",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316453066.jpg?fit=450%2C673",
                    Book_description = "Trapped in a world ruled by the Elves, separated from Geralt and her destiny, Ciri will need all her training as a fighter and sorceress to survive in the fifth novel of the Witcher, Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.\r\nAfter walking through the portal in the Tower of Swallows and narrowly escaping death, Ciri finds herself in a completely different world. . . an Elven world. Time does not seem to exist and there are no obvious borders or portals to cross back into her home world. She is trapped.\r\nBut this is the child of prophecy, and she will not be defeated. She knows she must escape to finally rejoin the Witcher and his companions—and also to conquer her worst nightmare. Leo Bonhart, the man who chased, wounded, and tortured Ciri, is still on her trail. And the world is still at war.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 29, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 1, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Season of Storms",
                    Book_author = "Andrzej  Sapkowski",
                    Book_publisher = "Orbit",
                    Book_date = DateTime.Parse("2022-08-25"),
                    Book_price = 17.99,
                    Book_image = "https://www.hachettebookgroup.com/wp-content/uploads/2022/07/9780316453165.jpg?fit=450%2C675",
                    Book_description = "Before he was the guardian of Ciri, the child of destiny, Geralt of Rivia was a legendary swordsman. Join the Witcher as he undertakes a deadly mission in this stand-alone adventure set in the Andrzej Sapkowki’s groundbreaking epic fantasy world that inspired the hit Netflix show and the blockbuster video games.\r\nGeralt of Rivia is a Witcher, one of the few capable of hunting the monsters that prey on humanity. He uses magical signs, potions, and the pride of every Witcher—two swords, steel and silver.\r\nBut a contract has gone wrong, and Geralt finds himself without his signature weapons. Now he needs them back, because sorcerers are scheming, and across the world clouds are gathering.\r\nThe season of storms is coming. . .\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 30, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 2, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "To Kill a Mockingbird",
                    Book_author = "Harper Lee",
                    Book_publisher = "Harper Perennial Modern Classics",
                    Book_date = DateTime.Parse("2019-8-23"),
                    Book_price = 7.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1553383690l/2657.jpg",
                    Book_description = "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it. \"To Kill A Mockingbird\" became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 31, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 2, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Jane Eyre",
                    Book_author = "Charlotte Brontë",
                    Book_publisher = "Penguin",
                    Book_date = DateTime.Parse("2024-07-04"),
                    Book_price = 10.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1557343311l/10210._SY475_.jpg",
                    Book_description = "Orphaned as a child, Jane has felt an outcast her whole young life. Her courage is tested once again when she arrives at Thornfield Hall, where she has been hired by the brooding, proud Edward Rochester to care for his ward Adèle. Jane finds herself drawn to his troubled yet kind spirit. She falls in love. Hard.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 32, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 2, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Crime and Punishment",
                    Book_author = "Fyodor Dostoyevsky",
                    Book_publisher = "Penguin",
                    Book_date = DateTime.Parse("2002-12-31"),
                    Book_price = 12.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1382846449l/7144.jpg",
                    Book_description = "",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 33, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 2, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Catcher in the Rye",
                    Book_author = "J.D. Salinger",
                    Book_publisher = "Back Bay Books",
                    Book_date = DateTime.Parse("2001-07-30"),
                    Book_price = 5.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1398034300l/5107.jpg",
                    Book_description = "Fleeing the crooks at Pencey Prep, he pinballs around New York City seeking solace in fleeting encounters—shooting the bull with strangers in dive hotels, wandering alone round Central Park, getting beaten up by pimps and cut down by erstwhile girlfriends.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 34, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 2, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Great Gatsby",
                    Book_author = "F. Scott Fitzgerald",
                    Book_publisher = "Scribner",
                    Book_date = DateTime.Parse("1925-04-10"),
                    Book_price = 15.0,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1490528560l/4671._SY475_.jpg",
                    Book_description = "",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 35, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Pride and Prejudice",
                    Book_author = "Jane Austen",
                    Book_publisher = "Modern Library",
                    Book_date = DateTime.Parse("2000-09-10"),
                    Book_price = 7.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1320399351l/1885.jpg",
                    Book_description = "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\"",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 36, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Fifty Shades of Grey",
                    Book_author = "E.L. James",
                    Book_publisher = "Vintage",
                    Book_date = DateTime.Parse("2011-05-25"),
                    Book_price = 12.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1385207843l/10818853.jpg",
                    Book_description = "When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 37, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Beautiful Disaster",
                    Book_author = "Jamie McGuire",
                    Book_publisher = "Jamie McGuire",
                    Book_date = DateTime.Parse("2011-08-26"),
                    Book_price = 4.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358259032l/11505797.jpg",
                    Book_description = "The new Abby Abernathy is a good girl. She doesn’t drink or swear, and she has the appropriate number of cardigans in her wardrobe. Abby believes she has enough distance from the darkness of her past, but when she arrives at college with her best friend, her path to a new beginning is quickly challenged by Eastern University's Walking One-Night Stand.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 38, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Twilight",
                    Book_author = "Stephenie Meyer",
                    Book_publisher = "Little, Brown and Company",
                    Book_date = DateTime.Parse("2016-09-06"),
                    Book_price = 15.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1361039443l/41865.jpg",
                    Book_description = "About three things I was absolutely positive.\r\nFirst, Edward was a vampire.\r\nSecond, there was a part of him—and I didn't know how dominant that part might be—that thirsted for my blood.\r\n\r\nAnd third, I was unconditionally and irrevocably in love with him.\r\nDeeply seductive and extraordinarily suspenseful, Twilight is a love story with bite.\r\n",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 39, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Perfect Chemistry",
                    Book_author = "Simone Elkeles",
                    Book_publisher = "Walker Childrens",
                    Book_date = DateTime.Parse("2008-12-23"),
                    Book_price = 10.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1439792475l/4268157.jpg",
                    Book_description = "When Brittany Ellis walks into chemistry class on the first day of senior year, she has no clue that her carefully created 'perfect' life is about to unravel before her eyes. She's forced to be lab partners with Alex Fuentes, a gang member from the other side of town, and he is about to threaten everything she…",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 40, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 3, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Notebook",
                    Book_author = "Nicholas Sparks",
                    Book_publisher = "Grand Central Publishing",
                    Book_date = DateTime.Parse("2000-01-05"),
                    Book_price = 13.00,
                    Book_image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1483183484l/33648131._SY475_.jpg",
                    Book_description = "Set amid the austere beauty of the North Carolina coast begins the story of Noah Calhoun, a rural Southerner recently returned from the Second World War. Noah is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 41, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 4, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Sherlock Holmes",
                    Book_author = "Arthur Conan Doyle",
                    Book_publisher = "Literary publishers",
                    Book_date = DateTime.Parse("1887-08-25"),
                    Book_price = 20,
                    Book_image = "https://www.nhasachminhthang.vn/UserFiles/files/sherlock%20t%E1%BA%ADp%203%20120k.png",
                    Book_description = "Referring to himself as a \"consulting detective\" in stories, Holmes is known for his excellent powers of observation, deduction, forensic science, and logical deduction, elements of which he applies when investigating. cases of a variety of clients, including Scotland Yard.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 42, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 4, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Death on the Nile",
                    Book_author = "Agatha Christie",
                    Book_publisher = "Collins Crime Club",
                    Book_date = DateTime.Parse("1937-11-01"),
                    Book_price = 15.00,
                    Book_image = "https://agathachristie.imgix.net/image-store/Jacket_FilmTieInDOTN.jpg?auto=compress,format&fit=clip&q=65&w=400",
                    Book_description = "The work is about a murder that happened on a cruise ship on the Nile while detective Hercule Poirot was on vacation in Egypt. This is one of Agatha Christie's most beloved novels, which has been adapted into plays and movies many times.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 43, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 4, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Silence of the Lambs",
                    Book_author = "Thomas Harris",
                    Book_publisher = "ST. Martin’s Press",
                    Book_date = DateTime.Parse("1998-05-19"),
                    Book_price = 17,
                    Book_image = "https://salt.tikicdn.com/cache/w1200/media/catalog/product/s/u/su-im-lang-cua-bay-cuu.jpg",
                    Book_description = "The Silence of the Lambs is the story of a tense mind battle between FBI police woman Clarice Starling and cannibal doctor Hannibal Lecter. In order to find clues to the case of kidnapping the senator's daughter, Starling has to go to the Tri Vien Nursing Home to get information about the case.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 44, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 4, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Inferno",
                    Book_author = "Dan Brown",
                    Book_publisher = "Doubleday",
                    Book_date = DateTime.Parse("2013-05-14"),
                    Book_price = 18.00,
                    Book_image = "https://cdn0.fahasa.com/media/catalog/product/i/m/image_195509_1_31875.jpg",
                    Book_description = "The opening story is a bit confusing when the professor wakes up in an unfamiliar hospital and has almost lost all memories of the past few days. And at that time, he also had to immediately run away from a series of pursuers without knowing the reason. Still a familiar motif in our previous works, but we never seem to get bored, but on the contrary, we always anxiously follow each cleverly deciphered puzzle, code, and symbol.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 45, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 4, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "The Da Vinci Code",
                    Book_author = "Dan Brown",
                    Book_publisher = "Doubleday Fiction",
                    Book_date = DateTime.Parse("2003-08-25"),
                    Book_price = 19.00,
                    Book_image = "https://upload.wikimedia.org/wikipedia/vi/thumb/8/84/M%E1%BA%ADt_m%C3%A3_davinci.jpg/220px-M%E1%BA%ADt_m%C3%A3_davinci.jpg",
                    Book_description = "The plot of the novel tells about the conspiracy of the Catholic Church to hide the truth about Jesus. The story implies that the Holy See of Rome knew about this plot for two thousand years, but still kept it a secret to maintain its power. Upon its publication, the novel strongly aroused curiosity around the world to find out the truth about the Legend of the Holy Grail, and Mary Magdalene's role in the history of the Catholic Church.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 46, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 5, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Detective Conan",
                    Book_author = "Aoyama Gōshō",
                    Book_publisher = "Shogakukan",
                    Book_date = DateTime.Parse("1994-01-19"),
                    Book_price = 3.00,
                    Book_image = "http://cdn.shopify.com/s/files/1/0566/9650/4367/products/Conan99.webp?v=1662734369",
                    Book_description = "The story revolves around a high school detective named Kudo Shinichi, while investigating a mysterious Black Organization, was forced to drink a deadly poison. Fortunately, he survived, but his body was shrunken like a 6-year-old child. In order to avoid revealing his true identity, he took the name Edogawa Conan and moved in with his childhood friend Ran Mori's house with her father, a private detective named Mori Kogoro. Hopefully one day he can defeat the Black Organization and regain his original form.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 47, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 5, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Crayon Shin-chan",
                    Book_author = "Usui Yoshito",
                    Book_publisher = "Futabasha",
                    Book_date = DateTime.Parse("2010-02-05"),
                    Book_price = 4.00,
                    Book_image = "https://product.hstatic.net/200000122283/product/shin-cau-be-but-chi-tap-34-l3uhj_d78f2c3421d34d5e8aa1eda525e7a7f4_master.png",
                    Book_description = "The content revolves around the boy Shin with stories about daily life with his parents, younger sister, dog Snow White, friends, neighbors, close relatives and other characters.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 48, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 5, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Doraemon",
                    Book_author = "Fujiko F. Fujio",
                    Book_publisher = "Shogakukan",
                    Book_date = DateTime.Parse("1996-06-23"),
                    Book_price = 3.00,
                    Book_image = "https://product.hstatic.net/200000122283/product/doraemon-truyen-ngan-tap-20-tai-ban-2019-22gqm_f734976610d24532b33df1af77bd0736_grande.png",
                    Book_description = "The series content tells about the unfortunate life of the boy Nobita and the robotic cat Doraemon from the future who come to help the boy's life become better.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 49, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 5, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Dragon Ball",
                    Book_author = "Toriyama Akira",
                    Book_publisher = "Shueisha",
                    Book_date = DateTime.Parse("1995-08-25"),
                    Book_price = 3.00,
                    Book_image = "https://product.hstatic.net/200000122283/product/1__50__wnkv-94_d160e68f191d47af90a92978c8bff32d_master.png",
                    Book_description = "Contrasting with the Chinese novel Journey to the West, the series depicts Son Goku's journey from childhood to adulthood, through his quests to learn martial arts and explore the world in search of the Dragon Balls. Wish from the sacred dragon. Throughout Son Goku's journey, he met many friends and fought off villains who plotted to use wishes from the sacred dragon to rule the world.",
                    Book_quantity = 30
                },
                new Book
                {
                    Id = 50, //Id không cần phải bắt đầu từ 1 (gõ tùy ý nhưng giá trị phải khác nhau)
                    GenreId = 5, //Gerne_id phải tồn tại ở trong bảng Genre, co nghia la "1" phai ton tai
                    Book_name = "Kuroko's Basketball",
                    Book_author = "Tadatoshi Fujimaki",
                    Book_publisher = "Shueisha",
                    Book_date = DateTime.Parse("2014-09-01"),
                    Book_price = 5.00,
                    Book_image = "https://cf.shopee.vn/file/7391c83f1cd160abd380773f89b2cbbb",
                    Book_description = "It tells the story of a high school basketball team trying to make it to the national tournament.",
                    Book_quantity = 30
                }
            );
        }
    }
}
