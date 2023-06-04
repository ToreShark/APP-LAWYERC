﻿// <auto-generated />
using System;
using APP_LAWYER.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APP_LAWYER.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230603181421_AddedDocTemplate123")]
    partial class AddedDocTemplate123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34400723-ad6f-474b-8aea-634425e7881a"),
                            Description = "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.",
                            Name = "Уголовное дело",
                            Slug = "ugolovnoe-delo"
                        },
                        new
                        {
                            Id = new Guid("69f10dc0-3792-4ca4-9a02-aa9c3ed04949"),
                            Description = "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.",
                            Name = "Гражданское дело",
                            Slug = "grazhdanskoe-delo"
                        },
                        new
                        {
                            Id = new Guid("22dda934-02ca-43f3-8699-ffe12871aa4f"),
                            Description = "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.",
                            Name = "Административное дело",
                            Slug = "administrativnoe-delo"
                        });
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp");

                    b.Property<Guid>("SubcategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubcategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.DocumentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.DocumentTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTemplates");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Otp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Code")
                        .HasColumnType("int")
                        .HasColumnName("otp");

                    b.Property<byte[]>("ExpirationDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("expirationDate");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Otps");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Reply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CommentId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CommentId1");

                    b.HasIndex("UserId1");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba122783-55bf-42d3-8e1d-36cdbc352dfe"),
                            RoleName = 1
                        },
                        new
                        {
                            Id = new Guid("5675873f-5872-41ea-989b-33720f7000c5"),
                            RoleName = 2
                        },
                        new
                        {
                            Id = new Guid("e6b9dd73-8f32-4241-93a5-e0adb2553cc8"),
                            RoleName = 3
                        },
                        new
                        {
                            Id = new Guid("5b9682ed-14d2-45fc-ae56-5897bf23bff2"),
                            RoleName = 4
                        });
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Subcategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"),
                            CategoryId = new Guid("34400723-ad6f-474b-8aea-634425e7881a"),
                            Content = "Краткое описание состава убийства и особенности расследования таких дел",
                            Description = "Описание убийства",
                            Image = "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                            Name = "Убийство",
                            Slug = "ubiystvo"
                        },
                        new
                        {
                            Id = new Guid("3387731c-932b-419a-bb95-52628d88df62"),
                            CategoryId = new Guid("34400723-ad6f-474b-8aea-634425e7881a"),
                            Content = "Краткое описание состава убийства по неосторожности и особенности расследования таких дел",
                            Description = "Описание убийства по неосторожности",
                            Image = "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                            Name = "Убийство по неосторожности",
                            Slug = "ubiystvo-po-neostorozhnosti"
                        });
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.SubcategoryVideo", b =>
                {
                    b.Property<Guid>("SubcategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VideoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubcategoryId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("SubcategoryVideos");

                    b.HasData(
                        new
                        {
                            SubcategoryId = new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"),
                            VideoId = new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed")
                        },
                        new
                        {
                            SubcategoryId = new Guid("3387731c-932b-419a-bb95-52628d88df62"),
                            VideoId = new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f")
                        },
                        new
                        {
                            SubcategoryId = new Guid("3387731c-932b-419a-bb95-52628d88df62"),
                            VideoId = new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac")
                        });
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed"),
                            Description = "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>",
                            Url = "https://youtu.be/AmUenqhE1mw"
                        },
                        new
                        {
                            Id = new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f"),
                            Description = "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>",
                            Url = "https://youtu.be/AmUenqhE1mw"
                        },
                        new
                        {
                            Id = new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac"),
                            Description = "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>",
                            Url = "https://youtu.be/AmUenqhE1mw"
                        });
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Value")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Comment", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subcategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.DocumentEntity", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("Docs")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Otp", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("OtpCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Reply", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Comment", "Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("Replies")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Subcategory", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.SubcategoryVideo", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Subcategory", "Subcategory")
                        .WithMany("SubcategoryVideos")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_LAWYER.DAL.Entities.Video", "Video")
                        .WithMany("SubcategoryVideos")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subcategory");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.User", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Vote", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Comment", "Comment")
                        .WithMany("Votes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("Votes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Comment", b =>
                {
                    b.Navigation("Replies");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Subcategory", b =>
                {
                    b.Navigation("SubcategoryVideos");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Docs");

                    b.Navigation("OtpCodes");

                    b.Navigation("Replies");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Video", b =>
                {
                    b.Navigation("SubcategoryVideos");
                });
#pragma warning restore 612, 618
        }
    }
}
