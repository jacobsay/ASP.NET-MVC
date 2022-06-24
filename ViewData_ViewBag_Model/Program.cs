var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute("viewdata", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("viewbag", "{controller=Home}/{action=ViewBag}/{Id?}");
app.MapControllerRoute("model", "{controller=Home}/{action=Model}/{Id?}");

app.Run();
