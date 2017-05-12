namespace HotelDB
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HotelDBContext : DbContext
    {
        public HotelDBContext()
            : base("name=HotelDBContext")
        {
        }
        public IDbSet<Employee> Employees { get; set; }

        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<RoomStatus> RoomStatus { get; set; }

        public IDbSet<RoomType> RoomTypes { get; set; }

        public IDbSet<BedType> BedTypes { get; set; }

        public IDbSet<Room> Rooms { get; set; }

        public IDbSet<Payment> Payments { get; set; }

        public IDbSet<Occupancie> Occupancies { get; set; }
    }    
}