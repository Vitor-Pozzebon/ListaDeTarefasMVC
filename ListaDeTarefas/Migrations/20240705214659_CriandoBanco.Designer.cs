﻿// <auto-generated />
using System;
using ListaDeTarefas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListaDeTarefas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240705214659_CriandoBanco")]
    partial class CriandoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ListaDeTarefas.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "trabalho",
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "casa",
                            Nome = "Casa"
                        },
                        new
                        {
                            CategoriaId = "faculdade",
                            Nome = "Faculdade"
                        },
                        new
                        {
                            CategoriaId = "compras",
                            Nome = "Compras"
                        },
                        new
                        {
                            CategoriaId = "academia",
                            Nome = "Academia"
                        });
                });

            modelBuilder.Entity("ListaDeTarefas.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "aberto",
                            Nome = "Aberto"
                        },
                        new
                        {
                            StatusId = "completo",
                            Nome = "Completo"
                        });
                });

            modelBuilder.Entity("ListaDeTarefas.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("DataDeVencimento")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("ListaDeTarefas.Models.Tarefa", b =>
                {
                    b.HasOne("ListaDeTarefas.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ListaDeTarefas.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
