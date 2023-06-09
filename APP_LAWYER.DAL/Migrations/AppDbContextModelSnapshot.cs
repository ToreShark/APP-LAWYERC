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

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlMedium")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlSmall")
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
                            Id = new Guid("f1fdea85-532a-4443-9eb1-5c575dfcb23c"),
                            Description = "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.",
                            FullDescription = "Категория \"Уголовное дело\" на нашем юридическом сайте представляет собой центральную точку для всех, кто ищет надежную поддержку и консультации в разбирательствах с законом. Уголовное дело охватывает широкий спектр правовых вопросов, связанных с преступлениями, обвинениями и уголовным правосудием.\n\nНаша команда опытных юристов специализируется на уголовном праве и готова предложить вам профессиональную помощь во всех аспектах уголовного дела. Мы понимаем, что столкнуться с уголовным обвинением или стать свидетелем преступления может быть эмоционально и юридически сложным процессом. Поэтому мы стремимся обеспечить наших клиентов всесторонней поддержкой и уверенностью в достижении наилучших результатов.\n\nВ категории \"Уголовное дело\" вы найдете информацию о различных видов уголовных преступлений, их юридическом определении и последствиях. Мы предлагаем подробные обзоры основных составов преступлений, включая убийство, грабеж, насилие, кражу и другие. Каждый тип преступления раскрывается с точки зрения законодательства, а также рассматриваются особенности расследования и судебного процесса, связанные с этими делами.\n\nКроме того, в рамках категории \"Уголовное дело\" мы предоставляем информацию о правовых аспектах уголовного правосудия. Вы найдете полезные статьи о процессе уголовного расследования, оформлении обвинительного акта, правах обвиняемых и защите прав потерпевших. Мы также рассматриваем вопросы, связанные с уголовной ответственностью, наказаниями, судебными процессами и альтернативными способами урегулирования уголовных дел.\n\nНаша команда юристов имеет богатый опыт работы с клиентами, которые столкнулись с уголовными делами. Мы стремимся предоставить вам всю необходимую информацию и руководство, чтобы помочь вам принять обоснованные решения в сложных юридических ситуациях. Мы понимаем, что каждое уголовное дело уникально, и поэтому наш подход к каждому клиенту индивидуален и внимателен.\n\nЕсли вы ищете помощь в уголовном деле, не стесняйтесь обратиться к нам. Мы готовы предоставить вам профессиональную консультацию, представлять вас в суде и работать над достижением наилучших результатов в вашем уголовном деле.\n\nМы верим, что каждый имеет право на справедливое и справедливое уголовное правосудие. Мы нацелены на защиту ваших прав и интересов, и мы готовы помочь вам преодолеть сложности уголовного дела.\n\nОбратитесь к нам уже сегодня и дайте нам возможность стать вашим надежным партнером в уголовном праве.",
                            ImageUrl = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                            ImageUrlMedium = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                            ImageUrlSmall = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                            Name = "Уголовное дело",
                            Slug = "ugolovnoe-delo"
                        },
                        new
                        {
                            Id = new Guid("4275ee7f-0786-465b-aa68-dc386e8490f7"),
                            Description = "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.",
                            FullDescription = "Гражданское дело - это область юридической практики, которая занимается регулированием отношений между физическими и юридическими лицами. Оно охватывает широкий спектр вопросов, связанных с гражданскими правами и обязанностями, собственностью, контрактами, наследством, семейными спорами, трудовыми отношениями и многим другим.\n\nВ рамках гражданского дела наша команда юристов предоставляет комплексные юридические услуги для решения различных гражданских проблем. Мы осознаем, что столкнуться с гражданским спором или необходимостью защищать свои права может быть сложным и запутанным процессом. Поэтому мы стремимся обеспечить нашим клиентам профессиональное сопровождение и решение важных правовых вопросов.\n\nНаша команда специализируется на различных аспектах гражданского права, включая судебные споры, составление и анализ юридических документов, юридическое консультирование и представительство интересов клиентов перед судом и другими органами. Мы уделяем особое внимание каждому делу и стремимся найти оптимальное решение, которое удовлетворит интересы наших клиентов.\n\nВ рамках категории \"Гражданское дело\" вы найдете информацию о различных аспектах гражданского права. Мы предлагаем подробные обзоры основных видов гражданских дел, таких как договорные споры, споры о собственности, наследственные споры, разводы, алименты, трудовые споры и многие другие. Кроме того, мы предоставляем информацию о правовых нормах, прецедентах, судебной практике и возможных способах разрешения гражданских споров.\n\nНаша цель - помочь нашим клиентам разобраться в сложностях гражданского дела и достичь желаемых результатов. Мы прилагаем все усилия, чтобы предоставить профессиональные услуги, индивидуальный подход и компетентное сопровождение в каждом конкретном случае.\n\nЕсли у вас возникли гражданские проблемы или вам нужна правовая поддержка, обратитесь к нам. Наша команда юристов готова помочь вам в решении гражданских споров, предоставить консультацию и оказать необходимую правовую помощь.\n\nДоверьте свои гражданские дела профессионалам и получите надежное юридическое сопровождение для достижения желаемых результатов.",
                            ImageUrl = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            ImageUrlMedium = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            ImageUrlSmall = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Name = "Гражданское дело",
                            Slug = "grazhdanskoe-delo"
                        },
                        new
                        {
                            Id = new Guid("64497e02-776a-443c-9a69-1991dd09c3e5"),
                            Description = "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.",
                            FullDescription = "Административное дело - это область юридической практики, которая занимается регулированием правовых вопросов, связанных с административными правонарушениями и процедурами, установленными административным правом. В административном праве регулируются отношения между гражданами и государством, а также между государственными органами.\n\nВ рамках категории \"Административное дело\" наша команда юристов предоставляет специализированные юридические услуги в области административного права. Мы имеем опыт работы с клиентами, столкнувшимися с различными административными правонарушениями, и готовы оказать профессиональную помощь в решении сложных правовых вопросов.\n\nМы понимаем, что административные правонарушения могут иметь серьезные последствия для наших клиентов, включая штрафы, лишение прав, конфискацию имущества и другие негативные последствия. Поэтому мы стремимся предоставить нашим клиентам качественное представительство и юридическую помощь, чтобы защитить их интересы и обеспечить справедливое решение дела.\n\nВ рамках категории \"Административное дело\" мы предлагаем широкий спектр услуг. Наша команда специализируется на оказании правовой помощи в случаях нарушений правил дорожного движения, административных правонарушений в сфере налогообложения, нарушениях трудового законодательства, противодействии коррупции и других административных правонарушениях.\n\nМы готовы представлять интересы клиентов перед административными органами, судами и другими государственными инстанциями. Наша команда знакома с процедурами и требованиями, связанными с административным делопроизводством, и готова оказать профессиональное сопровождение и представительство в каждом конкретном случае.\n\nМы осознаем важность своей роли в защите прав и интересов наших клиентов в административном процессе. Мы стремимся к достижению наилучших результатов для наших клиентов, обеспечивая правовую защиту и представительство на самом высоком уровне.\n\nЕсли у вас возникли административные проблемы, не стесняйтесь обратиться к нам. Наша команда юристов готова предоставить вам квалифицированную юридическую помощь и сопровождение, чтобы помочь вам решить ваше административное дело.",
                            ImageUrl = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                            ImageUrlMedium = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                            ImageUrlSmall = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

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

                    b.Property<Guid>("CommentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<int>("RoleName")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = 1
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = 2
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = 3
                        },
                        new
                        {
                            RoleId = 4,
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

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKeywords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaTitle")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

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

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.VideoInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VideoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VideoId")
                        .IsUnique();

                    b.ToTable("VideoInfos");
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
                        .HasForeignKey("UserId")
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
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_LAWYER.DAL.Entities.User", "User")
                        .WithMany("Replies")
                        .HasForeignKey("UserId")
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

            modelBuilder.Entity("APP_LAWYER.DAL.Entities.VideoInfo", b =>
                {
                    b.HasOne("APP_LAWYER.DAL.Entities.Video", null)
                        .WithOne("VideoInfo")
                        .HasForeignKey("APP_LAWYER.DAL.Entities.VideoInfo", "VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

                    b.Navigation("VideoInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
