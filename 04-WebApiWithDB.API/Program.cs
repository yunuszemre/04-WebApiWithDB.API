using _04_WebApiWithDB.Repositories.Abstract;
using _04_WebApiWithDB.Repositories.Concreate;
using _04_WebApiWithDB.Repositories.Context;
using _04_WebApiWithDB.Service.Abstract;
using _04_WebApiWithDB.Service.Concreate;
using Microsoft.EntityFrameworkCore;

namespace _04_WebApiWithDB.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddDbContext<ProjeContext>(option =>
            {
                option.UseSqlServer("Server=DESKTOP-BODOH2U\\\\SA; Database = EmployeeDB; uid = SA; pwd = 1234");
            });
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}