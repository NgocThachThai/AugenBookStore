using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessor.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Authors { get; set; }
        public string PublishedDate { get; set; }
    }
}
