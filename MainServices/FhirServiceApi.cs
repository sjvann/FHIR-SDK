using Microsoft.AspNetCore.Mvc;

namespace FHIRServer
{
    public static class FhirServiceApi
    {
        public static void UseFhirR4Service(this WebApplication app)
        {
            app.MapGet("/api/R4/{resourceName}", (string resourceName, [FromQuery] object queryString) => DispatchResource(resourceName, queryString));
        }

        public static string DispatchResource(string resourceName, object queryString)
        {
            return resourceName;
        }
    }
}
