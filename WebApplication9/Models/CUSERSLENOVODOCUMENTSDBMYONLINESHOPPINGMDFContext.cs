using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication9.Models
{
    public partial class CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext : DbContext
    {
        public CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext()
        {
        }

        public CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext(DbContextOptions<CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCart> TblCart { get; set; }
        public virtual DbSet<TblCartStatus> TblCartStatus { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCustomerRatings> TblCustomerRatings { get; set; }
        public virtual DbSet<TblMembers> TblMembers { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblRoles> TblRoles { get; set; }
        public virtual DbSet<TblShippingDetails> TblShippingDetails { get; set; }
        public virtual DbSet<TblSlideImage> TblSlideImage { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=C:\\USERS\\LENOVO\\DOCUMENTS\\DBMYONLINESHOPPING.MDF;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__Tbl_Cart__51BCD7B7A9FC6589");

                entity.ToTable("Tbl_Cart");

                entity.HasOne(d => d.CartStatus)
                    .WithMany(p => p.TblCart)
                    .HasForeignKey(d => d.CartStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_Cart__CartSt__32E0915F");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblCart)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_Cart__Member__6477ECF3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblCart)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_Cart__Produc__5EBF139D");
            });

            modelBuilder.Entity<TblCartStatus>(entity =>
            {
                entity.HasKey(e => e.CartStatusId)
                    .HasName("PK__Tbl_Cart__031908A8B7F6D43F");

                entity.ToTable("Tbl_CartStatus");

                entity.Property(e => e.CartStatusId).ValueGeneratedNever();

                entity.Property(e => e.CartStatus)
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tmp_ms_x__19093A0BE4C730DD");

                entity.ToTable("Tbl_Category");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ__tmp_ms_x__8517B2E0877F85AB")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            });

            modelBuilder.Entity<TblCustomerRatings>(entity =>
            {
                entity.ToTable("Tbl_CustomerRatings");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblCustomerRatings)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerRatings_ToTable");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblCustomerRatings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerRatings_ToTblProduct");
            });

            modelBuilder.Entity<TblMembers>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__tmp_ms_x__0CF04B182BECFCB8");

                entity.ToTable("Tbl_Members");

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__tmp_ms_x__7ED91ACE3D0F68AA")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tmp_ms_x__B40CC6CDEC7D8CF5");

                entity.ToTable("Tbl_Product");

                entity.HasIndex(e => e.ProductName)
                    .HasName("UQ__tmp_ms_x__DD5A978AD1BB4352")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(800)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductImage).IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_Produ__Categ__5DCAEF64");
            });

            modelBuilder.Entity<TblRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Tbl_Role__8AFACE1AF3B9706A");

                entity.ToTable("Tbl_Roles");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShippingDetails>(entity =>
            {
                entity.HasKey(e => e.ShippingDetailsId)
                    .HasName("PK__Tbl_Ship__28E40ED14C89F31E");

                entity.ToTable("Tbl_ShippingDetails");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPaid).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblShippingDetails)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_Shipp__Membe__6383C8BA");
            });

            modelBuilder.Entity<TblSlideImage>(entity =>
            {
                entity.HasKey(e => e.SlideId)
                    .HasName("PK__Tbl_Slid__9E7CB650CFB7F2E4");

                entity.ToTable("Tbl_SlideImage");

                entity.Property(e => e.SlideImage).IsUnicode(false);

                entity.Property(e => e.SlideTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
