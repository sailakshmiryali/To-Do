using Microsoft.EntityFrameworkCore;
using To__Do;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StudyContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionStrings:RegisterDetailsDB"]));
// Configure the HTTP request pipeline.
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=WebControls}/{action=Index}/{name?}");
app.Run();
