using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLBH.Models; //truy xuất đến các lớp như Customer
using System.Configuration;

namespace QLBH

{
    internal class EFDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ChuyenBay> ChuyenBays { get; set; }
        public DbSet<SanBay> SanBays { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<OrderTicket> OrderTickets { get; set; }

        public DbSet<OrderTicketDetail> OrderTicketDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }
        public void ConfigureServices(IServiceCollection services) => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*  modelBuilder.Entity<OrderTicketDetail>().HasKey("OrderTicketDetailID");
              modelBuilder.Entity<OrderTicketDetail>().HasKey(o => new { o.OrderTicketID, o.TicketID }); */
            modelBuilder.Entity<Customer>(c =>
  {
      c.Property(b => b.CCCD).HasColumnType("nvarchar(12)").IsRequired();
      c.Property(b => b.BirthDay).HasColumnType("date");
  });
            modelBuilder.Entity<OrderTicketDetail>(c =>
            {
                c.Property(b => b.Price).HasColumnType("decimal(18, 2)").IsRequired();
            });
            //Khách Hàng
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                CustomerID = 1,
                Name = "Nguyễn Văn Thơ",
                Phone = "0757294361",
                Email = "NguyenVanT@gmail.com",
                CCCD = "012345678901",
                Gender = false,
                BirthDay = DateTime.Parse("2000-12-22"),

            },

            new Customer
            {
                CustomerID = 2,
                Name = "Trần Thị Hồng Ngọc",
                Phone = "0989102574",
                Email = "THNT56565@email.com",
                CCCD = "068903241849",
                Gender = true,
                BirthDay = DateTime.Parse("1999-11-1"),

            },

            new Customer
            {
                CustomerID = 3,
                Name = "Lê Quốc Ca",
                Phone = "0343671829",
                Email = "LeQuocSong@gmail.com",
                CCCD = "054321319302",
                Gender = true,
                BirthDay = DateTime.Parse("1987-12-3"),

            },
            new Customer
            {
                CustomerID = 4,
                Name = "Phạm Anh Đồng",
                Phone = "0460492715",
                Email = "PhamAnhCope@email.com",
                CCCD = "097654810294",
                Gender = true,
                BirthDay = DateTime.Parse("2001-2-28"),

            },

            new Customer
            {
                CustomerID = 5,
                Name = "Hoàng Thị Én",
                Phone = "0431568942",
                Email = "HoangTHiBird@gmail.com",
                CCCD = "024683719492",
                Gender = true,
                BirthDay = DateTime.Parse("1995-2-15"),

            },
             new Customer
             {
                 CustomerID = 6,
                 Name = "Vũ Minh Phương",
                 Phone = "0520873456",
                 Email = "VuMinhFea@email.com",
                 CCCD = "015793819201",
                 Gender = false,
                 BirthDay = DateTime.Parse("1996-3-7"),

             },
             new Customer
             {
                 CustomerID = 7,
                 Name = "Bùi Văn Giang",
                 Phone = "0678941320",
                 Email = "GiangBui@email.com",
                 CCCD = "086420728192",
                 Gender = null,
                 BirthDay = DateTime.Parse("1998-4-15"),

             },
             new Customer
             {
                 CustomerID = 8,
                 Name = "Ngô Thanh Huyền",
                 Phone = "0412456789",
                 Email = "NgoThank@gmail.com",
                 CCCD = "075314839292",
                 Gender = false,
                 BirthDay = DateTime.Parse("1999-7-24"),

             },
             new Customer
             {
                 CustomerID = 9,
                 Name = "Đặng Thu Thảo",
                 Phone = "0793502748",
                 Email = "ThuThao123@email.com",
                 CCCD = "062082738592",
                 Gender = true,
                 BirthDay = DateTime.Parse("1994-2-1"),

             },
             new Customer
             {
                 CustomerID = 10,
                 Name = "Trương Tâm Tú",
                 Phone = "0736251849",
                 Email = "TamTu@gmail.com",
                 CCCD = "031425928473",
                 Gender = true,
                 BirthDay = DateTime.Parse("1993-6-27"),

             },
             new Customer
             {
                 CustomerID = 11,
                 Name = "Lâm Quang Khải",
                 Phone = "0750781693",
                 Email = "HaiQuan@gmail.com",
                 CCCD = "076542819382",
                 Gender = true,
                 BirthDay = DateTime.Parse("1992-3-28"),

             },
             new Customer
             {
                 CustomerID = 12,
                 Name = "Hồ Thị Lai",
                 Phone = "0568923147",
                 Email = "LaiHo@email.com",
                 CCCD = "020987371284",
                 Gender = true,
                 BirthDay = DateTime.Parse("1997-4-30"),

             },
             new Customer
             {
                 CustomerID = 13,
                 Name = "Đỗ Hoàng Minh",
                 Phone = "0424589310",
                 Email = "HoangMink@email.com",
                 CCCD = "057898392012",
                 Gender = false,
                 BirthDay = DateTime.Parse("1978-10-31"),

             },
             new Customer
             {
                 CustomerID = 14,
                 Name = "Châu Minh Nhi",
                 Phone = "0371820394",
                 Email = "ChildNkee@gmail.com",
                 CCCD = "013404859402",
                 Gender = false,
                 BirthDay = DateTime.Parse("2003-12-31"),

             },
             new Customer
             {
                 CustomerID = 15,
                 Name = "Mai Thị Oanh",
                 Phone = "0296047258",
                 Email = "MaiTki@email.com",
                 CCCD = "045672817492",
                 Gender = true,
                 BirthDay = DateTime.Parse("2002-11-19"),

             },
             new Customer
             {
                 CustomerID = 16,
                 Name = "Nguyễn Hồng Phúc",
                 Phone = "0512345678",
                 Email = "PinkHappy@gmail.com",
                 CCCD = "09760385748",
                 Gender = false,
                 BirthDay = DateTime.Parse("2000-10-13"),

             },
             new Customer
             {
                 CustomerID = 17,
                 Name = "Lê Thị thanh Quỳnh",
                 Phone = "0787463291",
                 Email = "LTTQuỳnh@email.com",
                 CCCD = "05310758492",
                 Gender = true,
                 BirthDay = DateTime.Parse("1984-7-15"),

             },
             new Customer
             {
                 CustomerID = 18,
                 Name = "Phan Thanh Trà",
                 Phone = "0953127964",
                 Email = "ThanhPhanTea@gmail.com",
                 CCCD = "068904657322",
                 Gender = true,
                 BirthDay = DateTime.Parse("1980-6-30"),

             },
             new Customer
             {
                 CustomerID = 19,
                 Name = "Trần Văn Sĩ",
                 Phone = "0974920518",
                 Email = "TranSVan@gmail.com",
                 CCCD = "034567271392",
                 Gender = true,
                 BirthDay = DateTime.Parse("1988-3-19"),

             },
            new Customer
            {
                CustomerID = 20,
                Name = "Đinh Quốc Tuân",
                Phone = "0938562914",
                Email = "ILoveHN@gmail.com",
                CCCD = "080121839201",
                Gender = true,
                BirthDay = DateTime.Parse("1993-4-29"),

            }
            );

            //Nhân Viên
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeID = 1,
                Name = "Đỗ Bình An",
                Phone = "0987654321",
                Email = "nva@email.com",
                Password = "111",
                Gender = true,
                BirthDay = DateTime.Parse("1993-4-29"),
                DayWork = DateTime.Parse("2023-01-15"),
                CCCD = "079203024793",
                RoleID = 1
            },
           new Employee
           {
               EmployeeID = 2,
               Name = "Trần Thị Khánh Bâng",
               Phone = "0901234567",
               Email = "ttb@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("1988-3-19"),
               DayWork = DateTime.Parse("2023-02-20"),
               CCCD = "079203024794",
               RoleID = 2
           },
           new Employee
           {
               EmployeeID = 3,
               Name = "Lê Quốc Cảnh",
               Phone = "0912345678",
               Email = "lqc@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1980-6-30"),
               DayWork = DateTime.Parse("2023-03-25"),
               CCCD = "079203024795",
               RoleID = 2
           },
           new Employee
           {
               EmployeeID = 4,
               Name = "Phạm Anh Dũng",
               Phone = "0923456789",
               Email = "pad@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1984-7-15"),
               DayWork = DateTime.Parse("2023-04-30"),
               CCCD = "079203024796",
               RoleID = 3
           },
           new Employee
           {
               EmployeeID = 5,
               Name = "Emily Hoàng Thị",
               Phone = "0934567890",
               Email = "hte@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("2000-10-13"),
               DayWork = DateTime.Parse("2023-05-05"),
               CCCD = "079203024797",
               RoleID = 3
           },
           new Employee
           {
               EmployeeID = 6,
               Name = "Vũ Minh Toàn",
               Phone = "0945678901",
               Email = "vmf@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("2002-11-19"),
               DayWork = DateTime.Parse("2023-06-10"),
               CCCD = "079203024798",
               RoleID = 4
           },
           new Employee
           {
               EmployeeID = 7,
               Name = "Bùi Văn Nghị",
               Phone = "0956789012",
               Email = "bvng@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("2003-12-31"),
               DayWork = DateTime.Parse("2023-07-15"),
               CCCD = "079203024799",
               RoleID = 4
           },
           new Employee
           {
               EmployeeID = 8,
               Name = "Hoàng Hưu Hảo",
               Phone = "0967890123",
               Email = "nth@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1978-10-31"),
               DayWork = DateTime.Parse("2023-08-20"),
               CCCD = "079203024800",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 9,
               Name = "Đặng Thu Lam",
               Phone = "0978901234",
               Email = "dti@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("1997-4-30"),
               DayWork = DateTime.Parse("2023-09-25"),
               CCCD = "079203024801",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 10,
               Name = "Trương Tâm Trạng",
               Phone = "0989012345",
               Email = "ttjudge@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("1993-6-27"),
               DayWork = DateTime.Parse("2023-10-30"),
               CCCD = "079203024802",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 11,
               Name = "Lâm Quang Lưu",
               Phone = "0990123456",
               Email = "lqk@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1994-2-20"),
               DayWork = DateTime.Parse("2023-11-04"),
               CCCD = "079203024803",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 12,
               Name = "Hồ Thị Liên",
               Phone = "0901234567",
               Email = "htl@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("1999-7-24"),
               DayWork = DateTime.Parse("2003-12-09"),
               CCCD = "079203024804",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 13,
               Name = "Đỗ Hoàng Hảo",
               Phone = "0912345678",
               Email = "dhm@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1998-4-15"),
               DayWork = DateTime.Parse("2024-01-14"),
               CCCD = "079203024805",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 14,
               Name = "Châu Minh Tiến",
               Phone = "0923456789",
               Email = "cmn@email.com",
               Password = "111",
               Gender = true,
               BirthDay = DateTime.Parse("1996-3-7"),
               DayWork = DateTime.Parse("2024-02-19"),
               CCCD = "079203024806",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 15,
               Name = "Mai Thị Thu Hoàng",
               Phone = "0934567890",
               Email = "mto@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("1995-2-15"),
               DayWork = DateTime.Parse("2024-03-24"),
               CCCD = "079203024807",
               RoleID = 5
           },
           new Employee
           {
               EmployeeID = 16,
               Name = "Nguyễn Hồng",
               Phone = "0945678901",
               Email = "nhp@email.com",
               Password = "111",
               Gender = false,
               BirthDay = DateTime.Parse("2001-2-28"),
               DayWork = DateTime.Parse("2024-04-29"),
               CCCD = "079203024808",
               RoleID = 5
           }
                );

            //Chức Vụ
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, Name = "Tổng quản lý" },
                new Role { RoleID = 2, Name = "Quản lý chuyến bay" },
                new Role { RoleID = 3, Name = "Quản lý phi công" },
                new Role { RoleID = 4, Name = "Quản lý hành khách" },
                new Role { RoleID = 5, Name = "Phi công" });

            // Loại Máy Bay
            modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, CategoryName = "Máy bay hạng trung" },
            new Category { CategoryID = 2, CategoryName = "Máy bay hạng rộng mở rộng" },
            new Category { CategoryID = 3, CategoryName = "Máy bay hạng nhẹ" },
            new Category { CategoryID = 4, CategoryName = "Máy bay hạng rộng" },
            new Category { CategoryID = 5, CategoryName = "Máy bay kỹ thuật số" });

            // Máy Bay
            modelBuilder.Entity<Product>().HasData(
             new Product
             {
                 ProductID = 1,
                 CategoryID = 1,
                 Name = "Airbus A320",
                 ImageFile = "1.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 2,
                 CategoryID = 1,
                 Name = "Airbus A321",
                 ImageFile = "2.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 3,
                 CategoryID = 2,
                 Name = "Boeing 787-9",
                 ImageFile = "3.png",
                 Manufacturer = "Boeing",
                 Status = true,
             },
             new Product
             {
                 ProductID = 4,
                 CategoryID = 3,
                 Name = "Embraer E-Jet - E170",
                 ImageFile = "4.png",
                 Manufacturer = "Embraer",
                 Status = false,
             },
             new Product
             {
                 ProductID = 5,
                 CategoryID = 4,
                 Name = "Boeing 767-300",
                 ImageFile = "5.png",
                 Manufacturer = "Boeing",
                 Status = false,
             },
             new Product
             {
                 ProductID = 6,
                 CategoryID = 4,
                 Name = "Airbus A330-200",
                 ImageFile = "6.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 7,
                 CategoryID = 4,
                 Name = "Boeing 777-200",
                 ImageFile = "7.png",
                 Manufacturer = "Boeing",
                 Status = true,
             },
             new Product
             {
                 ProductID = 8,
                 CategoryID = 3,
                 Name = "Embraer E-Jet - E175",
                 ImageFile = "8.png",
                 Manufacturer = "Embraer",
                 Status = true,
             },
             new Product
             {
                 ProductID = 9,
                 CategoryID = 4,
                 Name = "Airbus A330-300",
                 ImageFile = "9.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 10,
                 CategoryID = 3,
                 Name = "Embraer E-Jet - E190",
                 ImageFile = "10.png",
                 Manufacturer = "Embraer",
                 Status = true,
             },
             new Product
             {
                 ProductID = 11,
                 CategoryID = 2,
                 Name = "Airbus A350 - 900",
                 ImageFile = "11.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 12,
                 CategoryID = 3,
                 Name = "Embraer E-Jet E-195",
                 ImageFile = "12.png",
                 Manufacturer = "Embraer",
                 Status = true,
             },
             new Product
             {
                 ProductID = 13,
                 CategoryID = 5,
                 Name = "COMAC C919",
                 ImageFile = "13.png",
                 Manufacturer = "China Eastern Airlines",
                 Status = false,
             },
             new Product
             {
                 ProductID = 14,
                 CategoryID = 2,
                 Name = "Airbus A350 - 1000",
                 ImageFile = "14.png",
                 Manufacturer = "Airbus S.A.S",
                 Status = true,
             },
             new Product
             {
                 ProductID = 15,
                 CategoryID = 3,
                 Name = "Bombardier CRJ-200",
                 ImageFile = "15.png",
                 Manufacturer = "Air Mekong",
                 Status = true,
             }

             );

            //Chuyến Bay
            modelBuilder.Entity<ChuyenBay>().HasData(
              new ChuyenBay
              {

                  ChuyenBayID = 1,
                  ProductID = 8,
                 // EmployeeID = 8,
                  SanBayDi = "HN",
                  SanBayDen = "SG",
                  ThoiGianDi = TimeSpan.Parse("7:15:00"),
                  ThoiGianDen = TimeSpan.Parse("9:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 2,
                  ProductID = 11,
                //  EmployeeID = 11,
                  SanBayDi = "DN",
                  SanBayDen = "HUE",
                  ThoiGianDi = TimeSpan.Parse("18:30:00"),
                  ThoiGianDen = TimeSpan.Parse("19:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 3,
                  ProductID = 7,
                //  EmployeeID = 13,
                  SanBayDi = "HP",
                  SanBayDen = "HN",
                  ThoiGianDi = TimeSpan.Parse("05:30:00"),
                  ThoiGianDen = TimeSpan.Parse("07:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 4,
                  ProductID = 1,
               //   EmployeeID = 10,
                  SanBayDi = "SG",
                  SanBayDen = "HUE",
                  ThoiGianDi = TimeSpan.Parse("20:30:00"),
                  ThoiGianDen = TimeSpan.Parse("22:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 5,
                  ProductID = 15,
                //  EmployeeID = 14,
                  SanBayDi = "KG",
                  SanBayDen = "DN",
                  ThoiGianDi = TimeSpan.Parse("14:00:00"),
                  ThoiGianDen = TimeSpan.Parse("15:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 6,
                  ProductID = 14,
                //  EmployeeID = 13,
                  SanBayDi = "HUE",
                  SanBayDen = "KG",
                  ThoiGianDi = TimeSpan.Parse("11:30:00"),
                  ThoiGianDen = TimeSpan.Parse("13:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 7,
                  ProductID = 15,
                //  EmployeeID = 8,
                  SanBayDi = "HUE",
                  SanBayDen = "HN",
                  ThoiGianDi = TimeSpan.Parse("15:30:00"),
                  ThoiGianDen = TimeSpan.Parse("17:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 8,
                  ProductID = 1,
                //  EmployeeID = 12,
                  SanBayDi = "SG",
                  SanBayDen = "DN",
                  ThoiGianDi = TimeSpan.Parse("08:00:00"),
                  ThoiGianDen = TimeSpan.Parse("10:00:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 9,
                  ProductID = 9,
               //   EmployeeID = 9,
                  SanBayDi = "KG",
                  SanBayDen = "HP",
                  ThoiGianDi = TimeSpan.Parse("12:00:00"),
                  ThoiGianDen = TimeSpan.Parse("14:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 10,
                  ProductID = 7,
             //     EmployeeID = 16,
                  SanBayDi = "DN",
                  SanBayDen = "HP",
                  ThoiGianDi = TimeSpan.Parse("06:30:00"),
                  ThoiGianDen = TimeSpan.Parse("08:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 11,
                  ProductID = 15,
               //   EmployeeID = 11,
                  SanBayDi = "HP",
                  SanBayDen = "SG",
                  ThoiGianDi = TimeSpan.Parse("10:00:00"),
                  ThoiGianDen = TimeSpan.Parse("12:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 12,
                  ProductID = 8,
               //   EmployeeID = 14,
                  SanBayDi = "HUE",
                  SanBayDen = "SG",
                  ThoiGianDi = TimeSpan.Parse("21:30:00"),
                  ThoiGianDen = TimeSpan.Parse("23:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 13,
                  ProductID = 7,
               //   EmployeeID = 8,
                  SanBayDi = "HN",
                  SanBayDen = "DN",
                  ThoiGianDi = TimeSpan.Parse("23:00:00"),
                  ThoiGianDen = TimeSpan.Parse("01:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 14,
                  ProductID = 6,
               //   EmployeeID = 12,
                  SanBayDi = "KG",
                  SanBayDen = "SG",
                  ThoiGianDi = TimeSpan.Parse("04:00:00"),
                  ThoiGianDen = TimeSpan.Parse("05:30:00"),
              },
              new ChuyenBay
              {
                  ChuyenBayID = 15,
                  ProductID = 3,
               //   EmployeeID = 15,
                  SanBayDi = "HP",
                  SanBayDen = "HUE",
                  ThoiGianDi = TimeSpan.Parse("19:00:00"),
                  ThoiGianDen = TimeSpan.Parse("20:30:00"),
              }
              );

            //Sân bay
            modelBuilder.Entity<SanBay>().HasData(
               new SanBay
               {
                   SanBayID = "HN",
                   TenSanBay = "Quốc Tế Nội Bài",
                   Address = "Hà Nội",

               },
               new SanBay
               {
                   SanBayID = "SG",
                   TenSanBay = "Quốc Tế Tân Sân Nhất",
                   Address = "TP HCM",
               },
               new SanBay
               {
                   SanBayID = "DN",
                   TenSanBay = "Quốc Tế Đà Nẵng",
                   Address = "Đà Nẵng",
               },
               new SanBay
               {
                   SanBayID = "KG",
                   TenSanBay = "Quốc Tế Phú Quốc",
                   Address = "Kiên Giang",
               },
               new SanBay
               {
                   SanBayID = "HP",
                   TenSanBay = "Quốc Tế Cát Bi",
                   Address = "Hải Phòng",
               },
               new SanBay
               {
                   SanBayID = "HUE",
                   TenSanBay = "Quốc Tế Phú Bài",
                   Address = "Huế",
               }
               );

            //Vé
            modelBuilder.Entity<Ticket>().HasData(
             new Ticket
             {
                 TicketID = 1,
                 Name = "Vé Thường",
                 Price = 500.000M,
             },
             new Ticket
             {
                 TicketID = 2,
                 Name = "Vé Phổ Thông",
                 Price = 350.000M,
             },
             new Ticket
             {
                 TicketID = 3,
                 Name = "Vé Kinh Doanh",
                 Price = 800.000M,
             },
             new Ticket
             {
                 TicketID = 4,
                 Name = "Vé Hạng Nhất",
                 Price = 1500.000M,
             },
             new Ticket
             {
                 TicketID = 5,
                 Name = "Vé Economic",
                 Price = 450.000M,
             },
             new Ticket
             {
                 TicketID = 6,
                 Name = "Vé Premium Economy",
                 Price = 700.000M,
             },
             new Ticket
             {
                 TicketID = 7,
                 Name = "Vé Business Class",
                 Price = 1200.000M,
             },
             new Ticket
             {
                 TicketID = 8,
                 Name = "Vé First Class",
                 Price = 2000.000M,
             },
             new Ticket
             {
                 TicketID = 9,
                 Name = "Vé Cơ Bản",
                 Price = 300.000M,
             },
             new Ticket
             {
                 TicketID = 10,
                 Name = "Vé Tiết Kiệm",
                 Price = 250.000M,
             },
             new Ticket
             {
                 TicketID = 11,
                 Name = "Vé Linh Hoạt",
                 Price = 400.000M,
             },
             new Ticket
             {
                 TicketID = 12,
                 Name = "Vé Super Saver",
                 Price = 220.000M,
             },

             new Ticket
             {
                 TicketID = 13,
                 Name = "Vé Thương Gia",
                 Price = 1000.000M,
             });

            //Đặt Vé
            modelBuilder.Entity<OrderTicket>().HasData(
             new OrderTicket
             {
                 OrderTicketID = 1,
                 CustomerID = 1,
                 ChuyenBayID = 1,
                 OrderDate = DateTime.Parse("2023-8-16"),
                 Description = "khách không ăn thịt đỏ",
             },
             new OrderTicket
             {
                 OrderTicketID = 2,
                 CustomerID = 2,
                 ChuyenBayID = 1,
                 OrderDate = DateTime.Parse("2023-1-27"),
                 Description = "Khách ăn chay",
             },
             new OrderTicket
             {
                 OrderTicketID = 3,
                 CustomerID = 3,
                 ChuyenBayID = 2,
                 OrderDate = DateTime.Parse("2023-11-12"),
                 Description = "Khách có vấn đề về thận (bạn Én)",
             },
             new OrderTicket
             {
                 OrderTicketID = 4,
                 CustomerID = 4,
                 ChuyenBayID = 2,
                 OrderDate = DateTime.Parse("2023-6-25"),
                 Description = "Khách VIP",
             },
             new OrderTicket
             {
                 OrderTicketID = 5,
                 CustomerID = 5,
                 ChuyenBayID = 7,
                 OrderDate = DateTime.Parse("2023-12-11"),
                 Description = "Khách ăn chay",
             },
             new OrderTicket
             {
                 OrderTicketID = 6,
                 CustomerID = 6,
                 ChuyenBayID = 10,
                 OrderDate = DateTime.Parse("2023-11-18"),
                 Description = "Khách là người già cần hỗ trợ kỹ lưỡng",
             },
             new OrderTicket
             {
                 OrderTicketID = 7,
                 CustomerID = 7,
                 ChuyenBayID = 15,
                 OrderDate = DateTime.Parse("2023-6-4"),
                 Description = "Khách ăn chay",
             },
             new OrderTicket
             {
                 OrderTicketID = 8,
                 CustomerID = 8,
                 ChuyenBayID = 8,
                 OrderDate = DateTime.Parse("2023-8-7"),
                 Description = "Khách không ăn thịt đỏ",
             },
             new OrderTicket
             {
                 OrderTicketID = 9,
                 CustomerID = 9,
                 ChuyenBayID = 9,
                 OrderDate = DateTime.Parse("2023-11-30"),
                 Description = "Khách ăn chay",
             },
             new OrderTicket
             {
                 OrderTicketID = 10,
                 CustomerID = 10,
                 ChuyenBayID = 14,
                 OrderDate = DateTime.Parse("2023-4-29"),
                 Description = "Khách VIP",
             },
             new OrderTicket
             {
                 OrderTicketID = 11,
                 CustomerID = 11,
                 ChuyenBayID = 1,
                 OrderDate = DateTime.Parse("2023-12-5"),
                 Description = "Khách VIP",
             },
             new OrderTicket
             {
                 OrderTicketID = 12,
                 CustomerID = 12,
                 ChuyenBayID = 4,
                 OrderDate = DateTime.Parse("2023-10-19"),
                 Description = "Khách VIP",
             },
             new OrderTicket
             {
                 OrderTicketID = 13,
                 CustomerID = 13,
                 ChuyenBayID = 11,
                 OrderDate = DateTime.Parse("2023-12-10"),
                 Description = "Khách không ăn thịt đỏ",
             },
             new OrderTicket
             {
                 OrderTicketID = 14,
                 CustomerID = 14,
                 ChuyenBayID = 12,
                 OrderDate = DateTime.Parse("2023-12-30"),
                 Description = "Khách mang thai",
             },
             new OrderTicket
             {
                 OrderTicketID = 15,
                 CustomerID = 15,
                 ChuyenBayID = 8,
                 OrderDate = DateTime.Parse("2023-8-11"),
                 Description = "Khách ăn chay",
             }
             );

            //Chi Tiết Đặt Vé
            modelBuilder.Entity<OrderTicketDetail>().HasData(
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 1,
                 OrderTicketID = 1,
                 TicketID = 1,
                 Price = 500.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-8-16"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 2,
                 OrderTicketID = 2,
                 TicketID = 1,
                 Price = 500.000M,
                 Quantity = 3,
                 OrderDate = DateTime.Parse("2023-1-27"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 3,
                 OrderTicketID = 3,
                 TicketID = 2,
                 Price = 350.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-11-12"),
                 Status = false,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 4,
                 OrderTicketID = 4,
                 TicketID = 11,
                 Price = 400.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-6-25"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 5,
                 OrderTicketID = 5,
                 TicketID = 9,
                 Price = 300.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-12-11"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 6,
                 OrderTicketID = 6,
                 TicketID = 7,
                 Price = 200.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-11-18"),
                 Status = false,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 7,
                 OrderTicketID = 7,
                 TicketID = 2,
                 Price = 350.000M,
                 Quantity = 4,
                 OrderDate = DateTime.Parse("2023-6-4"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 8,
                 OrderTicketID = 8,
                 TicketID = 5,
                 Price = 450.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-8-7"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 9,
                 OrderTicketID = 9,
                 TicketID = 12,
                 Price = 220.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-11-30"),
                 Status = false,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 10,
                 OrderTicketID = 10,
                 TicketID = 13,
                 Price = 1000.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-4-29"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 11,
                 OrderTicketID = 11,
                 TicketID = 12,
                 Price = 220.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-12-5"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 12,
                 OrderTicketID = 12,
                 TicketID = 1,
                 Price = 500.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-10-19"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 13,
                 OrderTicketID = 13,
                 TicketID = 6,
                 Price = 700.000M,
                 Quantity = 1,
                 OrderDate = DateTime.Parse("2023-12-10"),
                 Status = false,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 14,
                 OrderTicketID = 14,
                 TicketID = 9,
                 Price = 300.000M,
                 Quantity = 2,
                 OrderDate = DateTime.Parse("2023-12-30"),
                 Status = true,
             },
             new OrderTicketDetail
             {
                 OrderTicketDetailID = 15,
                 OrderTicketID = 15,
                 TicketID = 8,
                 Price = 2000.000M,
                 Quantity = 2,
                 OrderDate = DateTime.Parse("2023-8-11"),
                 Status = true,
             });


        }
    }



}