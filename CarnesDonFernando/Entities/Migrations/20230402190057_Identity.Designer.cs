﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(proyectoCarnesDonFernandoContext))]
    [Migration("20230402190057_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entities.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre");

                    b.HasKey("IdCategoria")
                        .HasName("PK__categori__CD54BC5A3263D0CB");

                    b.ToTable("categorias", (string)null);
                });

            modelBuilder.Entity("Entities.DetalleOrden", b =>
                {
                    b.Property<int>("IdOrden")
                        .HasColumnType("int")
                        .HasColumnName("id_orden");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("id_producto");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float")
                        .HasColumnName("subtotal");

                    b.Property<double>("Total")
                        .HasColumnType("float")
                        .HasColumnName("total");

                    b.HasKey("IdOrden")
                        .HasName("PK__detalle___DD5B8F3393E29917");

                    b.HasIndex("IdProducto");

                    b.ToTable("detalle_orden", (string)null);
                });

            modelBuilder.Entity("Entities.Ingrediente", b =>
                {
                    b.Property<int>("IdIngrediente")
                        .HasColumnType("int")
                        .HasColumnName("id_ingrediente");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdReceta")
                        .HasColumnType("int")
                        .HasColumnName("id_receta");

                    b.HasKey("IdIngrediente")
                        .HasName("PK__ingredie__3F505D45F0A42F31");

                    b.ToTable("ingrediente", (string)null);
                });

            modelBuilder.Entity("Entities.Local", b =>
                {
                    b.Property<int>("IdLocal")
                        .HasColumnType("int")
                        .HasColumnName("id_local");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("horario");

                    b.Property<string>("NombreLocal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_local");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ubicacion");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("urlImg");

                    b.HasKey("IdLocal")
                        .HasName("PK__local__1ECD0210ED864362");

                    b.ToTable("local", (string)null);
                });

            modelBuilder.Entity("Entities.MensajesContacto", b =>
                {
                    b.Property<int>("IdMensaje")
                        .HasColumnType("int")
                        .HasColumnName("id_mensaje");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<int>("IdLocal")
                        .HasColumnType("int")
                        .HasColumnName("id_local");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("mensaje");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_persona");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("telefono");

                    b.HasKey("IdMensaje")
                        .HasName("PK__mensajes__5B37C7F649F28021");

                    b.HasIndex("IdLocal");

                    b.ToTable("mensajes_contacto", (string)null);
                });

            modelBuilder.Entity("Entities.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("id_producto");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<string>("DescripcionProductoCorta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcionProductoCorta");

                    b.Property<string>("DescripcionProductoLarga")
                        .IsRequired()
                        .HasMaxLength(800)
                        .IsUnicode(false)
                        .HasColumnType("varchar(800)")
                        .HasColumnName("descripcionProductoLarga");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre");

                    b.Property<int>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("urlImg");

                    b.HasKey("IdProducto")
                        .HasName("PK__producto__FF341C0D20D0D1A4");

                    b.HasIndex("IdCategoria");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Entities.Receta", b =>
                {
                    b.Property<int>("IdReceta")
                        .HasColumnType("int")
                        .HasColumnName("id_receta");

                    b.Property<string>("DescripcionReceta")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descripcion_receta");

                    b.Property<int>("IdIngrediente")
                        .HasColumnType("int")
                        .HasColumnName("id_ingrediente");

                    b.Property<string>("NombreReceta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_receta");

                    b.HasKey("IdReceta")
                        .HasName("PK__recetas__11DB53ABE76163D9");

                    b.HasIndex("IdIngrediente");

                    b.ToTable("recetas", (string)null);
                });

            modelBuilder.Entity("Entities.Restaurante", b =>
                {
                    b.Property<int>("IdRestaurante")
                        .HasColumnType("int")
                        .HasColumnName("id_restaurante");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("horario");

                    b.Property<string>("NombreRestaurante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_restaurante");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ubicacion");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("urlImg");

                    b.HasKey("IdRestaurante")
                        .HasName("PK__restaura__5C186E3F2E0D57C9");

                    b.ToTable("restaurante", (string)null);
                });

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("contrasenia");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_usuario");

                    b.HasKey("IdUsuario")
                        .HasName("PK__usuarios__4E3E04AD21DD8887");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.DetalleOrden", b =>
                {
                    b.HasOne("Entities.Producto", "IdProductoNavigation")
                        .WithMany("DetalleOrdens")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK__detalle_o__id_pr__29572725");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("Entities.MensajesContacto", b =>
                {
                    b.HasOne("Entities.Local", "IdLocalNavigation")
                        .WithMany("MensajesContactos")
                        .HasForeignKey("IdLocal")
                        .IsRequired()
                        .HasConstraintName("FK__mensajes___id_lo__31EC6D26");

                    b.Navigation("IdLocalNavigation");
                });

            modelBuilder.Entity("Entities.Producto", b =>
                {
                    b.HasOne("Entities.Categoria", "IdCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK__producto__id_cat__267ABA7A");

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("Entities.Receta", b =>
                {
                    b.HasOne("Entities.Ingrediente", "IdIngredienteNavigation")
                        .WithMany("Receta")
                        .HasForeignKey("IdIngrediente")
                        .IsRequired()
                        .HasConstraintName("FK__recetas__id_ingr__36B12243");

                    b.Navigation("IdIngredienteNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Entities.Ingrediente", b =>
                {
                    b.Navigation("Receta");
                });

            modelBuilder.Entity("Entities.Local", b =>
                {
                    b.Navigation("MensajesContactos");
                });

            modelBuilder.Entity("Entities.Producto", b =>
                {
                    b.Navigation("DetalleOrdens");
                });
#pragma warning restore 612, 618
        }
    }
}
