
using dvdrental.IRepository;
using dvdrental.IService;
using dvdrental.Repository;
using dvdrental.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace dvdrental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionSting = builder.Configuration.GetConnectionString("DefaultConnection");

            var database = new DatabaseInitial(connectionSting);
          
            database.Initialize();
            


            builder.Services.AddScoped<IAdminRepository>(provider =>new AdminRepository(connectionSting));
            builder.Services.AddSingleton<IAdminService>(provider => new AdminService(provider.GetRequiredService<IAdminRepository>()));

            builder.Services.AddScoped<ICustomerRepository>(provider => new CustomerRepository(connectionSting));
            builder.Services.AddSingleton<ICustomerService>(provider => new CustomerService(provider.GetRequiredService<ICustomerRepository>()));

          


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

          
            builder.Services.AddScoped<IAdminService, AdminService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

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
