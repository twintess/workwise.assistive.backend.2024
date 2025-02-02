﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workwise.assistive.backend;

#nullable disable

namespace workwise.assistive.backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002205524_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "953a8367-49e8-4afb-a03a-5605b54bf6da",
                            Name = "new-account-request-reader",
                            NormalizedName = "NEW-ACCOUNT-REQUEST-READER"
                        },
                        new
                        {
                            Id = "abb7cd0e-bc00-4367-a008-c9b0cc20a7a1",
                            Name = "new-account-request-contributor",
                            NormalizedName = "NEW-ACCOUNT-REQUEST-CONTRIBUTOR"
                        },
                        new
                        {
                            Id = "4ecd3239-23e4-4e8c-8bf7-9ae1a9c53bd6",
                            Name = "user-password-reset-operator",
                            NormalizedName = "USER-PASSWORD-RESET-OPERATOR"
                        },
                        new
                        {
                            Id = "f75dae6c-19a7-4832-8ad3-23f018fb0a37",
                            Name = "user-mfa-details-reader",
                            NormalizedName = "USER-MFA-DETAILS-READER"
                        },
                        new
                        {
                            Id = "3c602f16-26d4-4cdb-a86c-4a1f73eda974",
                            Name = "domain-reader",
                            NormalizedName = "DOMAIN-READER"
                        },
                        new
                        {
                            Id = "64cf548e-17e5-4004-944a-ea318c78566b",
                            Name = "disk-request-contributor",
                            NormalizedName = "DISK-REQUEST-CONTRIBUTOR"
                        },
                        new
                        {
                            Id = "368fac30-b44c-4053-9ca9-6694d93adf6f",
                            Name = "disk-request-reader",
                            NormalizedName = "DISK-REQUEST-READER"
                        },
                        new
                        {
                            Id = "d8a57d1a-1940-444d-8565-0e517d61669f",
                            Name = "audit-reader",
                            NormalizedName = "AUDIT-READER"
                        },
                        new
                        {
                            Id = "6b8e732c-bb57-4785-9200-e9598da9007c",
                            Name = "audit-settings-reader",
                            NormalizedName = "AUDIT-SETTINGS-READER"
                        },
                        new
                        {
                            Id = "e07e0d1a-444f-4e09-8800-fa5e4d2740eb",
                            Name = "zabbix-servers-report-reader",
                            NormalizedName = "ZABBIX-SERVERS-REPORT-READER"
                        },
                        new
                        {
                            Id = "e23a6d00-c3be-48aa-bb3d-774e868e730b",
                            Name = "zabbix-incidents-reader",
                            NormalizedName = "ZABBIX-INCIDENTS-READER"
                        },
                        new
                        {
                            Id = "d213b27e-0098-46c7-9880-85a28a372e2f",
                            Name = "zabbix-statistics-reader",
                            NormalizedName = "ZABBIX-STATISTICS-READER"
                        },
                        new
                        {
                            Id = "494fa66f-dc0f-4ea0-b369-52d0b000ee6e",
                            Name = "survey-report-reader",
                            NormalizedName = "SURVEY-REPORT-READER"
                        },
                        new
                        {
                            Id = "057fab4a-6566-45a2-ba4c-212492ea901e",
                            Name = "surver-interaction-reader",
                            NormalizedName = "SURVER-INTERACTION-READER"
                        },
                        new
                        {
                            Id = "43ea34ea-a2e6-4106-ba95-cb7f2a090bdc",
                            Name = "personalization-lockscreen-reader",
                            NormalizedName = "PERSONALIZATION-LOCKSCREEN-READER"
                        },
                        new
                        {
                            Id = "522befd6-e589-46aa-8e09-29db6fc805ba",
                            Name = "personalization-schedule-reader",
                            NormalizedName = "PERSONALIZATION-SCHEDULE-READER"
                        },
                        new
                        {
                            Id = "82263b55-a2e0-4312-a6b7-3b1a467c829f",
                            Name = "popup-window-contributor",
                            NormalizedName = "POPUP-WINDOW-CONTRIBUTOR"
                        },
                        new
                        {
                            Id = "e0352f9d-f441-4f7e-a669-773746dac1e1",
                            Name = "popup-distribution-contributor",
                            NormalizedName = "POPUP-DISTRIBUTION-CONTRIBUTOR"
                        },
                        new
                        {
                            Id = "9fef5610-603f-436c-96f8-74c302af3453",
                            Name = "popup-window-reader",
                            NormalizedName = "POPUP-WINDOW-READER"
                        },
                        new
                        {
                            Id = "36bfb857-83f5-4fe8-9302-cecf680737ff",
                            Name = "popup-distribution-reader",
                            NormalizedName = "POPUP-DISTRIBUTION-READER"
                        },
                        new
                        {
                            Id = "46c7807f-93e3-4d51-a1b8-a33181f5fe8f",
                            Name = "popup-schedule-reader",
                            NormalizedName = "POPUP-SCHEDULE-READER"
                        },
                        new
                        {
                            Id = "c4ab97da-a236-4c8c-a81a-9cc3cfd9616a",
                            Name = "portal-admin",
                            NormalizedName = "PORTAL-ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("workwise.assistive.backend.Model.PortalUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortalUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("workwise.assistive.backend.Model.PortalUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
