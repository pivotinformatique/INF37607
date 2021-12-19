﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TDRSolutionFrontEnd.Infrastructure;

#nullable disable

namespace TDRSolutionFrontEnd.Infrastructure.Migrations
{
    [DbContext(typeof(TDRSolutionFrontEndContext))]
    [Migration("20211215005925_RenameUserColumns")]
    partial class RenameUserColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TDRSolutionFrontEnd.Core.Entities.AvisCotisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("MontantDu")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("AvisCotisation");
                });

            modelBuilder.Entity("TDRSolutionFrontEnd.Core.Entities.DeclarationRevenus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Annee")
                        .HasColumnType("datetime2");

                    b.Property<int>("AvisCotisationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReception")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubmitted")
                        .HasColumnType("bit");

                    b.Property<decimal>("RevenusAutre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RevenusEmploi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvisCotisationId");

                    b.HasIndex("UsagerId");

                    b.ToTable("DeclarationRevenus");
                });

            modelBuilder.Entity("TDRSolutionFrontEnd.Core.Entities.Usager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Citoyennete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephonePrincipal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneSecondaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usagers");
                });

            modelBuilder.Entity("TDRSolutionFrontEnd.Core.Entities.DeclarationRevenus", b =>
                {
                    b.HasOne("TDRSolutionFrontEnd.Core.Entities.AvisCotisation", "AvisCotisation")
                        .WithMany()
                        .HasForeignKey("AvisCotisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TDRSolutionFrontEnd.Core.Entities.Usager", "Usager")
                        .WithMany()
                        .HasForeignKey("UsagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvisCotisation");

                    b.Navigation("Usager");
                });
#pragma warning restore 612, 618
        }
    }
}
