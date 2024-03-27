﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MMSalgados.Data;

namespace MMSalgados.Infra.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221028210749_pedido_e_item_pedido")]
    partial class pedido_e_item_pedido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OfertaFone.Domain.Entities.Acesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Acesso");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemPedido");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.MapPerfilUsuariosAcessos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcessoId")
                        .HasColumnType("int");

                    b.Property<int?>("PerfilUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcessoId");

                    b.HasIndex("PerfilUsuarioId");

                    b.ToTable("MapPerfilUsuariosAcessos");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuantidadeItens")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.PerfilUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PerfilUsuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "ADMIN",
                            Situacao = 1
                        });
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Camera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ProdutoEntity");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfCnpj")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerfilUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Situacao")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfilUsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@devscansados.com",
                            Image = "https://s.gravatar.com/avatar/aleatory?d=mm&s=45",
                            Login = "admin",
                            Nome = "admin",
                            PerfilUsuarioId = 1,
                            Senha = "admin@123",
                            Situacao = 1
                        });
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.ItemPedido", b =>
                {
                    b.HasOne("OfertaFone.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItemPedido")
                        .HasForeignKey("PedidoId");

                    b.HasOne("OfertaFone.Domain.Entities.ProdutoEntity", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.MapPerfilUsuariosAcessos", b =>
                {
                    b.HasOne("OfertaFone.Domain.Entities.Acesso", "Acesso")
                        .WithMany("MapPerfilUsuariosAcessos")
                        .HasForeignKey("AcessoId");

                    b.HasOne("OfertaFone.Domain.Entities.PerfilUsuario", "PerfilUsuario")
                        .WithMany("MapPerfilUsuariosAcessos")
                        .HasForeignKey("PerfilUsuarioId");

                    b.Navigation("Acesso");

                    b.Navigation("PerfilUsuario");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("OfertaFone.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Pedido")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.ProdutoEntity", b =>
                {
                    b.HasOne("OfertaFone.Domain.Entities.Usuario", "Usuario")
                        .WithMany("ProdutoEntity")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("OfertaFone.Domain.Entities.PerfilUsuario", "PerfilUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilUsuarioId");

                    b.Navigation("PerfilUsuario");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Acesso", b =>
                {
                    b.Navigation("MapPerfilUsuariosAcessos");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("ItemPedido");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.PerfilUsuario", b =>
                {
                    b.Navigation("MapPerfilUsuariosAcessos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("OfertaFone.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Pedido");

                    b.Navigation("ProdutoEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
