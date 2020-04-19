using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblCart = new HashSet<TblCart>();
            TblCustomerRatings = new HashSet<TblCustomerRatings>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public bool? IsFeatured { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual TblCategory Category { get; set; }
        public virtual ICollection<TblCart> TblCart { get; set; }
        public virtual ICollection<TblCustomerRatings> TblCustomerRatings { get; set; }
    }
}
