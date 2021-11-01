using Google.Cloud.Diagnostics.AspNetCore3;
using Microsoft.AspNetCore.Mvc;
using Net6Test;

var builder = WebApplication.CreateBuilder(args);

string port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
string url = String.Concat("http://0.0.0.0:", port);

// comment if using app engine
builder.WebHost.UseUrls(url);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddRazorPages();

/*
builder.Services.AddGoogleExceptionLogging(options =>
{
    options.ProjectId = "net6test";
    options.ServiceName = "net6service";
});

builder.Services.AddGoogleTrace(options => options.ProjectId = "net6test"); 

*/

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();


    //app.UseGoogleExceptionLogging();
    //app.UseGoogleTrace();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSwagger(c=> c.SerializeAsV2 = true);
app.UseSwaggerUI();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("some", ([FromQuery]string arg) => new Result()
{
    Date = DateTime.UtcNow,
    Message = arg
});

app.Run();
