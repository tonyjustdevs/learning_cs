#region [1] import namespaces
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TP.Mvc.Data;
#endregion

#region [1a] Summary
// summary:
// - the incoming request is
// - handled by the configured HTTP request pipeline,
// - then by a route handler,
// - and then by a controller,
// - which creates a model and passes it to a view.
//
// The letters MVC are not in the order of processing,
// and there is more to MVC than just models, views, and controllers.
#endregion

#region [2] Create builder
var builder = WebApplication.CreateBuilder(args);
WriteLine($"\n[1] Builder created: {builder} [{builder.GetType()}]");
#endregion

#region [3a] Add builder.Configuration (more like get it but yeh)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
WriteLine($"\n[2a]Retrieving connection string via builder.Configuration: [{builder.Configuration}]");
WriteLine($"[2b]- ConnStr: [{connectionString}]");
#endregion

#region [3b] Add builder.Services
WriteLine("\n[3] Adding Auth-DbContext with connStr via Services.AddDbContext...UseSqlServer(): {}");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
#endregion

#region [4] Build app
var app = builder.Build();
#endregion

#region [5] Configure HTTP pipelines, static-files, redirection, etc
// AKA Middleware: 
// - HTTP request -> middleware (here) -> infrastructure action (DB migration)
#endregion

#region [5a] Configure Environment-Specific Settings: Developer vs Production
if (app.Environment.IsDevelopment())  // aka checks IsDevelopment==true
{   
    app.UseMigrationsEndPoint(); // equivalent to context.Database.Migrate();
    // - Exposes internal system ops via HTTP
    // - Uses middleware as a [control-layer]
    // - Connects [web requests] -> [database operations]
    // - autoruns: app.UseDeveloperExceptionPage();
}
else // [5aii] Production Settings 
{// The default HSTS value is 30 days. Change for Prod cases: https://aka.ms/aspnetcore-hsts.
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
#endregion

#region [5b] Configure Environment Settings: General/Common

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
//app.UseStaticFiles();

app.MapControllerRoute(
    name: "default", // setting generic controller pattern
    pattern: "{controller=Home}/{action=Index}/{id?}") 
    .WithStaticAssets();

app.MapRazorPages() // for auth page
   .WithStaticAssets();
#endregion

#region [6] Add Routes
// learn https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments
app.MapGet("/env", () => { WriteLine($"\napp.Environment: {app.Environment};"); });
#endregion

#region [7] Run app
app.Run();
#endregion
