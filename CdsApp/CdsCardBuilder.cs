using CdsApp.Model;
using Core.CdsHooks;
using Core.CdsHooks.Cards;
using ResourceTypeServices.R5.ObservationSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CdsApp
{
    public class CdsCardBuilder : ICardBuilder
    { 
        private readonly Dictionary<string, JsonNode?>?  _dataSource;
        private List<CardModel>? _cardResult;
        public CdsCardBuilder(Dictionary<string, JsonNode?>? context)
        {
            _dataSource = context;
           

        }
        public CdsCardBuilder InitCardContent(string? serviceId)
        {   
            switch (serviceId)
            {
                case "bmichecker":
                    InitCardForBmiChecker();
                    break;
                default: break;
            }
            return this;
        }


        #region Private Method

        private void InitCardForBmiChecker()
        {
            //讀取Observation的內容值
            if(_dataSource != null && _dataSource.ContainsKey("Observation"))
            {
                var targetSource = _dataSource["Observation"] as JsonNode;
                ResourceLoader rl = new ResourceLoader(targetSource);
                var targetResource = rl.GetReSource<Observation>();
                if (targetResource != null && targetResource.Any() ) {
                    var checkResult = new BmiChecker(targetResource);
                   _cardResult = checkResult.GetCardResult().ToList();
                }
            }
        }

        public IEnumerable<CardModel> GetCardResult() => _cardResult ?? new List<CardModel>();

        #endregion

    }
}
