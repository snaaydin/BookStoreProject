using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Book : BaseModel
    {
        public DateTime YearOfPublication { get; set; } 
        public int PageCount { get; set; }
        public string? IMG { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Publisher> Publishers { get; set; } = new List<Publisher>();
        public virtual Shelf Shelf { get; set; }

        
    }
}
