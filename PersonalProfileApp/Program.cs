var builder = WebApplication.CreateBuilder(args);

// Контроллерлер мен Razor View үшін MVC сервистерін тіркейміз.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // Жарияланған ортада ішкі қате туралы мәліметті көрсетпейміз.
    app.UseExceptionHandler(errorApp => errorApp.Run(async context =>
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("Қате орын алды. Кейінірек қайта көріңіз.");
    }));
    app.UseHsts();
    app.UseHttpsRedirection();
}

// wwwroot ішіндегі CSS және басқа статикалық файлдарды ұсынады.
app.UseStaticFiles();
app.UseRouting();

// / мекенжайы әдепкіде InfoController.Index Action-ына келеді.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Info}/{action=Index}/{id?}");

app.Run();
