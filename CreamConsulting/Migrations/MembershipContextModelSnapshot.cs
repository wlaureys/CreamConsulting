﻿// <auto-generated />
using System;
using CreamConsulting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreamConsulting.Migrations
{
    [DbContext(typeof(MembershipContext))]
    partial class MembershipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreamConsulting.Models.IdentityCard", b =>
                {
                    b.Property<int>("IdentityCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("IdentityCardId");

                    b.ToTable("IdentityCards");
                });

            modelBuilder.Entity("CreamConsulting.Models.IdentityCardMember", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("IdentityCardId")
                        .HasColumnType("int");

                    b.HasKey("MemberId", "IdentityCardId");

                    b.ToTable("IdentityCardMembers");
                });

            modelBuilder.Entity("CreamConsulting.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BlackListeduntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emailaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBlackListed")
                        .HasColumnType("bit");

                    b.Property<string>("MemberCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
