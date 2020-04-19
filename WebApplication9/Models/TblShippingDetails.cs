using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblShippingDetails
    {
        public int ShippingDetailsId { get; set; }
        public int MemberId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public int? OrderId { get; set; }
        public decimal? AmountPaid { get; set; }
        public string PaymentType { get; set; }

        public virtual TblMembers Member { get; set; }
    }
}
