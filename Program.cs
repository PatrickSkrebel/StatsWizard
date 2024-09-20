using StatsWizard.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the HTTP client and StandingsService
builder.Services.AddHttpClient<StandingsService>(client =>
{
    client.BaseAddress = new Uri("https://api.sportradar.com/nba/trial/v8/en/seasons/2023/REG/"); // Base address for API requests
});

// Add the StandingsService to the DI container
builder.Services.AddScoped<StandingsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
