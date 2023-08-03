using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, Username = "Admin", Password = "1" };
        public static List<Book> books = new List<Book>()
        {
            new Book{Id =1, Description="Ahmet 994551235456"},
            new Book{Id =2, Description="Mehmet 994551235455"},
        };
    }

    public class Book
    {
        public int Id { get; set; }
        public string Description { get; set; }

      

    }
    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
