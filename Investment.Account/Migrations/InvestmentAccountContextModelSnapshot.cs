﻿// <auto-generated />
using Investment.Account.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Investment.Account.Migrations
{
    [DbContext(typeof(InvestmentAccountContext))]
    partial class InvestmentAccountContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Investment.Account.Models.InvestmentAccountEntry", b =>
                {
                    b.Property<string>("InvestmentEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestmentAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PricePrShare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestmentEntryId");

                    b.ToTable("InvestmentaccountEntry");
                });

            modelBuilder.Entity("Investment.Account.Models.InvestmentAccountFacility", b =>
                {
                    b.Property<string>("InvestmentAccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentPositionHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestmentAccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductInstanceReference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestmentAccountNumber");

                    b.ToTable("Investmentaccount");
                });
#pragma warning restore 612, 618
        }
    }
}