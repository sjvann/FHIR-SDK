
using Core.CdsHooks;
using Core.CdsHooks.Request;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace FHIRServer
{
    
    public static class CdsServiceApi
    {
        #region Public Method - WEB API
        public static void UseCdsServiceApi(this WebApplication app)
        {  
              app.MapGet("/api/cds-services",[EnableCors("cds")]  (IPrefetchService prefetchService) => Discovery(prefetchService));
              app.MapPost("/api/cds-services/{services}", [EnableCors("cds")]  (IPrefetchService prefetchService, IResponseService responseService,  string services,  [FromBody] RequestModel value) => ResponseServices(prefetchService, responseService, services, value));
        }
        #endregion
        #region Private Method 
        /// <summary>
        /// 取得CDS 所有服務項目清單
        /// </summary>
        /// <param name="prefetchService"></param>
        /// <returns></returns>
        private static IResult Discovery(IPrefetchService prefetchService)
        {
            if (prefetchService.GetHooks() != null)
            {
                return Results.Ok(prefetchService.GetHooks());
            }
            else
            {
                return Results.NotFound();
            }

        }
        /// <summary>
        /// 提供某CDS服務內容
        /// </summary>
        /// <param name="prefetchService"></param>
        /// <param name="responseService"></param>
        /// <param name="services"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static IResult ResponseServices(IPrefetchService prefetchService, IResponseService responseService, string services, RequestModel source)
        {
            ResponseModel result = new();

            var hook = prefetchService.GetHook(services);   //取得服務要求之資訊

            if(hook != null)
            {
                responseService.Setup(hook, source);
                result.Cards = responseService.GetResponseContent();
            }
            return Results.Ok(result);
        }

        #endregion
    }
}
