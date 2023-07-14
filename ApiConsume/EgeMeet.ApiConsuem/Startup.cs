using EgeMeet.Bussines.Abstrack;
using EgeMeet.Bussines.Concrete;
using EgeMeet.BussinesLayer.Abstrack;
using EgeMeet.BussinesLayer.Concrete;
using EgeMeet.DataAcsseslayer.Abstract;
using EgeMeet.DataAcsseslayer.Concrete;
using EgeMeet.DataAcsseslayer.EntitiyFreamWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeMeet.ApiConsuem
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
            services.AddDbContext<Context>();
            services.AddScoped<IHomePageDal, EFHomePageDal>();
            services.AddScoped<IHomePageService, HomePagaManager>();
            services.AddScoped<IHowToUsDal, EFHowToUsDal>();
            services.AddScoped<IHowToUsService, HowToUsManager>();
            services.AddScoped<IMeetingDal, EFMeetingDal>();
            services.AddScoped<IMeetingService, MeetingManager>();
            services.AddAutoMapper(typeof(Startup));
           
            services.AddCors(opt =>
            {
                opt.AddPolicy("EgeMeet", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EgeMeet.ApiConsuem", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EgeMeet.ApiConsuem v1"));
            }

            app.UseRouting();
            app.UseCors("EgeMeet");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
