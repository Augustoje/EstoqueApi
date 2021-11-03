﻿// <auto-generated />
using System;
using EstoqueApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EstoqueApi.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    [Migration("20211103045439_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("EstoqueApi.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nomeCategoria")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("EstoqueApi.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<bool>("ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("imagem")
                        .HasColumnType("longtext");

                    b.Property<string>("modelo")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<double>("preco")
                        .HasColumnType("double");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<string>("tamanho")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("EstoqueApi.Models.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoID")
                        .HasColumnType("int");

                    b.Property<string>("data")
                        .HasColumnType("longtext");

                    b.Property<double>("precoUnitario")
                        .HasColumnType("double");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<double>("total")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("EstoqueApi.Models.Produto", b =>
                {
                    b.HasOne("EstoqueApi.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("EstoqueApi.Models.Venda", b =>
                {
                    b.HasOne("EstoqueApi.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
