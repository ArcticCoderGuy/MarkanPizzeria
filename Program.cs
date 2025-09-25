using MarkanPizzeria.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();     // 🔑 Tämä varmistaa että kuvat, css ja js toimii wwwrootista

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();      // 🔑 Tämä rekisteröi Razor Pages -reitit

app.Run();
