using AbarisWebValidator.SampleWebValidator.Application.Services;
using AbarisWebValidator.SampleWebValidator.Domain;
using CoreWCF;
using CoreWCF.Configuration;

namespace AbarisWebValidator.SampleWebValidator.WCF
{
    public class BasicHttpBindingStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Enable CoreWCF Services, with metadata (WSDL) support
            services.AddServiceModelWebServices()
                .AddServiceModelMetadata();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseServiceModel(builder =>
            {
                // Add the WebValidator Service
                builder.AddService<WebValidatorService>(serviceOptions => { })
                // Add WebHttpBinding endpoint
                .AddServiceWebEndpoint<WebValidatorService, IWebvalidatorService>(new WebHttpBinding(), "/WebValidatorService/sampleService.svc")
                .AddServiceWebEndpoint<WebValidatorService, IWebvalidatorService>(new WebHttpBinding(WebHttpSecurityMode.Transport), "/WebValidatorService/sampleService.svc");

                // Configure WSDL to be available
                var serviceMetadataBehavior = app.ApplicationServices.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
                serviceMetadataBehavior.HttpGetEnabled = true;
            });

            app.UseHttpsRedirection();
        }
    }
}
