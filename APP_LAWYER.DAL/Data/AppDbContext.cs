using System.Reflection.Metadata;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Subcategory> Subcategories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Otp> Otps { get; set; }
    public DbSet<DocumentEntity> Documents { get; set; }
    public DbSet<Reply> Replies { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<SubcategoryVideo> SubcategoryVideos { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<DocumentTemplate> DocumentTemplates { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubcategoryVideo>()
            .HasKey(sc => new { sc.SubcategoryId, sc.VideoId });

        modelBuilder.Entity<SubcategoryVideo>()
            .HasOne(sc => sc.Subcategory)
            .WithMany(s => s.SubcategoryVideos)
            .HasForeignKey(sc => sc.SubcategoryId);

        modelBuilder.Entity<SubcategoryVideo>()
            .HasOne(sc => sc.Video)
            .WithMany(v => v.SubcategoryVideos)
            .HasForeignKey(sc => sc.VideoId);

        modelBuilder.Entity<Reply>()
            .HasOne(r => r.User)
            .WithMany(u => u.Replies)
            .OnDelete(DeleteBehavior.Restrict);
        ;

        modelBuilder.Entity<Reply>()
            .HasOne(r => r.Comment)
            .WithMany(c => c.Replies)
            .OnDelete(DeleteBehavior.Restrict);
        ;
        modelBuilder.Entity<Vote>()
            .HasOne(v => v.User)
            .WithMany(u => u.Votes)
            .OnDelete(DeleteBehavior.Restrict);

        Guid ugolovnoeDeloId = Guid.NewGuid();
        Guid grazhdanskoeDeloId = Guid.NewGuid();
        Guid administrativnoeDeloId = Guid.NewGuid();

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = ugolovnoeDeloId,
                Name = "Уголовное дело",
                Slug = "ugolovnoe-delo",
                Description =
                    "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.",
                ImageUrl = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlMedium = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlSmall = "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80"
            },
            new Category
            {
                Id = grazhdanskoeDeloId,
                Name = "Гражданское дело",
                Slug = "grazhdanskoe-delo",
                Description =
                    "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.",
                ImageUrl = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                ImageUrlMedium = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                ImageUrlSmall = "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
            },
            new Category
            {
                Id = administrativnoeDeloId,
                Name = "Административное дело",
                Slug = "administrativnoe-delo",
                Description =
                    "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.",
                ImageUrl = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlMedium = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlSmall = "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80"
            }
        );
        Guid ubiystvoId = Guid.NewGuid();
        Guid videoId = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = ubiystvoId,
                CategoryId = ugolovnoeDeloId,
                Name = "Убийство",
                Slug = "ubiystvo",
                Description = "Описание убийства",
                Image =
                    "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                Content = "Краткое описание состава убийства и особенности расследования таких дел"
            }
        );
        modelBuilder.Entity<Video>().HasData(
            new
            {
                Id = videoId,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        modelBuilder.Entity<SubcategoryVideo>().HasData(
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoId,
                VideoId = videoId,
            }
        );
        Guid ubiystvoponeostorozhnostiId = Guid.NewGuid();
        Guid video1Id = Guid.NewGuid();
        Guid video2Id = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = ubiystvoponeostorozhnostiId,
                CategoryId = ugolovnoeDeloId,
                Name = "Убийство по неосторожности",
                Slug = "ubiystvo-po-neostorozhnosti",
                Description = "Описание убийства по неосторожности",
                Image =
                    "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                Content = "Краткое описание состава убийства по неосторожности и особенности расследования таких дел"
            }
        );
        modelBuilder.Entity<Video>().HasData(
            new
            {
                Id = video1Id,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            },
            new
            {
                Id = video2Id,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        modelBuilder.Entity<SubcategoryVideo>().HasData(
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoponeostorozhnostiId,
                VideoId = video1Id,
            },
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoponeostorozhnostiId,
                VideoId = video2Id,
            }
        );
        modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = Guid.NewGuid(),
                RoleName = RoleName.SuperAdmin,
            }, new Role
            {
                Id = Guid.NewGuid(),
                RoleName = RoleName.Admin,
            }, new Role
            {
                Id = Guid.NewGuid(),
                RoleName = RoleName.Moderator,
            }, new Role
            {
                Id = Guid.NewGuid(),
                RoleName = RoleName.Basic,
            }
        );
    }
}