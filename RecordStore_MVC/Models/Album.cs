using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordStore_MVC.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }

        public virtual Band Band { get; set; }

    }


}