﻿// <auto-generated />
using System;
using GlobalGames.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlobalGames.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210121215939_InitCoun")]
    partial class InitCoun
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GlobalGames.Dados.Entidades.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("GlobalGames.Dados.Entidades.Inscricoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apelido");

                    b.Property<int>("CC");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Localidade");

                    b.Property<string>("Morada");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Inscricoes");
                });

            modelBuilder.Entity("GlobalGames.Dados.Entidades.Servicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Mensagem");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
