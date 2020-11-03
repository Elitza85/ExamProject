﻿// <auto-generated />
using System;
using DogHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogHub.Migrations
{
    [DbContext(typeof(DogHubDbContext))]
    [Migration("20201103094246_AddRequiredAttributesAndLengthRestrictions")]
    partial class AddRequiredAttributesAndLengthRestrictions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogHub.Data.Models.Breed", b =>
                {
                    b.Property<int>("BreedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BreedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompetitionId")
                        .HasColumnType("int");

                    b.HasKey("BreedId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("DogHub.Data.Models.Chat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("DogHub.Data.Models.ChatMsg", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateAndTimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMsgs");
                });

            modelBuilder.Entity("DogHub.Data.Models.ChatUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "ChatId");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatsUsers");
                });

            modelBuilder.Entity("DogHub.Data.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DogHub.Data.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompetitionEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CompetitionStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("OrganisedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("CompetitionId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("DogHub.Data.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("DogPhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DogVideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EyesColorId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Sellable")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("DogId");

                    b.HasIndex("BreedId");

                    b.HasIndex("EyesColorId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("DogHub.Data.Models.DogColor", b =>
                {
                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.HasKey("ColorId", "DogId");

                    b.HasIndex("DogId");

                    b.ToTable("DogsColors");
                });

            modelBuilder.Entity("DogHub.Data.Models.DogCompetition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("DogId");

                    b.ToTable("DogsCompetitions");
                });

            modelBuilder.Entity("DogHub.Data.Models.EvaluationForms.JudgeEvaluationForm", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BalanceRate")
                        .HasColumnType("int");

                    b.Property<int>("ColorRate")
                        .HasColumnType("int");

                    b.Property<string>("DogCompetitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EarsRate")
                        .HasColumnType("int");

                    b.Property<int>("EyesRate")
                        .HasColumnType("int");

                    b.Property<int>("HeadShapeRate")
                        .HasColumnType("int");

                    b.Property<string>("JudgeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MuzzleRate")
                        .HasColumnType("int");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.Property<int>("WeightRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DogCompetitionId");

                    b.HasIndex("JudgeId");

                    b.ToTable("JudgeEvaluationForms");
                });

            modelBuilder.Entity("DogHub.Data.Models.EvaluationForms.VoterEvaluationForm", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BalanceRate")
                        .HasColumnType("int");

                    b.Property<int>("ColorRate")
                        .HasColumnType("int");

                    b.Property<string>("DogCompetitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EarsRate")
                        .HasColumnType("int");

                    b.Property<int>("EyesRate")
                        .HasColumnType("int");

                    b.Property<int>("HeadShapeRate")
                        .HasColumnType("int");

                    b.Property<int>("MuzzleRate")
                        .HasColumnType("int");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.Property<string>("VoterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WeightRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DogCompetitionId");

                    b.HasIndex("VoterId");

                    b.ToTable("VoterEvaluationForms");
                });

            modelBuilder.Entity("DogHub.Data.Models.EyesColor", b =>
                {
                    b.Property<int>("EyesColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EyesColorName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("EyesColorId");

                    b.ToTable("EyesColors");
                });

            modelBuilder.Entity("DogHub.Data.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TownName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("TownId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("DogHub.Data.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("UserId");

                    b.HasIndex("TownId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DogHub.Data.Models.UserRoles.Judge", b =>
                {
                    b.Property<string>("JudgeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AttendedJudgeInstituteCourse")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBeenJudgeAssistant")
                        .HasColumnType("bit");

                    b.Property<string>("JudgeInstituteCertificateUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfChampionsOwned")
                        .HasColumnType("int");

                    b.Property<int>("RaisedLitters")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("JudgeId");

                    b.HasIndex("UserId");

                    b.ToTable("Judges");
                });

            modelBuilder.Entity("DogHub.Data.Models.UserRoles.Owner", b =>
                {
                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OwnerId");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("DogHub.Data.Models.Voter", b =>
                {
                    b.Property<string>("VoterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VoterId");

                    b.HasIndex("UserId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("DogHub.Data.Models.Breed", b =>
                {
                    b.HasOne("DogHub.Data.Models.Competition", null)
                        .WithMany("BreedsAllowed")
                        .HasForeignKey("CompetitionId");
                });

            modelBuilder.Entity("DogHub.Data.Models.ChatMsg", b =>
                {
                    b.HasOne("DogHub.Data.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.ChatUser", b =>
                {
                    b.HasOne("DogHub.Data.Models.Chat", "Chat")
                        .WithMany("ChatsUsers")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.User", "User")
                        .WithMany("ChatsUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.Dog", b =>
                {
                    b.HasOne("DogHub.Data.Models.Breed", "Breed")
                        .WithMany("BreedDogs")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.EyesColor", "EyesColor")
                        .WithMany("Dogs")
                        .HasForeignKey("EyesColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.UserRoles.Owner", "Owner")
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.DogColor", b =>
                {
                    b.HasOne("DogHub.Data.Models.Color", "Color")
                        .WithMany("DogsColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.Dog", "Dog")
                        .WithMany("DogsColors")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.DogCompetition", b =>
                {
                    b.HasOne("DogHub.Data.Models.Competition", "Competition")
                        .WithMany("DogsCompetitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.Dog", "Dog")
                        .WithMany("DogsCompetiotions")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.EvaluationForms.JudgeEvaluationForm", b =>
                {
                    b.HasOne("DogHub.Data.Models.DogCompetition", "DogCompetition")
                        .WithMany("JudgeEvaluationForms")
                        .HasForeignKey("DogCompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.UserRoles.Judge", "Judge")
                        .WithMany("JudgeEvaluationForms")
                        .HasForeignKey("JudgeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.EvaluationForms.VoterEvaluationForm", b =>
                {
                    b.HasOne("DogHub.Data.Models.DogCompetition", "DogCompetition")
                        .WithMany("VoterEvaluationForms")
                        .HasForeignKey("DogCompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogHub.Data.Models.Voter", "Voter")
                        .WithMany("VoterEvaluationForms")
                        .HasForeignKey("VoterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.User", b =>
                {
                    b.HasOne("DogHub.Data.Models.Town", "Town")
                        .WithMany("Users")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.UserRoles.Judge", b =>
                {
                    b.HasOne("DogHub.Data.Models.User", "User")
                        .WithMany("Judges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.UserRoles.Owner", b =>
                {
                    b.HasOne("DogHub.Data.Models.User", "User")
                        .WithMany("Owners")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogHub.Data.Models.Voter", b =>
                {
                    b.HasOne("DogHub.Data.Models.User", "User")
                        .WithMany("Voters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
