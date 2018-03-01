using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace movie4.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }
}