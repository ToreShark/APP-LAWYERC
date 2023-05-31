using System.Reflection.Metadata;
using APP_LAWYER.DAL.Entities;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos);

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
                    "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом."
            },
            new Category
            {
                Id = grazhdanskoeDeloId,
                Name = "Гражданское дело",
                Slug = "grazhdanskoe-delo",
                Description =
                    "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем."
            },
            new Category
            {
                Id = administrativnoeDeloId,
                Name = "Административное дело",
                Slug = "administrativnoe-delo",
                Description =
                    "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами."
            }
        );

        
        Guid ubiystvoId = Guid.NewGuid();
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
        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos).HasData(
            new
            {
                Id = 1,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );

        Guid ubiystvoPoNeostId = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = ubiystvoPoNeostId,
                CategoryId = ugolovnoeDeloId,
                Name = "Убийство по неосторожности",
                Slug = "ubiystvo-po-neostorozhnosti",
                Description = "Описание убийства по неосторожности",
                Image =
                    "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                Content = "Краткое описание состава убийства по неосторожности и особенности расследования таких дел"
            }
        );

        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos).HasData(
            new
            {
                Id = 2,
                SubcategoryId = ubiystvoPoNeostId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        Guid alimonyClaimId = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = alimonyClaimId,
                CategoryId = grazhdanskoeDeloId,
                Name = "Иск о взыскании алиментов в твердой денежной сумме",
                Slug = "isk-o-vzyiskanii-v-tverdoy-deneyshnoy-summe",
                Description = "Видеоурок и образец иска о взыскании в твердой денежной сумме",
                Image =
                    "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80",
                Content = "Краткое описание иска о взыскании в твердой денежной сумме"
            }
        );

        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos).HasData(
            new
            {
                Id = 1,
                SubcategoryId = alimonyClaimId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        
        Guid alimonyClaimMonId = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = alimonyClaimMonId,
                CategoryId = grazhdanskoeDeloId,
                Name = "Иск о взыскании алиментов",
                Slug = "isk-o-vzyiskanii-alimentov",
                Description = "Видеоурок и образец иска о взыскании в твердой денежной сумме",
                Image =
                    "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80",
                Content = "Краткое описание иска о взыскании в твердой денежной сумме"
            }
        );
        
        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos).HasData(
            new[]
            {
                new
                {
                    Id = 1,
                    SubcategoryId = alimonyClaimMonId,
                    Url = "https://youtu.be/AmUenqhE1mw",
                    Description =
                        "<div class='App' style='text-align: center;'>" +
                        "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                        "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                        "<hr class='remove'></div>"
                },
                new
                {
                    Id = 2,
                    SubcategoryId = alimonyClaimMonId,
                    Url = "https://youtu.be/1VxXyBo62yM",
                    Description =
                        "<div class='App' style='text-align: center;'>" +
                        "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                        "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                        "<hr class='remove'></div>"
                }
            }
        );
        
        Guid admdtp = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = admdtp,
                CategoryId = administrativnoeDeloId,
                Name = "ДТП",
                Slug = "dtp",
                Description = "Краткое описание состава ДТП",
                Image =
                    "https://images.unsplash.com/photo-1573068111653-f18bef611c8a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1374&q=80",
                Content = "Краткое описание состава ДТП и особенности расследования таких дел"
            }
        );

        modelBuilder.Entity<Subcategory>().OwnsMany(s => s.Videos).HasData(
            new[]
            {
                new
                {
                    Id = 1,
                    SubcategoryId = admdtp,
                    Url = "https://youtu.be/AmUenqhE1mw",
                    Description =
                        "<div class='App' style='text-align: center;'>" +
                        "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                        "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                        "<hr class='remove'></div>"
                }
            });
    }
}