var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/hello", () => {
    return new List<string>() {
        "Hello World!",
        "Hello Galaxy!",
        "Hello Universe!"
    };
});

app.MapDefaultControllerRoute();

app.Run();
