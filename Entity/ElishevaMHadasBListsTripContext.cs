using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity;

public partial class ElishevaMHadasBListsTripContext : DbContext
{
    public ElishevaMHadasBListsTripContext()
    {
    }

    public ElishevaMHadasBListsTripContext(DbContextOptions<ElishevaMHadasBListsTripContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Attraction> Attractions { get; set; }

    public virtual DbSet<AttractionList> AttractionLists { get; set; }

    public virtual DbSet<AttractionListProduct> AttractionListProducts { get; set; }

    public virtual DbSet<AttractionType> AttractionTypes { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Continent> Continents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<OpeningHour> OpeningHours { get; set; }

    public virtual DbSet<PersonState> PersonStates { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<SavedAttraction> SavedAttractions { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StatusProduct> StatusProducts { get; set; }

    public virtual DbSet<StorageType> StorageTypes { get; set; }

    public virtual DbSet<TripList> TripLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-E8KT20TD\\SQLEXPRESS01;Initial Catalog=ElishevaM_HadasB_ListsTrip;Integrated Security=True;Connect Timeout=200;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Land).HasMaxLength(20);
            entity.Property(e => e.Street).HasMaxLength(20);
        });

        modelBuilder.Entity<Attraction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_attraction");

            entity.ToTable("Attraction");

            entity.Property(e => e.Img).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Address).WithMany(p => p.Attractions)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attraction_Address");

            entity.HasOne(d => d.Country).WithMany(p => p.Attractions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attraction_Country");

            entity.HasOne(d => d.PersonState).WithMany(p => p.Attractions)
                .HasForeignKey(d => d.PersonStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attraction_PersonState");

            entity.HasOne(d => d.Type).WithMany(p => p.Attractions)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attraction_Attraction_type");
        });

        modelBuilder.Entity<AttractionList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_attraction_list");

            entity.ToTable("AttractionList");

            entity.Property(e => e.ExitDate).HasColumnType("datetime");
            entity.Property(e => e.RemainderDate).HasColumnType("datetime");

            entity.HasOne(d => d.Attraction).WithMany(p => p.AttractionLists)
                .HasForeignKey(d => d.AttractionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_attraction_list_attraction");

            entity.HasOne(d => d.TripList).WithMany(p => p.AttractionLists)
                .HasForeignKey(d => d.TripListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttractionList_TripList");
        });

        modelBuilder.Entity<AttractionListProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_attraction_list_product");

            entity.ToTable("AttractionListProduct");

            entity.HasOne(d => d.AttractionList).WithMany(p => p.AttractionListProducts)
                .HasForeignKey(d => d.AttractionListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttractionListProduct_AttractionList");

            entity.HasOne(d => d.Product).WithMany(p => p.AttractionListProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttractionListProduct_Product");

            entity.HasOne(d => d.Status).WithMany(p => p.AttractionListProducts)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_AttractionListProduct_StatusProduct");
        });

        modelBuilder.Entity<AttractionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_attraction_type");

            entity.ToTable("Attraction_type");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_comment");

            entity.ToTable("Comment");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Desc).HasMaxLength(250);

            entity.HasOne(d => d.Attraction).WithMany(p => p.Comments)
                .HasForeignKey(d => d.AttractionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_Attraction");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_User");
        });

        modelBuilder.Entity<Continent>(entity =>
        {
            entity.ToTable("Continent");

            entity.Property(e => e.Name).HasMaxLength(15);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Name).HasMaxLength(20);

            entity.HasOne(d => d.Continent).WithMany(p => p.Countries)
                .HasForeignKey(d => d.ContinentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Country_Continent");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_like");

            entity.ToTable("Like");

            entity.HasOne(d => d.Attraction).WithMany(p => p.Likes)
                .HasForeignKey(d => d.AttractionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Like_Attraction");

            entity.HasOne(d => d.AttractionList).WithMany(p => p.Likes)
                .HasForeignKey(d => d.AttractionListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Like_AttractionList");
        });

        modelBuilder.Entity<OpeningHour>(entity =>
        {
            entity.Property(e => e.ClosingHour).HasColumnType("datetime");
            entity.Property(e => e.OpeningHour1)
                .HasColumnType("datetime")
                .HasColumnName("OpeningHour");

            entity.HasOne(d => d.Attraction).WithMany(p => p.OpeningHours)
                .HasForeignKey(d => d.AttractionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpeningHours_Attraction1");
        });

        modelBuilder.Entity<PersonState>(entity =>
        {
            entity.ToTable("PersonState");

            entity.Property(e => e.State).HasMaxLength(15);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Product_1");

            entity.ToTable("Product");

            entity.Property(e => e.Img).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.ProductType).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_product_product_type");

            entity.HasOne(d => d.StorageType).WithMany(p => p.Products)
                .HasForeignKey(d => d.StorageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_product_storage_type");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_product_type");

            entity.ToTable("ProductType");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Request");

            entity.Property(e => e.AttractionName).HasMaxLength(30);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Address).WithMany()
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Address");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_User");
        });

        modelBuilder.Entity<SavedAttraction>(entity =>
        {
            entity.ToTable("SavedAttraction");

            entity.HasOne(d => d.Attraction).WithMany(p => p.SavedAttractions)
                .HasForeignKey(d => d.AttractionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavedAttraction_Attraction");

            entity.HasOne(d => d.User).WithMany(p => p.SavedAttractions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavedAttraction_User");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Status");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status1)
                .HasMaxLength(10)
                .HasColumnName("Status");
        });

        modelBuilder.Entity<StatusProduct>(entity =>
        {
            entity.ToTable("StatusProduct");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<StorageType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_storage_type");

            entity.ToTable("StorageType");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TripList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_destination_country");

            entity.ToTable("TripList");

            entity.Property(e => e.AddingDate).HasColumnType("datetime");
            entity.Property(e => e.BackingDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TravelingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_customer");

            entity.ToTable("User");

            entity.Property(e => e.DateBorn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.UserType).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_user_type");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_user_type");

            entity.ToTable("UserType");

            entity.HasIndex(e => e.Id, "IX_user_type");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
