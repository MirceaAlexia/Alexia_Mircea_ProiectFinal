using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Alexia_Mircea_ProiectFinal.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Alexia_Mircea_ProiectFinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Alexia_Mircea_ProiectFinalContext") ?? throw new InvalidOperationException("Connection string 'Alexia_Mircea_ProiectFinalContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
