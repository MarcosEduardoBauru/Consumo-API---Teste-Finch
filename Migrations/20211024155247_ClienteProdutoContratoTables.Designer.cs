﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace concilig.Migrations
{
    [DbContext(typeof(DefaultConnection))]
    [Migration("20211024155247_ClienteProdutoContratoTables")]
    partial class ClienteProdutoContratoTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("concilig.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("concilig.Models.Contrato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("Produtoid")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Clienteid");

                    b.HasIndex("Produtoid");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("concilig.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("concilig.Models.Contrato", b =>
                {
                    b.HasOne("concilig.Models.Cliente", "Cliente")
                        .WithMany("Contratos")
                        .HasForeignKey("Clienteid");

                    b.HasOne("concilig.Models.Produto", "Produto")
                        .WithMany("Contratos")
                        .HasForeignKey("Produtoid");

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("concilig.Models.Cliente", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("concilig.Models.Produto", b =>
                {
                    b.Navigation("Contratos");
                });
#pragma warning restore 612, 618
        }
    }
}