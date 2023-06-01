﻿// <auto-generated />
using System;
using APP_LAWYER.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APP_LAWYER.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("6d09c29c-6c35-4412-bc23-595fcd193358"),
                            Description = "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.",
                            Name = "Уголовное дело",
                            Slug = "ugolovnoe-delo"
                        },
                        new
                        {
                            Id = new Guid("42f6a411-556e-4527-abe0-ee68d35a1354"),
                            Description = "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.",
                            Name = "Гражданское дело",
                            Slug = "grazhdanskoe-delo"
                        },
                        new
                        {
                            Id = new Guid("c44e1238-6e5d-4422-a12b-41d445acd7cb"),
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
                            Id = new Guid("5d5fa336-9d0e-46c1-871b-dcbf2c71ba39"),
                            CategoryId = new Guid("6d09c29c-6c35-4412-bc23-595fcd193358"),
                            Content = "Краткое описание состава убийства и особенности расследования таких дел",
                            Description = "Описание убийства",
                            Image = "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                            Name = "Убийство",
                            Slug = "ubiystvo"
                        },
                        new
                        {
                            Id = new Guid("f00216ee-72df-4ef8-bb92-2f11349cfda1"),
                            CategoryId = new Guid("6d09c29c-6c35-4412-bc23-595fcd193358"),
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
                            SubcategoryId = new Guid("5d5fa336-9d0e-46c1-871b-dcbf2c71ba39"),
                            VideoId = new Guid("574ccf67-2bad-48ca-99da-ef7cfa233940")
                        },
                        new
                        {
                            SubcategoryId = new Guid("f00216ee-72df-4ef8-bb92-2f11349cfda1"),
                            VideoId = new Guid("66621547-2566-44b9-86f2-dfa719675ae7")
                        },
                        new
                        {
                            SubcategoryId = new Guid("f00216ee-72df-4ef8-bb92-2f11349cfda1"),
                            VideoId = new Guid("7d6c52e2-b82a-4614-af91-265a75ed9c7c")
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

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                            Id = new Guid("574ccf67-2bad-48ca-99da-ef7cfa233940"),
                            Description = "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>",
                            Url = "https://youtu.be/AmUenqhE1mw"
                        },
                        new
                        {
                            Id = new Guid("66621547-2566-44b9-86f2-dfa719675ae7"),
                            Description = "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>",
                            Url = "https://youtu.be/AmUenqhE1mw"
                        },
                        new
                        {
                            Id = new Guid("7d6c52e2-b82a-4614-af91-265a75ed9c7c"),
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
                        .WithMany("Comments")
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

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Subcategory", b =>
                {
                    b.Navigation("Comments");

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
