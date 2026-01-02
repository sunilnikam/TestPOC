
namespace Acceptify
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddControllers();
            // Accept header configuration: Content negotiation settings
            builder.Services.AddControllers(options => {
                options.RespectBrowserAcceptHeader = false;
                options.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            
            // Swagger code Start
            builder.Services.AddEndpointsApiExplorer(); // Required for Swagger to discover endpoints
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Your API Name",
                    Description = "A description of your API",
                    // You can add more information like TermsOfService, Contact, License
                });
            });
            // Swagger code End

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                // Swagger code Start
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name v1");
                    // You can also set a route prefix if desired: options.RoutePrefix = string.Empty;
                });
                // Swagger code End
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
