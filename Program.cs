using StatsWizard.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register HTTP client for StandingsService (NBA)
builder.Services.AddHttpClient<StandingsService>(client =>
{
    client.BaseAddress = new Uri("https://api.sportradar.com/nba/trial/v8/en/seasons/2023/REG/"); // NBA API base address
});

// Register HTTP client for NFLStandingService (NFL)
builder.Services.AddHttpClient<NFLStandingService>(client =>
{
    client.BaseAddress = new Uri("https://api.sportradar.com/nfl/trial/v8/en/seasons/2023/REG/"); // NFL API base address
});

// Add the StandingsService to the DI container
builder.Services.AddScoped<StandingsService>();
// Add NFLStandingService to the DI container
builder.Services.AddScoped<NFLStandingService>();

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
