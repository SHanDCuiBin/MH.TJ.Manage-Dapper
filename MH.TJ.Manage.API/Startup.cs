using Autofac;
using log4net;
using log4net.Config;
using log4net.Repository;
using MH.TJ.Manage.Utility._Automapper;
using MH.TJ.Manage.Utility._Constant;
using MH.TJ.Manage.Utility._DapperExtentions;
using MH.TJ.Manage.Utility._DESEncrypt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MH.TJ.Manage.API
{
    public class Startup
    {
        public static ILoggerRepository LogRepository { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            LogRepository = LogManager.CreateRepository("NETCoreRepository");            //仓库的名字可以在配置文件中配置，也可以直接写死
            XmlConfigurator.Configure(LogRepository, new FileInfo("log4net.config"));    //读取配置文件
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
           {
               options.AddPolicy("default", policy =>
                       {
                           policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();

                       });
           });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MH.TJ.Manage.API", Version = "v1" });

                #region 使用JWT鉴权组件
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Description = "直接在下框中输入Bearer {token}（注意两者之间是一个空格）",
                    Name = "Authorization",
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                                          {
                                            {
                                              new OpenApiSecurityScheme
                                              {
                                                Reference=new OpenApiReference
                                                {
                                                  Type=ReferenceType.SecurityScheme,
                                                  Id="Bearer"
                                                }
                                              },
                                              new string[] {}
                                            }
                                          });
                #endregion

                //显示注释
                string dir = Path.GetDirectoryName(typeof(Program).Assembly.Location);  //应用程序根目录
                string xmlpath = Path.Combine(dir, "MH.TJ.Manage.API.xml");             //配置xml路径
                c.IncludeXmlComments(xmlpath);
            });

            services.AddConnectionstrings(Configuration);

            #region JWT鉴权
            services.AddCustomJWT();
            #endregion

            #region AutoMapper
            services.AddAutoMapper(typeof(CustomAutoMapperProfile));
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MH.TJ.Manage.API v1"));
            }

            app.UseCors("default");

            app.UseRouting();

            //鉴权
            app.UseAuthentication();

            //授权
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /// <summary>
        /// AutoIoc 
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var IRepository = Assembly.Load("MH.TJ.Manage.IRepository");
            var Repository = Assembly.Load("MH.TJ.Manage.Repository");
            builder.RegisterAssemblyTypes(IRepository, Repository)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().PropertiesAutowired();

            var IService = Assembly.Load("MH.TJ.Manage.IService");
            var Service = Assembly.Load("MH.TJ.Manage.Service");
            builder.RegisterAssemblyTypes(IService, Service)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().PropertiesAutowired();
        }


    }
    static class ICOExtend
    {
        public static IServiceCollection AddCustomJWT(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SDMC-CJAS1-SAD-DFSFA-SADHJVF-VF")),
                        ValidateIssuer = true,
                        ValidIssuer = "http://localhost:6060",
                        ValidateAudience = true,
                        ValidAudience = "http://localhost:55405",
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.FromMinutes(60)    //过期时间
                    };
                });

            return services;
        }

        public static void AddConnectionstrings(this IServiceCollection services, IConfiguration configuration)
        {
            DbConnectionInfo.connList.Add(new ConnectionInfo()
            {
                connId = BunissDataBaseEmum.basicinfoDB.ToString(),
                bunissDataBaseEmum = BunissDataBaseEmum.basicinfoDB,
                databaseType = DatabaseType.MySql,
                connsctionstring = DESEncrypt.JieMiStr_Con(configuration.GetSection("ConnectionStrings")["MysqlConn_BasicInfo"])
            });

            DbConnectionInfo.connList.Add(new ConnectionInfo()
            {
                connId = BunissDataBaseEmum.mhcmsDB.ToString(),
                bunissDataBaseEmum = BunissDataBaseEmum.mhcmsDB,
                databaseType = DatabaseType.MySql,
                connsctionstring = DESEncrypt.JieMiStr_Con(configuration.GetSection("ConnectionStrings")["MysqlConn_CMS"])
            });

            DbConnectionInfo.connList.Add(new ConnectionInfo()
            {
                connId = BunissDataBaseEmum.sysConfigDB.ToString(),
                bunissDataBaseEmum = BunissDataBaseEmum.sysConfigDB,
                databaseType = DatabaseType.MySql,
                connsctionstring = DESEncrypt.JieMiStr_Con(configuration.GetSection("ConnectionStrings")["MysqlConn_sys_config"])
            });

            string conn = DESEncrypt.JieMiStr_Con(configuration.GetSection("ConnectionStrings")["MysqlConn_HealthInfo"]);
            for (int i = DateTime.Now.Year; i >= 2015; i--)
            {
                DbConnectionInfo.connList.Add(new ConnectionInfo()
                {
                    connId = BunissDataBaseEmum.healthInfoDB.ToString() + i,
                    bunissDataBaseEmum = BunissDataBaseEmum.healthInfoDB,
                    databaseType = DatabaseType.MySql,
                    connsctionstring = conn.Replace("health_info", "health_info" + i)
                });
            }
        }
    }
}