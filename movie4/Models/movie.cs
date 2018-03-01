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
        public string Subject { get; set; }
        public string Body { get; set; }
        public int TicketStatusID { get; set; }
        public int DepartmentID { get; set; }

        [ForeignKey("CheckOutID")]
        public virtual CheckOut CheckOut { get; set; }
        [ForeignKey("MovieStatusID")]
        public virtual MovieStatus MovieStatus { get; set; }






    }
}