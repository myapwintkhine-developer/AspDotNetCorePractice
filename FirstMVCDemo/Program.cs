var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();  //register all controllers and views
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");   //default start page
app.MapGet("/profile/me", () => "Hello, It is me");
app.MapGet("/profile/now", () => "Time is "+DateTime.Now);
//app.MapDefaultControllerRoute();  //config the default routing pattern for all controller methods
app.MapControllerRoute(name:"default", pattern:"{controller=Home}/{action=Index}/{id?}");
app.Run();
