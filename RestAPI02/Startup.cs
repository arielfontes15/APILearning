using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestAPI02.Data;
using RestAPI02.Negocio;
using RestAPI02.Negocio.Implementacoes;
using RestAPI02.Repositorio;
using RestAPI02.Repositorio.Implementacoes;
using Serilog;
using System;

namespace RestAPI02
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        // This method gets called by the runtime. Use this method to add Negocio to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers();
            services.AddDbContext<Context>();

            //Injeção de dependencia para versionar a API Versioning api #Instalar o Package microsoft.aspnetcore.mvc.versioning
            services.AddApiVersioning();

            //Injecao de dependencia
            services.AddScoped<IPessoaNegocio, PessoaNegocioImplementacao>();
            services.AddScoped<ILivroNegocio, LivroNegocioImplementacao>();
            services.AddScoped<IPessoaRepositorio, PessoaRepositorioImplementacao>();
            services.AddScoped<ILivroRepositorio, LivroRepositorioImplementacao>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestAPI02", Version = "v1" });
            });
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestAPI02 v1"));
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
