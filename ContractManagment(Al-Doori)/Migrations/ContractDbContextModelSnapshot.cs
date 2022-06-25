﻿// <auto-generated />
using System;
using ContractManagment_Al_Doori_.Models.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContractManagment_Al_Doori_.Migrations
{
    [DbContext(typeof(ContractDbContext))]
    partial class ContractDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Advisor", b =>
                {
                    b.Property<int>("AdvisorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvisorId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdvisorId");

                    b.ToTable("Advisor");

                    b.HasData(
                        new
                        {
                            AdvisorId = 1,
                            Age = 30,
                            Email = "Jeffrey@fe.cz",
                            Name = "Jeffrey",
                            NationalIdentificationNumber = "234Q12FWETRD",
                            PhoneNumber = "004206663442",
                            SurName = "Jeffrey1E"
                        },
                        new
                        {
                            AdvisorId = 2,
                            Age = 31,
                            Email = "Fateh@fe.cz",
                            Name = "Fateh",
                            NationalIdentificationNumber = "234W12HVSSAD",
                            PhoneNumber = "004206265432",
                            SurName = "Fateh3d"
                        },
                        new
                        {
                            AdvisorId = 3,
                            Age = 29,
                            Email = "John@fe.cz",
                            Name = "John",
                            NationalIdentificationNumber = "2344E2FADHER",
                            PhoneNumber = "004206655412",
                            SurName = "John2d"
                        },
                        new
                        {
                            AdvisorId = 4,
                            Age = 43,
                            Email = "Oisin@fe.cz",
                            Name = "Oisin",
                            NationalIdentificationNumber = "234H12FAEWRSAD",
                            PhoneNumber = "004207665492",
                            SurName = "OisinE2"
                        },
                        new
                        {
                            AdvisorId = 5,
                            Age = 48,
                            Email = "Carys@fe.cz",
                            Name = "Carys",
                            NationalIdentificationNumber = "23G412FADSRAD",
                            PhoneNumber = "004206675422",
                            SurName = "Carys2R"
                        });
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.AdvisorContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdvisorID")
                        .HasColumnType("int");

                    b.Property<int>("ContractID")
                        .HasColumnType("int");

                    b.Property<int>("isAdminstrator")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvisorID");

                    b.HasIndex("ContractID");

                    b.ToTable("AdvisorContract");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdvisorID = 1,
                            ContractID = 1,
                            isAdminstrator = 1
                        },
                        new
                        {
                            Id = 2,
                            AdvisorID = 2,
                            ContractID = 1,
                            isAdminstrator = 0
                        },
                        new
                        {
                            Id = 3,
                            AdvisorID = 4,
                            ContractID = 2,
                            isAdminstrator = 1
                        },
                        new
                        {
                            Id = 4,
                            AdvisorID = 3,
                            ContractID = 3,
                            isAdminstrator = 0
                        },
                        new
                        {
                            Id = 5,
                            AdvisorID = 1,
                            ContractID = 4,
                            isAdminstrator = 1
                        },
                        new
                        {
                            Id = 6,
                            AdvisorID = 5,
                            ContractID = 4,
                            isAdminstrator = 1
                        });
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Age = 22,
                            Email = "john@fe.cz",
                            Name = "John",
                            NationalIdentificationNumber = "234412FWETRD",
                            PhoneNumber = "004206665442",
                            SurName = "John1E"
                        },
                        new
                        {
                            ClientId = 2,
                            Age = 26,
                            Email = "alias@fe.cz",
                            Name = "Alias",
                            NationalIdentificationNumber = "234412HVSSAD",
                            PhoneNumber = "004206665432",
                            SurName = "Alias3d"
                        },
                        new
                        {
                            ClientId = 3,
                            Age = 27,
                            Email = "mack@fe.cz",
                            Name = "Mack",
                            NationalIdentificationNumber = "234412FADHER",
                            PhoneNumber = "004206665412",
                            SurName = "Mack2d"
                        },
                        new
                        {
                            ClientId = 4,
                            Age = 21,
                            Email = "nelson@fe.cz",
                            Name = "Nelson",
                            NationalIdentificationNumber = "234412FAEWRSAD",
                            PhoneNumber = "004206665492",
                            SurName = "NelsonE2"
                        },
                        new
                        {
                            ClientId = 5,
                            Age = 19,
                            Email = "malik@fe.cz",
                            Name = "Malik",
                            NationalIdentificationNumber = "234412FADSRAD",
                            PhoneNumber = "004206665422",
                            SurName = "Malik2R"
                        });
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("ConclusionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegisterationNumber")
                        .HasColumnType("int");

                    b.Property<string>("TerminationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidityDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("Contract");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientID = 1,
                            ConclusionDate = "2021/03/04",
                            Institution = "AEGON",
                            RegisterationNumber = 234,
                            TerminationDate = "2022/03/04",
                            ValidityDate = "2023/03/04"
                        },
                        new
                        {
                            Id = 2,
                            ClientID = 2,
                            ConclusionDate = "2021/03/06",
                            Institution = "CBOS",
                            RegisterationNumber = 425,
                            TerminationDate = "2022/03/06",
                            ValidityDate = "2023/03/06"
                        },
                        new
                        {
                            Id = 3,
                            ClientID = 4,
                            ConclusionDate = "2021/04/06",
                            Institution = "BLogic",
                            RegisterationNumber = 321,
                            TerminationDate = "2022/04/06",
                            ValidityDate = "2023/04/07"
                        },
                        new
                        {
                            Id = 4,
                            ClientID = 3,
                            ConclusionDate = "2021/05/06",
                            Institution = "AL-KAMALI",
                            RegisterationNumber = 120,
                            TerminationDate = "2022/04/05",
                            ValidityDate = "2023/05/07"
                        });
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            Id = 1,
                            ConcurrencyStamp = "d1de9aa9-3fc0-4da0-9498-408e2ed083e2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.AdvisorContract", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Advisor", "Advisor")
                        .WithMany("ContractAdvisors")
                        .HasForeignKey("AdvisorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Contract", "Contract")
                        .WithMany("ContractAdvisors")
                        .HasForeignKey("ContractID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advisor");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Contract", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ContractManagment_Al_Doori_.Models.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Advisor", b =>
                {
                    b.Navigation("ContractAdvisors");
                });

            modelBuilder.Entity("ContractManagment_Al_Doori_.Models.Entities.Contract", b =>
                {
                    b.Navigation("ContractAdvisors");
                });
#pragma warning restore 612, 618
        }
    }
}
