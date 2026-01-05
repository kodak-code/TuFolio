using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BE;

namespace DAL.DBContext;

public partial class TufolioContext : DbContext
{
    public TufolioContext()
    {
    }

    public TufolioContext(DbContextOptions<TufolioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth> Auths { get; set; }

    public virtual DbSet<Educacion> Educacions { get; set; }

    public virtual DbSet<ExperienciaLaboral> ExperienciaLaborals { get; set; }

    public virtual DbSet<Media> Media { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<ProyectoMedia> ProyectoMedia { get; set; }

    public virtual DbSet<ProyectoTecnologia> ProyectoTecnologia { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<SubDivision> SubDivisions { get; set; }

    public virtual DbSet<Tecnologia> Tecnologia { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioRol> UsuarioRols { get; set; }

    public virtual DbSet<UsuarioTecnologia> UsuarioTecnologia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Auth__3214EC07DF65C342");

            entity.ToTable("Auth");

            entity.HasIndex(e => new { e.Proveedor, e.ProveedorUsuarioId }, "IX_Auth_Proveedor");

            entity.HasIndex(e => e.UsuarioId, "IX_Auth_UsuarioId").IsUnique();

            entity.Property(e => e.BloqueoHasta).HasColumnType("datetime");
            entity.Property(e => e.Proveedor).HasMaxLength(50);
            entity.Property(e => e.ProveedorUsuarioId).HasMaxLength(200);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Auth)
                .HasForeignKey<Auth>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Auth_Usuario");
        });

        modelBuilder.Entity<Educacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Educacio__3214EC07D626E495");

            entity.ToTable("Educacion");

            entity.HasIndex(e => e.PerfilId, "IX_Educacion_PerfilId");

            entity.Property(e => e.Institucion).HasMaxLength(200);
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.Perfil).WithMany(p => p.Educacions)
                .HasForeignKey(d => d.PerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Educacion_Perfil");
        });

        modelBuilder.Entity<ExperienciaLaboral>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Experien__3214EC07AB1E5A8E");

            entity.ToTable("ExperienciaLaboral");

            entity.HasIndex(e => e.PerfilId, "IX_Experiencia_PerfilId");

            entity.Property(e => e.Empresa).HasMaxLength(200);
            entity.Property(e => e.Puesto).HasMaxLength(150);
            entity.Property(e => e.Seniority).HasMaxLength(100);

            entity.HasOne(d => d.Perfil).WithMany(p => p.ExperienciaLaborals)
                .HasForeignKey(d => d.PerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Experiencia_Perfil");
        });

        modelBuilder.Entity<Media>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Media__3214EC0736FD9151");

            entity.Property(e => e.AltText).HasMaxLength(250);
            entity.Property(e => e.MimeType).HasMaxLength(100);
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.Url).HasMaxLength(1000);
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pais__3214EC073D16D6BE");

            entity.HasIndex(e => e.Iso2, "IX_Pais_Iso2").IsUnique();

            entity.Property(e => e.Iso2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Perfil__3214EC07BC9C4640");

            entity.ToTable("Perfil");

            entity.HasIndex(e => e.UsuarioId, "IX_Perfil_UsuarioId").IsUnique();

            entity.Property(e => e.AvatarUrl).HasMaxLength(500);
            entity.Property(e => e.NombrePublico).HasMaxLength(150);
            entity.Property(e => e.Titulo).HasMaxLength(150);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Perfil)
                .HasForeignKey<Perfil>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Perfil_Usuario");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permiso__3214EC0756CCB3CD");

            entity.ToTable("Permiso");

            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Portfoli__3214EC0705253B33");

            entity.ToTable("Portfolio");

            entity.HasIndex(e => e.PerfilId, "IX_Portfolio_PerfilId");

            entity.HasIndex(e => new { e.PerfilId, e.SlugPublico }, "IX_Portfolio_Slug").IsUnique();

            entity.Property(e => e.SlugPublico).HasMaxLength(150);
            entity.Property(e => e.Visibilidad).HasMaxLength(50);

            entity.HasOne(d => d.Perfil).WithMany(p => p.Portfolios)
                .HasForeignKey(d => d.PerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Portfolio_Perfil");
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proyecto__3214EC07AB1736B4");

            entity.ToTable("Proyecto");

            entity.HasIndex(e => e.Nombre, "IX_Proyecto_Nombre");

            entity.HasIndex(e => e.PortfolioId, "IX_Proyecto_PortfolioId");

            entity.Property(e => e.DescripcionCorta).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UrlDemo).HasMaxLength(500);
            entity.Property(e => e.UrlLive).HasMaxLength(500);
            entity.Property(e => e.UrlRepo).HasMaxLength(500);

            entity.HasOne(d => d.Portfolio).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.PortfolioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proyecto_Portfolio");
        });

        modelBuilder.Entity<ProyectoMedia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proyecto__3214EC0744CA4372");

            entity.HasIndex(e => e.ProyectoId, "IX_ProyectoMedia_ProyectoId");

            entity.Property(e => e.Proposito).HasMaxLength(100);

            entity.HasOne(d => d.Media).WithMany(p => p.ProyectoMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProyectoMedia_Media");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.ProyectoMedia)
                .HasForeignKey(d => d.ProyectoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProyectoMedia_Proyecto");
        });

        modelBuilder.Entity<ProyectoTecnologia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proyecto__3214EC073A5A5A6A");

            entity.HasIndex(e => new { e.ProyectoId, e.TecnologiaId }, "UQ_PT").IsUnique();

            entity.Property(e => e.Nota).HasMaxLength(200);

            entity.HasOne(d => d.Proyecto).WithMany(p => p.ProyectoTecnologia)
                .HasForeignKey(d => d.ProyectoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PT_Proyecto");

            entity.HasOne(d => d.Tecnologia).WithMany(p => p.ProyectoTecnologia)
                .HasForeignKey(d => d.TecnologiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PT_Tecnologia");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC0784B82A27");

            entity.ToTable("Rol");

            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<SubDivision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubDivis__3214EC07E8C85D2A");

            entity.ToTable("SubDivision");

            entity.HasIndex(e => e.PaisId, "IX_SubDivision_PaisId");

            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Pais).WithMany(p => p.SubDivisions)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubDivision_Pais");
        });

        modelBuilder.Entity<Tecnologia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tecnolog__3214EC07AA58CB39");

            entity.HasIndex(e => e.Nombre, "IX_Tecnologia_Nombre").IsUnique();

            entity.Property(e => e.Categoria).HasMaxLength(100);
            entity.Property(e => e.IconoUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Slug).HasMaxLength(150);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07A88200C5");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.SubDivision, "IX_Usuario_SubDivision");

            entity.HasIndex(e => e.Gmail, "UQ_Usuario_Gmail").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Gmail).HasMaxLength(256);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.SubDivisionNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.SubDivision)
                .HasConstraintName("FK_Usuario_SubDivision");
        });

        modelBuilder.Entity<UsuarioRol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsuarioR__3214EC0751C317C7");

            entity.ToTable("UsuarioRol");

            entity.HasIndex(e => new { e.RolId, e.UsuarioId }, "UQ_UsuarioRol").IsUnique();

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Rol");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Usuario");
        });

        modelBuilder.Entity<UsuarioTecnologia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsuarioT__3214EC07DF96E52F");

            entity.HasIndex(e => new { e.UsuarioId, e.TecnologiaId }, "UQ_UsuarioTecnologia").IsUnique();

            entity.Property(e => e.CertUrl).HasMaxLength(500);

            entity.HasOne(d => d.Tecnologia).WithMany(p => p.UsuarioTecnologia)
                .HasForeignKey(d => d.TecnologiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UT_Tecnologia");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioTecnologia)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UT_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
