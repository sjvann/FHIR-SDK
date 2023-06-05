using Umbraco.Cms.Core.Models;
using ResourceTypeServices.R5;
using ResourceTypeBased;
using System.Text.Json;
using Umbraco.Cms.Web.Common.PublishedModels;
using DataTypeService.Special;
using DataTypeService.Based;
using Core.Extension;

namespace DataSource.Services
{
    public static class FhirService
    {

        public static void SaveContentFromResource(object source, ref IContent target)
        {
            string? targetString = source.ToString();
            if (targetString is string cString)
            {
                using (JsonDocument jDoc = JsonDocument.Parse(cString))
                {
                    JsonElement jRoot = jDoc.RootElement;
                    string? thisResourceName = jRoot.GetProperty("resourceType").GetString();

                    switch (thisResourceName)
                    {
                        case "Basic":
                          BasicContent(ref target,cString);
                            break;
                        default:
                            break;

                    }

                }

            }

        }

        private static void BasicContent(ref IContent target, string cString)
        {
            Basic source = new Basic(cString);
            SetupMetaValue(ref target, source.Meta);
            target.SetValue("author", source.Author);
          
        }



        private static void SetupMetaValue(ref IContent target, Meta? meta)
        {
            if(meta != null)
            {
                target.SetValue("versionId", CheckVersion(meta.VersionId));
                target.SetValue("lastUpdated", CheckLastUpdated());

            }
        }

        #region Support Method
        private static string CheckLastUpdated()
        {
            return DateTime.UtcNow.ToLongDateString();

        }

        private static string CheckVersion(DataTypeService.Primitive.FhirId? source)
        {
            if(source != null && source.Value is string version)
            {
                var current = int.Parse(version);
                return Convert.ToString(current + 1);
            }
            else
            {
                return "1";
            }

        }
        #endregion
    }
}
