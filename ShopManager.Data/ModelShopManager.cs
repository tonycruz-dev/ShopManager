namespace ShopManager.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ShopManager.Models;

    public partial class ModelShopManager : DbContext
    {
        public ModelShopManager()
            : base("name=ModelShopManager")
        {
        }

        public virtual DbSet<AccountCreditNote> AccountCreditNotes { get; set; }
        public virtual DbSet<AccountCreditNoteDetail> AccountCreditNoteDetails { get; set; }
        public virtual DbSet<AccountCustomer> AccountCustomers { get; set; }
        public virtual DbSet<AccountInvoice> AccountInvoices { get; set; }
        public virtual DbSet<AccountInvoiceDetail> AccountInvoiceDetails { get; set; }
        public virtual DbSet<CashCustomer> CashCustomers { get; set; }
        public virtual DbSet<CashInvoice> CashInvoices { get; set; }
        public virtual DbSet<CashInvoiceDetail> CashInvoiceDetails { get; set; }
        public virtual DbSet<Estimate> Estimates { get; set; }
        public virtual DbSet<EstimateDetail> EstimateDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SupplierAccount> SupplierAccounts { get; set; }
        public virtual DbSet<SupplierOrderDetail> SupplierOrderDetails { get; set; }
        public virtual DbSet<SupplierOrder> SupplierOrders { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.PostPacking)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.TotalValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.VATValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.TotalVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.TotalPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.SearchCreditNoteId)
                .IsUnicode(false);

            modelBuilder.Entity<AccountCreditNote>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNote>()
                .HasMany(e => e.AccountCreditNoteDetails)
                .WithRequired(e => e.AccountCreditNote)
                .HasForeignKey(e => e.CreditNoteDetailId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountCreditNoteDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNoteDetail>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNoteDetail>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCreditNoteDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountCustomer>()
                .HasMany(e => e.AccountCreditNotes)
                .WithRequired(e => e.AccountCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.PostPacking)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.TotalValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.VATValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.TotalVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.TotalPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.SearchInvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<AccountInvoice>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoiceDetail>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoiceDetail>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountInvoiceDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.PostPacking)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.TotalValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.VATValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.TotalVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.TotalPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.SearchInvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.JobAddress)
                .IsFixedLength();

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.Deposite)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoice>()
                .Property(e => e.PaymentDisplay)
                .IsUnicode(false);

            modelBuilder.Entity<CashInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoiceDetail>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoiceDetail>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CashInvoiceDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.PostPacking)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.TotalValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.VATValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.TotalVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.TotalPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.SearchEstimateId)
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateDetail>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateDetail>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SupplierProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierAccount>()
                .HasMany(e => e.SupplierProducts)
                .WithRequired(e => e.SupplierAccount)
                .HasForeignKey(e => e.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrderDetail>()
                .Property(e => e.TotalLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrderDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrderDetail>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrder>()
                .Property(e => e.TotalPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrder>()
                .Property(e => e.SearchOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierOrder>()
                .Property(e => e.VATValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrder>()
                .Property(e => e.TotalVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SupplierOrder>()
                .HasMany(e => e.SupplierOrderDetails)
                .WithRequired(e => e.SupplierOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierProduct>()
                .Property(e => e.CostPrice)
                .HasPrecision(19, 4);
        }
    }
}
