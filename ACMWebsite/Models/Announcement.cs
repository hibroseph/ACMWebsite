using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMWebsite.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePosted { get; set; }
        public string Author { get; set; }
    }
}
