using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Author : BaseModel
    {
        public string Biography { get; set; }
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Category> Categories { get; set;} = new List<Category>();
        public ICollection<Publisher> Publishers { get; set; }= new List<Publisher>();

    }
}
