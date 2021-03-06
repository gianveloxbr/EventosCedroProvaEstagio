﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Eventos.DAL;
using System;

namespace Eventos.DAL.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("201803031095952_AdicionandoTabelaParticipante")]
    partial class AdicionandoTabelaParticipante
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Eventos.DAL.Models.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeParticipante")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.HasKey("IdEvento");

                    b.ToTable("Participante");
                });
#pragma warning restore 612, 618
        }
    }
}
