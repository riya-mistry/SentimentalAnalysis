using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblCart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int MemberId { get; set; }
        public int CartStatusId { get; set; }

        public virtual TblCartStatus CartStatus { get; set; }
        public virtual TblMembers Member { get; set; }
        public virtual TblProduct Product { get; set; }
    }
}
