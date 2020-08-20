﻿// <auto-generated />
using System;
using GIWEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GIWEB.Migrations
{
    [DbContext(typeof(GIWEBContext))]
    partial class GIWEBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GIWEB.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Commission");

                    b.Property<DateTime>("DateIni");

                    b.Property<DateTime>("DateTer");

                    b.Property<double>("PercCommission");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("GIWEB.Models.Guarantor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cel");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Employer");

                    b.Property<string>("Name");

                    b.Property<string>("Profession");

                    b.Property<string>("Rg");

                    b.Property<string>("Tel");

                    b.Property<string>("TelEmployer");

                    b.HasKey("Id");

                    b.ToTable("Guarantor");
                });

            modelBuilder.Entity("GIWEB.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cel");

                    b.Property<int?>("ContractId");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("PropertieId");

                    b.Property<string>("Rg");

                    b.Property<string>("Tel");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("PropertieId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("GIWEB.Models.Plots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatePlots");

                    b.Property<double>("PlotsValue");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Plots");
                });

            modelBuilder.Entity("GIWEB.Models.Propertie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("Num");

                    b.Property<double>("RentValue");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Propertie");
                });

            modelBuilder.Entity("GIWEB.Models.Spouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cel");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Employer");

                    b.Property<string>("Name");

                    b.Property<string>("Profession");

                    b.Property<string>("Rg");

                    b.Property<string>("Tel");

                    b.Property<string>("TelEmployer");

                    b.HasKey("Id");

                    b.ToTable("Spouse");
                });

            modelBuilder.Entity("GIWEB.Models.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cel");

                    b.Property<int?>("ContractId");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Employer");

                    b.Property<string>("Name");

                    b.Property<string>("Profession");

                    b.Property<string>("Rg");

                    b.Property<string>("Tel");

                    b.Property<string>("TelEmployer");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("GIWEB.Models.Owner", b =>
                {
                    b.HasOne("GIWEB.Models.Contract")
                        .WithMany("Owner")
                        .HasForeignKey("ContractId");

                    b.HasOne("GIWEB.Models.Propertie")
                        .WithMany("Owner")
                        .HasForeignKey("PropertieId");
                });

            modelBuilder.Entity("GIWEB.Models.Tenant", b =>
                {
                    b.HasOne("GIWEB.Models.Contract")
                        .WithMany("Tenant")
                        .HasForeignKey("ContractId");
                });
#pragma warning restore 612, 618
        }
    }
}
