using aspWebApiCore.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace aspWebApiCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Conexion con sql server
            const string CONNECTION_NAME = "DBconnect";
            var connectionString = builder.Configuration.GetConnectionString(CONNECTION_NAME);

            //Contexto
            builder.Services.AddDbContext<UniversityDBcontext>(options => options.UseSqlServer(connectionString));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
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