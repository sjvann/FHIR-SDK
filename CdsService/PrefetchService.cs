using Core.CdsHooks;
using Microsoft.Extensions.Configuration;


namespace CdsServices
{
    public class PrefetchService : IPrefetchService
    {
        private IEnumerable<HookServiceModel>? _hooks;

        public PrefetchService()
        {
            var configFile = File.Exists("/var/config/hooksettings.json") ? "/var/config/hooksettings.json" : "hooksettings.json";
            LoadParameter(configFile);

        }


        #region Public Method

        public HookServiceModel? GetHook(string id)
        {
            return _hooks?.First(x => x.Id == id);
        }

        public ServicesModel? GetHooks()
        {
            return new ServicesModel() { Services = _hooks };
        }
        #endregion
        #region Private Method
        private void LoadParameter(string configFile)
        {
            ConfigurationManager configMag = new();
            configMag.AddJsonFile(configFile);
            List<HookServiceModel> hookList = new();


            var sectionHookModels = configMag.GetSection("HookModels");
            if (sectionHookModels != null && sectionHookModels.GetChildren().Any())
            {
                foreach (var hook in sectionHookModels.GetChildren())
                {
                    hookList.Add(new HookServiceModel()
                    {
                        Hook = hook["Hook"] ?? string.Empty,
                        Title = hook["Title"] ?? string.Empty,
                        Description = hook["Description"] ?? string.Empty,
                        Id = hook["Id"] ?? string.Empty,
                        AppName = hook["AppName"] ?? string.Empty,
                        Prefetch = SetupPrefetch(hook.GetSection("Prefetch"))
                    });
                }
            }
            _hooks = hookList;
        }
        private static Dictionary<string, string> SetupPrefetch(IConfigurationSection? sectionPrefetch)
        {
            Dictionary<string, string> prefetchs = new();
            if (sectionPrefetch != null && sectionPrefetch.GetChildren().Any())
            {
                foreach (var item in sectionPrefetch.GetChildren())
                {
                    prefetchs.Add(item["Key"], item["Value"]);
                }
            }
            return prefetchs;
        }

        #endregion

    }
}
