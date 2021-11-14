var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSingleton<SmtpSettings>();

//var smtpSettings = new SmtpSettings() { Host = "localhost" };
//builder.Services.AddSingleton<SmtpSettings>(smtpSettings);

builder.Services.AddSingleton<SmtpSettings>(sp => {
    var smtpSettings = new SmtpSettings() { Host = "localhost" };
    return smtpSettings;
});


builder.Logging.ClearProviders();
builder.Logging.AddJsonConsole();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("1");
//    await next();
//    await context.Response.WriteAsync("2");
//});


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("3");
//    await next();
//    await context.Response.WriteAsync("4");
//});

//app.Run(async (context) => {
//    await context.Response.WriteAsync("5");
//});


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Start\r\n");
//    await next();
//    await context.Response.WriteAsync("End\r\n");
//});

//app.Run(async (context) => {
//    await context.Response.WriteAsync("Hello World.\r\n");
//});

app.Run();
