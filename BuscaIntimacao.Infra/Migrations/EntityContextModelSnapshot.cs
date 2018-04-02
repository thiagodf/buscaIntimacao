﻿// <auto-generated />
using BuscaIntimacao.Domain.Enums;
using BuscaIntimacao.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BuscaIntimacao.Infra.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Cartorio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("Codigo");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Cartorio");
                });

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Devedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Devedor");
                });

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Intimacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Ativa")
                        .HasColumnName("Ativa")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CartorioId");

                    b.Property<string>("Codigo")
                        .HasColumnName("Codigo")
                        .HasColumnType("Varchar(8)");

                    b.Property<Guid?>("DevedorId");

                    b.HasKey("Id");

                    b.HasIndex("CartorioId");

                    b.HasIndex("DevedorId");

                    b.ToTable("Intimacao");
                });

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Cartorio", b =>
                {
                    b.OwnsOne("BuscaIntimacao.Domain.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("CartorioId");

                            b1.Property<string>("Bairro")
                                .HasColumnName("Bairro")
                                .HasColumnType("varchar(50)");

                            b1.Property<string>("Cep")
                                .HasColumnName("Cep")
                                .HasColumnType("varchar(10)");

                            b1.Property<string>("Cidade")
                                .HasColumnName("Cidade")
                                .HasColumnType("varchar(50)");

                            b1.Property<int>("Estado")
                                .HasColumnName("Estado")
                                .HasColumnType("int");

                            b1.Property<string>("Logradouro")
                                .HasColumnName("Endereco")
                                .HasColumnType("varchar(100)");

                            b1.Property<int>("Numero")
                                .HasColumnName("Numero")
                                .HasColumnType("int");

                            b1.ToTable("Cartorio");

                            b1.HasOne("BuscaIntimacao.Domain.Entities.Cartorio")
                                .WithOne("Endereco")
                                .HasForeignKey("BuscaIntimacao.Domain.ValueObjects.Endereco", "CartorioId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Devedor", b =>
                {
                    b.OwnsOne("BuscaIntimacao.Domain.ValueObjects.Documento", "Documento", b1 =>
                        {
                            b1.Property<Guid>("DevedorId");

                            b1.Property<string>("Numero")
                                .HasColumnName("Numero")
                                .HasColumnType("varchar(50)");

                            b1.Property<int>("Tipo")
                                .HasColumnName("Tipo")
                                .HasColumnType("int");

                            b1.ToTable("Devedor");

                            b1.HasOne("BuscaIntimacao.Domain.Entities.Devedor")
                                .WithOne("Documento")
                                .HasForeignKey("BuscaIntimacao.Domain.ValueObjects.Documento", "DevedorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BuscaIntimacao.Domain.Entities.Intimacao", b =>
                {
                    b.HasOne("BuscaIntimacao.Domain.Entities.Cartorio", "Cartorio")
                        .WithMany()
                        .HasForeignKey("CartorioId");

                    b.HasOne("BuscaIntimacao.Domain.Entities.Devedor", "Devedor")
                        .WithMany()
                        .HasForeignKey("DevedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
