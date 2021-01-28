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
    [Migration("20210128151408_Sobre")]
    partial class Sobre
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

            modelBuilder.Entity("SitePessoalMasMelhor.Models.FormAcademica", b =>
                {
                    b.Property<int>("FormAcademicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataDeConclusão")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duração")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instituição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormAcademicaId");

                    b.ToTable("FormAcademica");
                });
#pragma warning restore 612, 618
        }
    }
}
