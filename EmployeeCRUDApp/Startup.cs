using EmployeeCRUDApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;


namespace EmployeeCRUDApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        { Configuration = configuration; }

        public void Configure(IApplicationBuilder app)
        {


            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<EmployeeContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

    }
}
