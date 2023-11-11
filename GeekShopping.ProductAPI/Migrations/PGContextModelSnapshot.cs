﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(PGContext))]
    partial class PGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("NomeCategoria");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("Descricao");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("UrlImagem");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Nome");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
