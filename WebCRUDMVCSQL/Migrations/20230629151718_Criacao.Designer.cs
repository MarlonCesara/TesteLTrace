﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCRUDMVCSQL.Models;

#nullable disable

namespace WebCRUDMVCSQL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230629151718_Criacao")]
    partial class Criacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebCRUDMVCSQL.Models.Dados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DadosSismicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Dados_Sismicos");

                    b.Property<string>("DadosSismicosPadrao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Dados_Sismicos_Padrao");

                    b.Property<string>("HighPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("High_Pass");

                    b.Property<string>("LowPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Low_Pass");

                    b.Property<int>("TaxaAmostragemPadrao")
                        .HasColumnType("int")
                        .HasColumnName("Taxa_Amostragem_Padrao");

                    b.HasKey("Id");

                    b.ToTable("Dados");
                });
#pragma warning restore 612, 618
        }
    }
}