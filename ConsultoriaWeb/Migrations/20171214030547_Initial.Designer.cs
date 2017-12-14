﻿// <auto-generated />
using ConsultoriaWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ConsultoriaWeb.Migrations
{
    [DbContext(typeof(ConsultoriaWebContext))]
    [Migration("20171214030547_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsultoriaWeb.Data.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("celular");

                    b.Property<bool>("certPime");

                    b.Property<string>("ciudad");

                    b.Property<string>("claveFiscal");

                    b.Property<string>("contacto");

                    b.Property<string>("correo");

                    b.Property<int>("cuit");

                    b.Property<string>("domicilio");

                    b.Property<int>("idReferente");

                    b.Property<string>("provincia");

                    b.Property<string>("razonSocial");

                    b.Property<int>("registroAfip");

                    b.Property<long>("telefono");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
