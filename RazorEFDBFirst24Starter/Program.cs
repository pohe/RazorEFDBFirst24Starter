using RazorEFDBFirst24Starter.Interfaces;
using RazorEFDBFirst24Starter.Services.DBServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//services.AddDbContext<Eventmakerdb23Context>();
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<ICountryService, CountryService>();
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
