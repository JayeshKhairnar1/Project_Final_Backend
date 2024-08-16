using Grp4.repositories;
using Grp4.Services.Impl;
using Grp4.Services;
using Microsoft.EntityFrameworkCore;
using VconfigDotnet.Services;
using VconfigDotnet.Services.Impl;

namespace VconfigDotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             builder.Services.AddScoped<ISegment, SegmentService>();
            builder.Services.AddScoped<IManufacturer, ManufacturerService>();   
            builder.Services.AddControllers();

         
            builder.Services.AddDbContext<VconfRepository>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("vconf")));

           
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowReactApp");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
