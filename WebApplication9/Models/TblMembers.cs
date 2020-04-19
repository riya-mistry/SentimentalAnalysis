using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblMembers
    {
        public TblMembers()
        {
            TblCart = new HashSet<TblCart>();
            TblCustomerRatings = new HashSet<TblCustomerRatings>();
            TblShippingDetails = new HashSet<TblShippingDetails>();
        }

        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<TblCart> TblCart { get; set; }
        public virtual ICollection<TblCustomerRatings> TblCustomerRatings { get; set; }
        public virtual ICollection<TblShippingDetails> TblShippingDetails { get; set; }
    }
}
