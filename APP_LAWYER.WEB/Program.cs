using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Enums;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));

builder.Services.AddScoped<UOW>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => { options.LoginPath = new PathString("/Account/Login"); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    "areas",
    "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        var uow = services.GetRequiredService<UOW>();
        context.Database.Migrate(); // Apply migrations

        var superAdminRole = context.Roles.FirstOrDefault(r => r.RoleName == RoleName.SuperAdmin)?.RoleId;

        if (superAdminRole == null) throw new Exception("Роль SuperAdmin не найдена в базе данных");

        if (!context.Users.Any(u => u.RoleId == superAdminRole))
        {
            var superAdminUser = new User
            {
                Phone = "87073816081", // Замените на желаемый номер телефона
                Password = uow.UserRepository.PasswordHash("123"), // Замените на желаемый пароль
                RoleId = superAdminRole.Value,
                Email = "superadmin@example.com",
                FirstName = "Super",
                LastName = "Admin"
            };
            context.Users.Add(superAdminUser);
            context.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

app.Run();