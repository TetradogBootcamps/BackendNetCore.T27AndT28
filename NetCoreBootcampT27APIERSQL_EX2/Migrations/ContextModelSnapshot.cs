﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreBootcampT27APIERSQL_EX2;

namespace NetCoreBootcampT27APIERSQL_EX2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX2.Models.AsignadoA", b =>
                {
                    b.Property<string>("CientificoId")
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Cientifico");

                    b.Property<string>("ProyectoId")
                        .HasColumnType("varchar(4)")
                        .HasColumnName("Proyecto");

                    b.HasKey("CientificoId", "ProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Asignados");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX2.Models.Cientifico", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("DNI");

                    b.Property<string>("NombreCompleto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("NomApels");

                    b.HasKey("Id");

                    b.ToTable("Cientificos");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX2.Models.Proyecto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX2.Models.AsignadoA", b =>
                {
                    b.HasOne("NetCoreBootcampT27APIERSQL_EX2.Models.Cientifico", "Cientifico")
                        .WithMany()
                        .HasForeignKey("CientificoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetCoreBootcampT27APIERSQL_EX2.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cientifico");

                    b.Navigation("Proyecto");
                });
#pragma warning restore 612, 618
        }
    }
}
