using DAD.CoreService.Service.Demo;
using DAD.CoreService.Service.DemoHello;
using VandaCloud.Service.Common.ActionFilter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register Demo Services
builder.Services.AddScoped<IDemoHelloService, DemoHelloService>();
builder.Services.AddScoped<IDemoService, DemoService>();
builder.Services.AddScoped<DemoActionFilter>();

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
