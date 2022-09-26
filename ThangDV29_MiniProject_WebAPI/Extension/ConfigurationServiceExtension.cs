using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using ThangDV29_MiniProject_WebAPI.ApplicationDBContext;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;
using ThangDV29_MiniProject_WebAPI.Repository;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;
using ThangDV29_MiniProject_WebAPI.Repository.MyRepository;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.Services.MyServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Extention
{
    public static class ConfigurationServiceExtension
    {
        public static void AddConfigurationService(this IServiceCollection services, IConfiguration configuration)
        {
            #region AddServiceDI
            services.AddControllers();

            services.AddSingleton<ILoggerManager, LoggerManager>();

            services.AddScoped<IGenericRepository<Account>, GenericRepository<Account>>();
            services.AddScoped<IGenericRepository<Exam>, GenericRepository<Exam>>();
            services.AddScoped<IResultManagerRepository, ResultManagerRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddScoped<IUnitOfWork, MyUnitOfWork>();

            services.AddScoped<IAccountManagerService, AccountManagerService>();
            services.AddScoped<IExamManagerService, ExamManagerService>();
            services.AddScoped<IResultManagerService, ResultManagerService>();
            services.AddScoped<IQuestionManagerService, QuestionManagerService>();
            services.AddScoped<IAnswerManagerService, AnswerManagerService>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<ILoginService, LoginService>();
            #endregion
           
            #region AddDBContext
            services.AddDbContext<IApplicationDBContext, MyApplicationDBContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("MyDBSql_MiniProject_API");
                options.UseSqlServer(connectionString);
            });
            #endregion

            #region AddAutoMapper
            services.AddAutoMapper(mapperConfig =>
            {
                mapperConfig.AddProfile(typeof(AutoMapperExtension));
            });
            #endregion

            #region AddSwaggerGen
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ThangDV29_MiniProject_WebAPI", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
            #endregion

            #region AddAuthentication
            services.Configure<Appsetting>(configuration.GetSection("Jwt"));

            var secretKey = configuration["Jwt:SecretKey"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),
                };
            });
            #endregion
        }
    }
}
