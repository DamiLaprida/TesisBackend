using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGetOut.Common;
using WebAPIGetOut.Data;
using WebAPIGetOut.Domain;
using WebAPIGetOut.Persistence.Interfaces;
using WebAPIGetOut.Persistence.Repositories;
using WebAPIGetOut.Security;

namespace WebAPIGetOut
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
            services.AddMvc(setup =>
            {
                
            }).AddFluentValidation();

            #region Validators
            services.AddTransient<IValidator<Empleado>, EmpleadoValidador>();
            services.AddTransient<IValidator<Producto>, ProductoValidador>();
            services.AddTransient<IValidator<Recibo>, ReciboValidador>();
            services.AddTransient<IValidator<Reserva>, ReservaValidador>();
            services.AddTransient<IValidator<Usuario>, UsuarioValidador>();
            #endregion
            
            #region Repositories
            services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion

            //services.AddCors(options =>
            //{
            //    var frontentendURL = 
            //});

            //AutoMapper
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPIGetOut", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var applicationServices = app.ApplicationServices;
            var configuration = applicationServices.GetRequiredService<IConfiguration>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPIGetOut v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
