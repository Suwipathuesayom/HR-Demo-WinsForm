using System;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using hr_demo;
using hr_demo_data;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var mainForm = services.GetRequiredService<SignIn>();
            Application.Run(mainForm);

        }


    }

    static IHostBuilder CreateHostBuilder() =>
        Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException("DefaultConnection is missing or empty in configuration.");
                }
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString));

                services.AddTransient<SignUp>();
                services.AddTransient<SignIn>();
                services.AddTransient<UsersForm>();
                services.AddTransient<CreateCustomerForm>();
                services.AddTransient<UpdateCustomerForm>();
                services.AddTransient<DashboardForm>();
            });
}