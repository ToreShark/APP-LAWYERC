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
    public DbSet<Video> Videos { get; set; }
    public DbSet<SubcategoryVideo> SubcategoryVideos { get; set; }


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
        
    }
}