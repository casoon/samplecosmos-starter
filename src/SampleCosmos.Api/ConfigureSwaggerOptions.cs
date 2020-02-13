using System;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SampleCosmos.Api
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }

        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = "Sample Cosmos API",
                Version = description.ApiVersion.ToString(),
                Description = "API description",
            };

            if (description.IsDeprecated)
            {
                info.Description += " API version is deprecated.";
            }

            return info;
        }
    }
}
