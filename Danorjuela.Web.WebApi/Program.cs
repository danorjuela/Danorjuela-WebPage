#region Usings
using Microsoft.Extensions.DependencyInjection;
#endregion

#region Builder Configuration  
var builder = WebApplication.CreateBuilder(args);
#endregion

#region Razor Configuration 
// Add services to the container.
builder.Services.AddRazorPages();
#endregion

#region App Configuration 
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
#endregion