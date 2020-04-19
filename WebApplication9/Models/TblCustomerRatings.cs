using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblCustomerRatings
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public virtual TblMembers Member { get; set; }
        public virtual TblProduct Product { get; set; }
    }
}
