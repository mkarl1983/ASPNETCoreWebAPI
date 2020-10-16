using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using AerosparesWebAPI.Helpers;
using AerosparesWebAPI.MappingProfiles;
using AerosparesWebAPI.Repositories;
using AerosparesWebAPI.Services;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace AerosparesWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        //   <add name = "QuantumEntities" connectionString="metadata=res://*/QuantumModel.csdl|res://*/QuantumModel.ssdl|res://*/QuantumModel.msl;provider=Oracle.ManagedDataAccess.Client;provider connection string=&quot;data source=MAXQPROD;password=report;persist security info=True;user id=CRYSTAL&quot;" providerName="System.Data.EntityClient" />
        //  <add name = "Connection" connectionString="data source=MAXQPROD;dba privilege=SYSDBA;password=masterkey;persist security info=True;user id=SYS" providerName="Oracle.DataAccess.Client" />

        //Scaffold-DbContext "User Id=SYS;Password=masterkey;dba privilege=SYSDBA;Data Source=aero-spares-db2:1521/CCTL;" Oracle.EntityFrameworkCore -OutputDir QuantumEntities
        
        // Scaffold-DbContext "User Id=SYS;Password=masterkey;dba privilege=SYSDBA;Data Source=aero-spares-db2:1521/CCTL;" Oracle.EntityFrameworkCore -OutputDir Models -Tables QCTL.AGENTS,QCTL.ALTERNATE_TYPE_CODES,QCTL.AP_ACCOUNT,QCTL.AP_DETAIL,QCTL.APPLICATION_CODES,QCTL.AR_ACCOUNT,QCTL.AR_DETAIL,QCTL.COMPANIES,QCTL.COMPANY_LIST,QCTL.CQ_DETAIL,QCTL.CQ_HEADER,QCTL.CQ_STATUS,QCTL.CURRENCY,QCTL.INVC_DETAIL,QCTL.INVC_HEADER,QCTL.PARTS_CATALOG,QCTL.PARTS_MASTER,QCTL.PO_DETAIL,QCTL.PO_HEADER,QCTL.PO_STATUS,QCTL.RC_DETAIL,QCTL.RC_DISP_CODES,QCTL.RC_HEADER,QCTL.RC_SERIAL,QCTL.RC_STATUS,QCTL.RO_CATEGORY_CODES,QCTL.RO_CONTROL,QCTL.RO_DETAIL,QCTL.RO_HEADER,QCTL.RO_PIECE_PARTS,QCTL.RO_PRE_COSTING_CHARGES,QCTL.RO_SALES,QCTL.RO_STATUS,QCTL.SM_DETAIL,QCTL.SM_HEADER,QCTL.SM_HISTORY,QCTL.SM_STATUS,QCTL.SO_DETAIL,QCTL.SO_HEADER,QCTL.SO_STATUS,QCTL.STOCK,QCTL.SYS_USERS
         
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddDbContext<AccountDbContext>(opt => opt.UseInMemoryDatabase("AerosparesWebAPIDatabase"));
           // services.AddDbContext<QDBContext>(options => options.UseOracle(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCustomCors("AllowAllOrigins");

            services.AddSingleton<ISeedDataService, SeedDataService>();
            services.AddHttpClient<IAddressRestService, AddressRestService>();
            services.AddScoped<IAccountRepository, AccountSqlRepository>();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper>(x =>
            {
                var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
                var factory = x.GetRequiredService<IUrlHelperFactory>();
                return factory.GetUrlHelper(actionContext);
            });
            
            services.AddControllers()
                   .AddNewtonsoftJson(options =>
                       options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver())
                            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddVersioning();
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(AccountMappings));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            ILoggerFactory loggerFactory, 
            IWebHostEnvironment env, 
            IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
                app.AddProductionExceptionHandling(loggerFactory);
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("AllowAllOrigins");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(
                options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                            $"/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                    }
                });
        }
    }
}
