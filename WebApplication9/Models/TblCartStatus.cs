using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblCartStatus
    {
        public TblCartStatus()
        {
            TblCart = new HashSet<TblCart>();
        }

        public int CartStatusId { get; set; }
        public string CartStatus { get; set; }

        public virtual ICollection<TblCart> TblCart { get; set; }
    }
}
