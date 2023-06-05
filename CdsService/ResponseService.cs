using CdsApp;
using Core.CdsHooks;
using Core.CdsHooks.Cards;
using Core.CdsHooks.Request;
using System.Reflection;
using System.Text.Json.Nodes;

namespace CdsServices
{
    public class ResponseService : IResponseService
    {
        HookServiceModel? _hook;
        Dictionary<string, JsonNode?>? _contextSource;
        #region Public Method
        public void Setup(HookServiceModel hook, RequestModel source)
        {
            _hook = hook;
           _contextSource = SetupSource(source);
          
        }

        public List<CardModel> GetResponseContent()
        {   
            return  SetupCard();
        }

        #endregion



        #region Private Method
        private static Dictionary<string, JsonNode?> SetupSource(RequestModel source)
        {

            Dictionary<string, JsonNode?> result = new();

            if (source != null)
            {
                if (source.Context?.ToString() is string contexts && JsonNode.Parse(contexts) is JsonObject contextJson)
                {
                    foreach (var item in contextJson)
                    {
                        result.Add(item.Key, item.Value);
                    }
                }

                if (source.Prefetch?.ToString() is string prefetch && JsonNode.Parse(prefetch) is JsonObject prefetchJson)
                {
                    foreach (var item in prefetchJson)
                    {
                        result.Add(item.Key, item.Value);
                    }
                }
            }
            return result;
        }
        private List<CardModel> SetupCard()
        {
            List<CardModel> result = new();
            
            if (_hook != null && _hook.Id != null && _hook.AppName != null && _hook.AppName.Split('.').Length > 1)
            {
                string assemblyName = $"{_hook.AppName}, {_hook.AppName.Split('.')[0]}";
                Type? assembleType = Type.GetType(assemblyName);
                if (assembleType != null)
                {
                    var cardBuilder = Activator.CreateInstance(assembleType, _contextSource) as ICardBuilder;
                    if(cardBuilder != null)
                    {
                        MethodInfo? method = assembleType.GetMethod("InitCardContent");
                        if (method != null)
                        {
                            method.Invoke(cardBuilder, new object[] { _hook.Id });
                        }
                         result.AddRange(cardBuilder.GetCardResult());
                    }
                }
            }
            return result;
        }

        #endregion

    }
}
