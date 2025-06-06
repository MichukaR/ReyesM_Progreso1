﻿// <auto-generated />
using System;
using MichelleReyesP1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MichelleReyesP1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MichelleReyesP1.Models.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int>("edad")
                        .HasMaxLength(3)
                        .HasColumnType("integer");

                    b.Property<bool>("pregunta")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MichelleReyesP1.Models.PlanDeRecompensas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("fecha_de_inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("puntosAcumulados")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("PlanDeRecompensas");
                });

            modelBuilder.Entity("MichelleReyesP1.Models.Reserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double>("ValorAPagar")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("fecha_entrada")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fecha_salida")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("informacionCliente")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("infromacionCliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("informacionCliente");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("MichelleReyesP1.Models.Reserva", b =>
                {
                    b.HasOne("MichelleReyesP1.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("informacionCliente");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
