using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var kvUrl = builder.Configuration["AzureKeyVaultUrl"];
var secretsClient = new SecretClient(new Uri(kvUrl), new DefaultAzureCredential());
var sqlConnString = secretsClient.GetSecret("sql");
builder.Services.AddCustomServices(sqlConnString.Value.Value);



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

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
