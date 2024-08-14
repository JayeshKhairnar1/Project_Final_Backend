using Grp4.repositories;
using Grp4.Services.Impl;
using Grp4.Services;
using Microsoft.EntityFrameworkCore;

namespace VconfigDotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Register ISegmentService and its implementation
            builder.Services.AddScoped<ISegmentService, SegmentService>();
            // Add services to the container.
            builder.Services.AddControllers();

            // Register the DbContext with the dependency injection container
            builder.Services.AddDbContext<VconfRepository>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("vconf")));

            // Configure Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configure CORS
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

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowReactApp"); // Apply the CORS policy

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
