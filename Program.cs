var builder = WebApplication.CreateBuilder(args);

string port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
string url = String.Concat("http://0.0.0.0:", port);

// comment if using app engine
builder.WebHost.UseUrls(url);


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
