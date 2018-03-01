using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace movie4.Models
{
    public class CheckOut
    {

        public int ID { get; set; }
        public int MovieID { get; set; }
        public String EmailAddress { get; set; }
        public DateTime BoughtTime { get; set; }

        [ForeignKey("MovieID")]
        public virtual Movie Movie { get; set; }

    }
}