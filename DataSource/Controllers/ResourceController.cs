using DataSource.Models;
using DataSource.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using ResourceTypeBased;
using SQLitePCL;
using System.ComponentModel.Design;
using System.Text.Json.Nodes;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace DataSource.Controllers {

    [ApiController]
    public class ResourceController : UmbracoApiController {

        private readonly IContentService _cs;
        private readonly IWebHostEnvironment _env;
        #region Public Method
        #region Get Method
        public ResourceController(IContentService cs, IWebHostEnvironment env) {
            _cs = cs;
            _env = env;
            


        }

        [Route("api/{resourceName}/{id}")]
        [HttpGet]
        public Object? GetById(string resourceName, int id) {

            var contentResult = _cs.GetById(id);
            object? response = null;
            if(contentResult != null && contentResult.ContentType.Name == $"Umbraco{resourceName}") {
                string? path = contentResult.GetValue<string>("fHIRPath");
                if (path != null) {
                    response =  GetJsonContent(path);
                }
            }
            return response;
           
        }

        [Route("api/{resourceName}")]
        [HttpGet]
        public IEnumerable<ResponseResource> GetByResource(string resourceName, int page = 0, int pageSize = 10) {

            //Prepare
            var root = _cs.GetRootContent().FirstOrDefault(x => x.Name == resourceName);
            List<ResponseResource> responses = new();
            long totalChildren;
            if (root != null && _cs.HasChildren(root.Id)) {

                var children = _cs.GetPagedChildren(root.Id, page, pageSize, out totalChildren);
                if (children != null && children.Any()) {
                    foreach (var item in children) {
                        string? path = item.GetValue<string>("fHIRPath");
                        if (path != null) {
                            responses.Add(new ResponseResource {
                                ResourceType = resourceName,
                                Resource = GetJsonContent(path)
                            });
                        }

                    }
                }
            }

            return responses;
        }


        #endregion
        #region Post Method
         [Route("api/{resourceName}")]
        [HttpPost]
        public IActionResult PostResource(string resourceName,[FromBody] object content)
        {
            var  _resourceRoot = _cs.GetRootContent().Where(x => x.ContentType.Alias == "resourceRoot").FirstOrDefault(x => x.Name == resourceName);
            if (_resourceRoot == null) return BadRequest("Resource Root is not exist");
            IContent newContent = _cs.Create(Guid.NewGuid().ToString(), _resourceRoot.Id, $"Umbraco{resourceName}");
            FhirService.SaveContentFromResource(content,ref newContent);
            var result =  _cs.SaveAndPublish(newContent);
           
            return Ok(result.Success);

        }
        #endregion
        #endregion

        #region Private Method

        private object? GetJsonContent(string path) {

            var filePath = _env.WebRootPath + path;
            var content = System.IO.File.ReadAllBytes(filePath);
            Stream stream = new MemoryStream(content);
            return JsonNode.Parse(stream);
        }

        //private IResourceService ResourceServiceChoicer(string resourceName)
        //{
        //   switch(resourceName)
        //    {
        //        case "Basic":
        //          return  new ResourceService<ResourceTypeServices.R5.BasicSub.Basic>(_cs);
        //    }
          
        //}


        #endregion


    }
}
