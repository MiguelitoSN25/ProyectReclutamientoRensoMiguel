using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class FacturasAppContext : DbContext
    {
        public FacturasAppContext()
        {
        }

        public FacturasAppContext(DbContextOptions<FacturasAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Ciudad> Ciudads { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Detalle> Detalles { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-EQ7C77KT;Initial Catalog=FacturasApp;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A1039977C39");

                entity.Property(e => e.IdCategoria).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PK__Ciudad__D4D3CCB0E088C616");

                entity.ToTable("Ciudad");

                entity.Property(e => e.IdCiudad).ValueGeneratedNever();

                entity.Property(e => e.NombreCiudad)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__D59466420D466F59");

                entity.Property(e => e.IdCliente).ValueGeneratedNever();

                entity.Property(e => e.Correo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fotografia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rnc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RNC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CiudadNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Ciudad)
                    .HasConstraintName("FK__Clientes__Ciudad__32E0915F");

                entity.HasOne(d => d.ProvinciaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Provincia)
                    .HasConstraintName("FK__Clientes__Provin__33D4B598");

                entity.HasOne(d => d.SectorNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Sector)
                    .HasConstraintName("FK__Clientes__Sector__31EC6D26");
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("Detalle");

                entity.Property(e => e.IdDetalle).ValueGeneratedNever();

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.IdFacturasNavigation)
                    .WithMany(p => p.Detalles)
                    .HasForeignKey(d => d.IdFacturas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Facturas");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFacturas)
                    .HasName("PK__Facturas__3FEF77DE9F0495E9");

                entity.Property(e => e.IdFacturas).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.Idcliente)
                    .HasConstraintName("FK__Facturas__Idclie__36B12243");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("PK__Provinci__EED74455177D1FF5");

                entity.Property(e => e.IdProvincia).ValueGeneratedNever();

                entity.Property(e => e.NombreProvincia)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.IdSector)
                    .HasName("PK__Sector__D0011C181A480A06");

                entity.ToTable("Sector");

                entity.Property(e => e.IdSector).ValueGeneratedNever();

                entity.Property(e => e.NombreSector)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__2DCCF9A21BCE9E46");

                entity.Property(e => e.IdServicio).ValueGeneratedNever();

                entity.Property(e => e.NombreServicio)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK__Servicios__Categ__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
