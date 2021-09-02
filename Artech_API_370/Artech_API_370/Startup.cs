using Artech_API_370.Data;
using Artech_API_370.Entities;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Entities.Artists;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Entities.Images;
using Artech_API_370.Entities.Payments;
using Artech_API_370.Entities.Users;
using Artech_API_370.Exhibitions;
using Artech_API_370.Interfaces;
using Artech_API_370.Repository.ArtClassesRepositories;
using Artech_API_370.Repository.ArtistsRepositories;
using Artech_API_370.Repository.ArtworksRepositories;
using Artech_API_370.Repository.ExhibitionsRepositories;
using Artech_API_370.Repository.ImagesRepositories;
using Artech_API_370.Repository.PaymentsRepositories;
using Artech_API_370.Repository.UsersRepositories;
using BinaryBrainsAPI.Entities.Bookings;
using BinaryBrainsAPI.Repository.BookingsRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
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

            services.AddDbContext<ArtechDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            // User Repositories
            services.AddScoped<IAppRepository<User>, UsersRepository>();
            services.AddScoped<IAppRepository<City>, CityRepository>();
            services.AddScoped<IAppRepository<Province>, ProvinceRepository>();
            services.AddScoped<IAppRepository<Suburb>, SuburbRepository>();
            services.AddScoped<IAppRepository<Country>, CountryRepository>();
            services.AddScoped<IAppRepository<UserType>, UserTypeRepository>();
            services.AddScoped<IAppRepository<Privileges>, PrivilegesRepository>();
            services.AddScoped<IIdentifier<User>, UserLoginRepository>();
            services.AddScoped<IAppRepository<Announcement>, AnnouncementRepository>();


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

            // Art Classes Repositories
            services.AddScoped<IAppRepository<ArtClass>, ArtClassRepository>();
            services.AddScoped<IAppRepository<ArtClassAnnouncement>, ArtClassAnnouncementRepository>();
            services.AddScoped<IAppRepository<ArtClassType>, ArtClassTypeRepository>();
            services.AddScoped<IAppRepository<ClassTeacher>, ClassTeacherRepository>();
            services.AddScoped<IAppRepository<Feedback>, FeedbackRepository>();
            services.AddScoped<IAppRepository<TeacherType>, TeacherTypeRepository>();

            // Artists Repositories
            services.AddScoped<IAppRepository<Invitation>, InvitationRepository>();
            services.AddScoped<IAppRepository<InvitationStatus>, InvitationStatusRepository>();

            // Artworks Repositories
            services.AddScoped<IAppRepository<Artwork>, ArtworkRepository>();
            services.AddScoped<IAppRepository<ArtworkDimension>, ArtworkDimensionRepository>();
            services.AddScoped<IAppRepository<ArtworkStatus>, ArtworkStatusRepository>();
            services.AddScoped<IAppRepository<ArtworkType>, ArtworkTypeRepository>();
            services.AddScoped<IAppRepository<FrameColour>, FrameColourRepository>();
            services.AddScoped<IAppRepository<MediumType>, MediumTypeRepository>();
            services.AddScoped<IAppRepository<SurfaceType>, SurfaceTypeRepository>();

            // Bookings Repositories
            services.AddScoped<IAppRepository<Booking>, BookingRepository>();
            services.AddScoped<IAppRepository<BookingNotification>, BookingNotificationRepository>();

            // Payments Repositories
            services.AddScoped<IAppRepository<Payment>, PaymentRepository>();
            services.AddScoped<IAppRepository<PaymentStatus>, PaymentStatusRepository>();
            services.AddScoped<IAppRepository<PaymentType>, PaymentTypeRepository>();
            services.AddScoped<IAppRepository<Refund>, RefundRepository>();

            // Images Repositories
            services.AddScoped<IAppRepository<Image>, ImagesRepository>();
            services.AddScoped<IAppRepository<Image>, ImageRepository>();
            services.AddScoped<IAppRepository<ImageType>, ImageTypeRepository>();



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
