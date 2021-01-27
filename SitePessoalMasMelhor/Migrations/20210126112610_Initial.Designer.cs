﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SitePessoalMasMelhor.Data;

namespace SitePessoalMasMelhor.Migrations
{
    [DbContext(typeof(SitePessoalBdContext))]
    [Migration("20210126112610_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SitePessoalMasMelhor.Models.ExpProfissional", b =>
                {
                    b.Property<int>("ExpProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detalhes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpProfissionalId");

                    b.ToTable("ExpProfissional");
                });
#pragma warning restore 612, 618
        }
    }
}