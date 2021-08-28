using Artech_API_370.Data;
using Artech_API_370.Entities;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Exhibitions;
using Artech_API_370.Interfaces;
using Artech_API_370.Repository.ExhibitionsRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Artech_API_370
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy("MyCorsPolicy", builder => builder
                    .WithOrigins("http://localhost:4200", "http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .WithHeaders("Accept", "Content-Type", "Origin", "X-My-Header"));
                services.AddMvc();
            });


            // Exhibition Repositories
            services.AddScoped<IAppRepository<ApplicationStatus>, ApplicationStatusRepository>();
            services.AddScoped<IAppRepository<ExhibitionAnnouncement>, ExhibitionAnnouncementRepository>();
            services.AddScoped<IAppRepository<ExhibitionApplication>, ExhibitionApplicationRepository>();
            services.AddScoped<IAppRepository<Exhibition>, ExhibitionRepository>();
            services.AddScoped<IAppRepository<ExhibitionType>, ExhibitionTypeRepository>();
            services.AddScoped<IAppRepository<Organisation>, OrganisationRepository>();
            services.AddScoped<IAppRepository<Schedule>, ScheduleRepository>();
            services.AddScoped<IAppRepository<ScheduleType>, ScheduleTypeRepository>();
            services.AddScoped<IAppRepository<Venue>, VenueRepository>();

  
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BinaryBrainsAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BinaryBrainsAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyCorsPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



        }
    }
}
