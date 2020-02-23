using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComBusi.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ComBusi.Back
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

 
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddMvc(option => option.EnableEndpointRouting = false);
      var databaseConnection = @"Server=DESKTOP-AHU9E0V\MSSQLSERVERR;Database=ComBusiDatabase;Trusted_Connection=True;ConnectRetryCount=0";
      services.AddDbContext<ComBusiContext>(options => options.UseSqlServer(databaseConnection));
    }


    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
