﻿// <auto-generated />
using System;
using AGS.ERP.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AGS.ERP.Infra.Data.Migrations
{
    [DbContext(typeof(AgsErpContext))]
    [Migration("20180828002056_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Geografia.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("Char(2)")
                        .HasMaxLength(2);

                    b.HasKey("CidadeId");

                    b.HasIndex("UF");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Geografia.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("CidadeId");

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TipoEndereco");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("Char(2)")
                        .HasMaxLength(2);

                    b.HasKey("EnderecoId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("UF");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Geografia.Estado", b =>
                {
                    b.Property<string>("UF")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UF");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.UnidadeMedida", b =>
                {
                    b.Property<string>("UnidadeMedidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UnidadeMedidaId");

                    b.ToTable("Unidade_Medida");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.UnidadeMedidaProduto", b =>
                {
                    b.Property<int>("ProdutoId");

                    b.Property<string>("UnidadeMedidaId")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3);

                    b.Property<decimal>("PesoFator")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1m);

                    b.HasKey("ProdutoId", "UnidadeMedidaId", "PesoFator");

                    b.HasIndex("UnidadeMedidaId");

                    b.ToTable("Unidade_Medida_Produto");
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Geografia.Cidade", b =>
                {
                    b.HasOne("AGS.ERP.Domain.Entities.Geografia.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("UF")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.Geografia.Endereco", b =>
                {
                    b.HasOne("AGS.ERP.Domain.Entities.Geografia.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AGS.ERP.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Endereco")
                        .HasForeignKey("ClienteId");

                    b.HasOne("AGS.ERP.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Endereco")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("AGS.ERP.Domain.Entities.Geografia.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("UF")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AGS.ERP.Domain.Entities.UnidadeMedidaProduto", b =>
                {
                    b.HasOne("AGS.ERP.Domain.Entities.Produto", "Produto")
                        .WithMany("UnidadesMedida")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AGS.ERP.Domain.Entities.UnidadeMedida", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeMedidaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}