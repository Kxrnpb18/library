namespace library
{
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using library.Services;


    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddScoped<bookService>();

            builder.Services.AddTransient<JsonFileProductService>();
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

             
            app.UseRouting();

            
            app.UseAuthorization();

            
            app.MapRazorPages();

            app.MapControllers();

            app.Run();

            Console.WriteLine($"Version: {Environment.Version}");
            Console.ReadLine();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

        }
    }

    internal class JsonFileProductService
    {
    }
}

